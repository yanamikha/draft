using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Control_Service
{
    public interface IDbSchemaMigrator
    {
        Task CreateTable(TableConfig table);
        Task<TableConfig> GetTable(string tableName);
        Task AddTableColumns(string tableName, IEnumerable<TableColumnConfig> columns);
        Task UpdateTableColumns(string tableName, IEnumerable<TableColumnConfig> columns);
        Task DropTableColumns(string tableName, IEnumerable<string> tableColumnNames);
    }
}
