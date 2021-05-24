using ModelTool.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelTool.Core
{
    static class ModelGenerator
    {
        public static string Generate(ModelSetting setting)
        {
            var tab_builder = new StringBuilder(setting.TabSpace);
            for (var i = 0; i < setting.TabSpace; ++i)
            {
                tab_builder.Append(" ");
            }
            var tab = tab_builder.ToString();
            var tab2x = tab + tab;

            return $@"{setting.Using.Trim()}

namespace {setting.Namespace}
{{
{tab}{setting.AccessModifier} class {setting.ModelName}
{tab}{{
{GetColumnString(setting.Columns, setting.UseSummary, tab2x)}
{tab}}}
}}";

        }

        private static string GetColumnString(List<ColumnInfo> columns, bool useSummary, string tab)
        {
            return string.Join(@"

", columns.Select(e =>
            {
                var tmp = new StringBuilder(2);
                if (useSummary)
                {
                    tmp.Append($@"{tab}/// <summary>
{tab}/// {e.Summary}
{tab}/// </summary>
");
                }
                tmp.Append($"{tab}public {GetType(e.Type, e.IsNullable)} {e.Name} {{ get; set; }}");

                return tmp.ToString();
            }));
        }

        private static string GetType(string type, bool nullable)
        {
            switch (type)
            {
                case "bigint":
                    return $"long{(nullable ? "?" : "")}";
                case "smallint":
                    return $"short{(nullable ? "?" : "")}";
                case "tinyint":
                    return $"byte{(nullable ? "?" : "")}";
                case "bit":
                    return $"bool{(nullable ? "?" : "")}";
                case "numeric":
                case "money":
                case "smallmoney":
                    return $"decimal{(nullable ? "?" : "")}";
                case "float":
                    return $"double{(nullable ? "?" : "")}";
                case "real":
                    return $"float{(nullable ? "?" : "")}";
                case "date":
                case "time":
                case "datetime":
                case "datetime2":
                case "datetimeoffset":
                case "smalldatetime":
                case "timestamp":
                    return $"DateTime{(nullable ? "?" : "")}";
                case "char":
                case "nchar":
                case "varchar":
                case "nvarchar":
                case "text":
                case "ntext":
                    return "string";
                case "binary":
                case "varbinary":
                case "image":
                    return "byte[]";
                case "uniqueidentifier":
                    return $"Guid{(nullable ? "?" : "")}";
                case "int":
                case "decimal":
                    return $"{type}{(nullable ? "?" : "")}";
                case "sql_variant":
                case "hierarchyid":
                case "geometry":
                case "geography":
                case "xml":
                case "sysname":
                default:
                    return "object";
            }
        }
    }
}
