using System;

namespace ExportHistoryReport.BusinessLayer
{
    public class ExportData
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime ExecutionDateTime { get; set; }
        public string UserName { get; set; }
        public string LocationName { get; set; }
    }
}
