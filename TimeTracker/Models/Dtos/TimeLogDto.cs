using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeTracker.Models.Dtos
{
    public class TimeLogDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public System.DateTime LogDate { get; set; }
        public Nullable<System.TimeSpan> TimeIn1 { get; set; }
        public Nullable<System.TimeSpan> TimeOut1 { get; set; }
        public Nullable<System.TimeSpan> TimeIn2 { get; set; }
        public Nullable<System.TimeSpan> TimeOut2 { get; set; }
        public Nullable<System.TimeSpan> TimeIn3 { get; set; }
        public Nullable<System.TimeSpan> TimeOut3 { get; set; }
    }
}