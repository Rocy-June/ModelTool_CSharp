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

            var modelSummary = setting.UseSummary
                ? $"\r\n{GetSummaryString(setting.ModelSummary, tab)}"
                : string.Empty;

            var inherit = string.IsNullOrWhiteSpace(setting.Inherit)
                ? string.Empty
                : $" : {setting.Inherit}";

            return $@"{setting.Using}

namespace {setting.Namespace}
{{{modelSummary}
{tab}{setting.AccessModifier} class {setting.ModelName}{inherit}
{tab}{{
{GetColumnString(setting, tab2x)}
{tab}}}
}}";

        }

        private const string SUGAR_COLUMN_SPLITOR = ", ";
        private static string GetColumnString(ModelSetting setting, string tab)
        {
            return string.Join(@"

", setting.Columns.Select(e =>
            {
                var sb = new StringBuilder();
                if (setting.UseSummary)
                {
                    sb.AppendLine(GetSummaryString(e.Summary, tab));
                }
                if (setting.EnableSQLSugarSupport)
                {
                    //[SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "")]
                    sb.Append($"{tab}[SugarColumn(ColumnName = \"{e.Name}\"");
                    sb.Append(SUGAR_COLUMN_SPLITOR);
                    if (e.IsPrimaryKey)
                    {
                        sb.Append($"IsPrimaryKey = true");
                        sb.Append(SUGAR_COLUMN_SPLITOR);
                    }
                    if (e.IsIdentity)
                    {
                        sb.Append($"IsIdentity = true");
                        sb.Append(SUGAR_COLUMN_SPLITOR);
                    }

                    sb.Remove(sb.Length - 2, 2);
                    sb.AppendLine(")]");
                }

                sb.Append($"{tab}public {GetType(e.Type, e.IsNullable)} {e.Name} {{ get; set; }}");

                return sb.ToString();
            }));
        }

        private static string GetSummaryString(string summary, string tab)
        {
            return $@"{tab}/// <summary>
{tab}/// {summary}
{tab}/// </summary>";
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
                case "sysname":
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
                default:
                    return "object";
            }
        }
    }
}
