using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTrack.WinForm.Design.Model
{
    internal class Activity
    {
        public int ActivityId { get; set;} = 0;
        public int TeskId { get; set;}
        public string ActivityName { get; set;}
        public string ActivityDescription { get; set;}
        public DateTime Start { get; set;} = DateTime.MinValue;
        public DateTime End { get; set;} = DateTime.MaxValue;
        public TimeSpan Duration { get => End - Start;}
        public decimal DurationHours { get => Duration.Hours;}



    }
}
