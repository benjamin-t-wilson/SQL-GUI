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
        public string ValueType { get; set; }
    }
}