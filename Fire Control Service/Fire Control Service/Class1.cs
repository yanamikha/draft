using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;

namespace Fire_Control_Service
{
    class DbSchemaMigrator : Migration, IDbSchemaMigrator
    {
        public Task AddTableColumns(string tableName, IEnumerable<TableColumnConfig> columns)
        {
            throw new NotImplementedException();
        }

        public Task CreateTable(TableConfig table)
        {
            throw new NotImplementedException();
        }
        public Task UpdateTableColumns(string tableName, IEnumerable<TableColumnConfig> columns)
        {
            throw new NotImplementedException();
        }

        public Task DropTableColumns(string tableName, IEnumerable<string> tableColumnNames)
        {
            throw new NotImplementedException();
        }

        public Task<TableConfig> GetTable(string tableName)
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            throw new NotImplementedException();
        }
        public override void Down()
        {
            throw new NotImplementedException();
        }


    }
}
