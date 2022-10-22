using System;

namespace Debugger
{
    public class DataRow
    {
        public bool DataEnabled { get; set; }

        public string DataTitle { get; set; }

        public object DataValue { get; set; }

        public Type DataType { get; set; }
    }
}