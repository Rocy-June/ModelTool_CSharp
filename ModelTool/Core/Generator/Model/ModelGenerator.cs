using ModelTool.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelTool.Core.Generator.Model
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
            var nullableStr = nullable ? "?" : "";
            switch (type)
            {
                case "tinyint":
                    return $"byte{nullableStr}";
                case "bit":
                    return $"bool{nullableStr}";
                case "smallint":
                    return $"short{nullableStr}";
                case "mediumint":
                case "integer":
                    return $"int{nullableStr}";
                case "bigint":
                    return $"long{nullableStr}";
                case "numeric":
                case "money":
                case "smallmoney":
                    return $"decimal{nullableStr}";
                case "float":
                    return $"double{nullableStr}";
                case "real":
                    return $"float{nullableStr}";
                case "date":
                case "time":
                case "year":
                case "datetime":
                case "datetime2":
                case "datetimeoffset":
                case "smalldatetime":
                case "timestamp":
                    return $"DateTime{nullableStr}";
                case "char":
                case "nchar":
                case "varchar":
                case "nvarchar":
                case "text":
                case "ntext":
                case "tinytext":
                case "blob":
                case "mediumblob":
                case "mediumtext":
                case "longblob":
                case "longtext":
                    return "string";
                case "binary":
                case "varbinary":
                case "image":
                    return "byte[]";
                case "uniqueidentifier":
                    return $"Guid{nullableStr}";
                case "int":
                case "decimal":
                    return $"{type}{nullableStr}";
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
