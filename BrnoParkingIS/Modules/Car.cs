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
        [UIParams(DateTimeMode = DatePickerMode.Date, LabelDescription = "Date")]
        public DateTime Date { get; set; }
        [UIParams(DateTimeMode = DatePickerMode.Time, LabelDescription = "Time")]
        public DateTime Time { get; set; }
    }
}
