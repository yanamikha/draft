using Authenticity;
using ClientServerServices.Exceptions;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace ClientServerServices
{
    public class ViewDataAdapter
    {
        private Channel channel;
        private ViewService.ViewServiceClient viewService;
        private VGrid vGrid;
        private DataTable dataTable;
        public ViewDataAdapter()
        {
            if (channel is null) channel = ClientChannel.GetChannel();
            if (viewService is null) viewService = new ViewService.ViewServiceClient(channel);
        }

        private static System.Type ConvertValueTypeToSystemType(View.ValueType valueType)
        {
            switch (valueType)
            {
                case View.ValueType.BoolValue: return typeof(bool);
                case View.ValueType.NoneValue: return null;
                case View.ValueType.DoubleValue: return typeof(double);
                case View.ValueType.FloatValue: return typeof(float);
                case View.ValueType.Int32Value: return typeof(int);
                case View.ValueType.Int64Value: return typeof(long);
                case View.ValueType.Uint32Value: return typeof(uint);
                case View.ValueType.Uint64Value: return typeof(ulong);
                case View.ValueType.StringValue: return typeof(string);
                case View.ValueType.Uuidvalue: return typeof(Guid);
                case View.ValueType.HintValue: return typeof(string);
                case View.ValueType.DateTimeValue: return typeof(System.DateTime);
                default: return null;
            }
        }
        private static object GetCellData(VCell data)
        {
            try
            {
                switch (data.ValueCase.ToString())
                {
                    case "DoubleValue": return data.DoubleValue;
                    case "FloatValue": return data.FloatValue;
                    case "Int32Value": return data.Int32Value;
                    case "Int64Value": return data.Int64Value;
                    case "Uint32Value": return data.Uint32Value;
                    case "Uint64Value": return data.Uint64Value;
                    case "BoolValue": return data.BoolValue;
                    case "StringValue": return data.StringValue;
                    case "UUIDValue": return data.UUIDValue;
                    case "RelID": return Convert.ToString(data.HintValue);
                    case "DateTimeValue": return new System.DateTime(data.DateTimeValue.Value);
                }
                return null;
            }
            catch (Exception e) { /*Log.Write(e); */ return null; }

        }
        public static VCell ConvertData(object data, View.ValueType valueType)
        {
            VCell vCell = new VCell();
            switch (valueType)
            {
                case View.ValueType.BoolValue:
                    {
                        vCell.BoolValue = (bool)data;
                        return vCell;
                    };
                case View.ValueType.DoubleValue:
                    {
                        vCell.DoubleValue = Convert.ToDouble(data);
                        return vCell;
                    };
                case View.ValueType.FloatValue:
                    {
                        vCell.FloatValue = Convert.ToSingle(data);
                        return vCell;
                    };
                case View.ValueType.HintValue:
                    {
                        vCell.HintValue = Convert.ToString(data);
                        return vCell;
                    };
                case View.ValueType.Int32Value:
                    {
                        vCell.Int32Value = Convert.ToInt32(data);
                        return vCell;
                    };
                case View.ValueType.Int64Value:
                    {
                        vCell.Int64Value = Convert.ToInt64(data);
                        return vCell;
                    };
                case View.ValueType.StringValue:
                    {
                        vCell.StringValue = Convert.ToString(data);
                        return vCell;
                    };
                case View.ValueType.Uint32Value:
                    {
                        vCell.Uint32Value = Convert.ToUInt32(data);
                        return vCell;
                    };
                case View.ValueType.Uint64Value:
                    {
                        vCell.Uint64Value = Convert.ToUInt64(data);
                        return vCell;
                    };
                case View.ValueType.Uuidvalue:
                    {
                        vCell.UUIDValue = Convert.ToString(data);
                        return vCell;
                    };

            }
            return vCell;
        }

        public async Task<Dictionary<string, string>> GetRegisteredViewAsync(string tokenValue)
        {
            if (tokenValue == null) throw new RegisteredViewException("Реєстрацію не пройдено");
            try
            {
                RVResponse rVResponse = await viewService.GetRegisteredViewAsync(new Authenticity.Token { Value = tokenValue });
                if (rVResponse != null && rVResponse.RegisteredViews != null && rVResponse.RegisteredViews.Count != 0)
                {
                    Dictionary<string, string> viewList = new Dictionary<string, string>(rVResponse.RegisteredViews.Count);
                    foreach (var regView in rVResponse.RegisteredViews)
                    {
                        viewList.Add(regView.VName, regView.DisplayName);
                    }
                    return viewList;
                }
                else throw new RegisteredViewException("Доступні таблиці відсутні");
            }
            catch (Exception e)
            {
                throw new RegisteredViewException($"Помилка завантаження таблиць: {e.Message}", e);
            }
        }

        public async Task FillDataGridViewAsync(string tokenValue, string viewName, DataGridView gridView, IList<VCondition> conditions = null)
        {
            if (tokenValue == null || viewName == null) throw new FillDataGridException("Реєстрацію не пройдено");
            VQuery vQuery = new VQuery
            {
                Statement = Statement.Select
            };
            if (conditions != null && conditions.Count > 0) vQuery.Conditions.AddRange(conditions);
            VRequest vRequest = new VRequest
            {
                Query = vQuery,
                Token = new Authenticity.Token { Value = tokenValue },
                VName = viewName
            };
            VResponse vResponse;
            try
            {
                vResponse = await viewService.ViewEventAsync(vRequest);
            }
            catch (Exception e)
            {
                throw new FillDataGridException($"Помилка завантаження таблиці {viewName}: {e.Message}", e);
            }
            if (dataTable != null) dataTable.Clear();
            else dataTable = new DataTable();
            dataTable.TableName = viewName;
            gridView.Columns.Clear();
            vGrid = vResponse.Grid;
            foreach (var c in vGrid.Columns)
            {
                DataColumn column = new DataColumn
                {
                    Caption = c.Name,
                    ColumnName = c.DisplayName,
                    DataType = ConvertValueTypeToSystemType(c.ValueType)
                };
                dataTable.Columns.Add(column);
            }

            foreach (VRow r in vGrid.Rows)
            {
                if (r.Cells.Count != vGrid.Columns.Count)
                {
                    throw new FillDataGridException("Помилка завантаження таблиці: Кількість стовців у рядку не співпадає з кількістю стовпчиків таблиці");
                }
                DataRow dataRow = dataTable.NewRow();
                for (int i = 0; i < r.Cells.Count; i++)
                {
                    VCell cell = r.Cells[i];
                    dataRow[i] = GetCellData(cell);

                }
                dataTable.Rows.Add(dataRow);
            }
            dataTable.AcceptChanges();
            gridView.AllowUserToOrderColumns = false;
            gridView.RowHeadersVisible = false;
            gridView.DataSource = dataTable;
            gridView.Columns["Ідентифікатор"].Visible = false;
            gridView.AutoResizeColumns();
            gridView.Refresh();
        }

        public VColumnInfo GetColumnInfoByIndex(int index)
        {
            return vGrid.Columns[index];
        }

        public async Task SaveChanges(string token)
        {
            Token t = new Token { Value = token };
            DataTable modifiedRows = dataTable.GetChanges(DataRowState.Modified);
            DataTable insertedRows = dataTable.GetChanges(DataRowState.Added);
            if (modifiedRows != null)
            {
                foreach (DataRow dataRow in modifiedRows.Rows)
                {
                    VQuery query = new VQuery { Statement = Statement.Update };
                    for (int i = 0; i < vGrid.Columns.Count; i++)
                    {
                        VColumnInfo column = vGrid.Columns[i];
                        if (column.ValueType == View.ValueType.HintValue)
                        {
                            var hints = GetHintValues(column, token);
                            var pair = hints.FirstOrDefault(c => c.Value == dataRow[column.DisplayName].ToString());
                            string hintId = pair.Key;
                            query.Conditions.Add(new VCondition { ColumnName = column.Name, Operators = Operator.NoneOperator, Value = ConvertData(hintId, column.ValueType) });
                            continue;
                        }
                        query.Conditions.Add(new VCondition { ColumnName = column.Name, Operators = Operator.NoneOperator, Value = ConvertData(dataRow[column.DisplayName], column.ValueType) });
                    }
                    query.Conditions.Add(new VCondition { ColumnName = vGrid.Columns[0].Name, Operators = Operator.Equally, Value = new VCell { UUIDValue = dataRow[vGrid.Columns[0].DisplayName].ToString() } });
                    VRequest request = new VRequest { Token = t, VName = dataTable.TableName, Query = query };
                    try
                    {
                        VResponse response = await viewService.ViewEventAsync(request);
                    }
                    catch (Exception e)
                    {
                        throw new SaveChangesException($"Помилка запису в БД: {e.Message}", e);
                    }
                }
            }
            if (insertedRows != null)
            {
                foreach (DataRow dataRow in insertedRows.Rows)
                {
                    VQuery query = new VQuery { Statement = Statement.Insert };
                    for (int i = 0; i < vGrid.Columns.Count; i++)
                    {
                        VColumnInfo column = vGrid.Columns[i];
                        if (column.ValueType == View.ValueType.HintValue)
                        {
                            var hints = GetHintValues(column, token);
                            var pair = hints.FirstOrDefault(c => c.Value == dataRow[column.DisplayName].ToString());
                            string hintId = pair.Key;
                            query.Conditions.Add(new VCondition { ColumnName = column.Name, Operators = Operator.Equally, Value = ConvertData(hintId, column.ValueType) });
                            continue;
                        }
                        query.Conditions.Add(new VCondition { ColumnName = column.Name, Operators = Operator.Equally, Value = ConvertData(dataRow[column.DisplayName], column.ValueType) });
                    }
                    VRequest request = new VRequest { Token = t, VName = dataTable.TableName, Query = query };
                    try
                    {
                        VResponse response = await viewService.ViewEventAsync(request);
                    }
                    catch (Exception e)
                    {
                        throw new SaveChangesException($"Помилка запису в БД: {e.Message}", e);
                    }
                }
            }
        }

        public Dictionary<string, string> GetHintValues(VColumnInfo columnInfo, string token)
        {
            Token t = new Token { Value = token };
            HResponse hint = viewService.ShowHint(new HRequest { Token = t, HColumns = new HColumn() { ColumnName = columnInfo.Name, VName = dataTable.TableName } });
            Dictionary<string, string> hints = new Dictionary<string, string>();
            foreach (var h in hint.Hints)
            {
                hints.Add(h.Key.UUIDValue, h.Value.StringValue);
            }
            return hints;
        }
    }
}
