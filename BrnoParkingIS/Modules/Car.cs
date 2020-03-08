using ISUF.Base.Attributes;
using ISUF.Base.Enum;
using ISUF.Base.Template;
using System;

namespace BrnoParkingIS.Modules
{
    public class Car : BaseItem
    {
        [UIIgnore]
        public new string Description { get; set; }
        [UIIgnore]
        public new string Name { get; set; }
        [UIIgnore]
        public new bool Secured { get; set; }

        [UIParams(DateTimeMode = DatePickerMode.Date, LabelDescription = "Date", UIOrder = 3)]
        public DateTime Date { get; set; } = DateTime.Today;

        [UIParams(DateTimeMode = DatePickerMode.Time, LabelDescription = "Time", UIOrder = 4)]
        public DateTime Time { get; set; } = DateTime.Now;

        [UIParams(UIOrder = 5)]
        public string Manufacturer { get; set; }

        [UIParams(UIOrder = 6)]
        public string SPZ { get; set; }

        [LinkedTable(LinkedTableType = typeof(Parking))]
        [UIParams(LabelDescription = "Parking selector", UIOrder = 7)]
        public int Parking { get; set; } = -1;

        public override string ToString()
        {
            return Manufacturer + " - " + SPZ;
        }
    }
}
