using ISUF.Base.Attributes;
using ISUF.Base.Enum;
using ISUF.Base.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrnoParkingIS.Modules
{
    public class Car : BaseItem
    {
        [UIParams(DateTimeMode = DatePickerMode.Date, LabelDescription = "Date", UIOrder = 3)]
        public DateTime Date { get; set; } = DateTime.Today;

        [UIParams(DateTimeMode = DatePickerMode.Time, LabelDescription = "Time", UIOrder = 4)]
        public DateTime Time { get; set; } = DateTime.Now;

        [LinkedTable(LinkedTableType = typeof(Parkings))]
        [UIParams(LabelDescription = "Parking selector", UIOrder = 4)]
        public int Parking { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
