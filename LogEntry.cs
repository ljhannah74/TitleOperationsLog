namespace TitleOperationsLog
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LogEntry
    {
        public int LogEntryId { get; set; }

        public string OrderNo { get; set; }

        public DateTime? TimeStamp { get; set; }

        public int? LogClient_ClientID { get; set; }

        public int? LogFunction_JobFunctionId { get; set; }

        public int? LogProduct_ProductID { get; set; }

        public virtual Client Client { get; set; }

        public virtual JobFunction JobFunction { get; set; }

        public virtual Product Product { get; set; }
    }
}
