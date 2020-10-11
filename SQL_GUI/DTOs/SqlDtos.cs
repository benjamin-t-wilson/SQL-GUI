using System.Collections.Generic;

namespace SQL_GUI.DTOs
{
    public class ConnectionDto
    {
        public string Host { get; set; }
        public string Username { get; set; }
        public string Database { get; set; }
        public string Password { get; set; }
        public string Port { get; set; }
        public string Nickname { get; set; }
    }

    public class AddNewTableDto
    {
        public string TableName { get; set; }
        public List<ColumnDto> Columns { get; set; }
    }

    public class ColumnDto
    {
        public string ColumnName { get; set; }
        public string Value { get; set; }
    }

    public class AddNewRowDto : AddNewTableDto
    {
        public List<string> Rows { get; set; }
    }

    public class FormSelectDto
    {
        public string TableName { get; set; }
        public List<ColumnDto> Columns { get; set; }
        public bool Where { get; set; }
        public ColumnDto WhereColumn { get; set; }
        public string WhereOperator { get; set; }
        public string WhereValue { get; set; }
    }

    public class FormUpdateDto : FormSelectDto
    {
        public List<string> Values { get; set; }
    }

    public class DataViewerDto
    {
        public List<string> Columns { get; set; }
        public List<List<string>> Values { get; set; }
    }

    public class AddColumnConstraintDto
    {
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public bool Unique { get; set; }
        public bool NotNull { get; set; }
        public bool References { get; set; }
        public string ReferencesTableName { get; set; }
        public string ReferencesColumnName { get; set; }
        public bool Check { get; set; }
        public string CheckName { get; set; }
        public string CheckColumn { get; set; }
        public string CheckOperator { get; set; }
        public string CheckValue { get; set; }
    }
}