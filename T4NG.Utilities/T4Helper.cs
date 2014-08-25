using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4NG.Utilities
{
    public static class T4Helper
    {
        public static string ConvertToClrType(string databaseTypeName, bool nullable)
        {
            Dictionary<string, string> _ClrMapping = new Dictionary<string, string>()
                {
                    {"BIT", "bool"},
                    {"TINYINT", "Int16"},
                    {"INT", "int"},
                    {"BIGINT", "Int64"},
                    {"SMALLMONEY", "Decimal"},
                    {"MONEY", "Decimal"},
                    {"DECIMAL", "Decimal"},
                    {"NUMERIC", "Decimal"},
                    {"REAL", "Single"},
                    {"FLOAT", "Double"},
                    {"CHAR", "string"},
                    {"NCHAR", "string"},
                    {"VARCHAR", "string"},
                    {"NVARCHAR", "string"},
                    {"TEXT", "string"},
                    {"NTEXT", "string"},
                    {"XML", "System.Xml.Linq.XElement"},
                    {"SMALLDATETIME", "DateTime"},
                    {"DATETIME", "DateTime"},
                    {"DATETIME2", "DateTime"},
                    {"DATETIMEOFFSET", "DateTime"},
                    {"DATE", "DateTime"},
                    {"TIME", "TimeSpan"},
                    {"BINARY", "System.Data.Linq.Binary"},
                    {"VARBINARY", "System.Data.Linq.Binary"},
                    {"IMAGE", "System.Data.Linq.Binary"},
                    {"TIMESTAMP", "System.Data.Linq.Binary"},
                    {"UNIQUEIDENTIFIER", "Guid"},
                    {"SQL_VARIANT", "Object"},
                    {"SMALLINT", "System.SByte"}
                };

            string clrType = string.Empty;

            if (_ClrMapping.ContainsKey(databaseTypeName.ToUpper()))
            {
                clrType = _ClrMapping[databaseTypeName.ToUpper()];
            }
            else
            {
                // clrType = "??" + databaseTypeName;
                clrType = "object";
            }

            if (nullable && clrType != "string" && clrType != "object")
            {
                clrType += "?";
            }
            return clrType;

        }
    }
}
