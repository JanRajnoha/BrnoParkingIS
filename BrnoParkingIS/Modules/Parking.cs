using ISUF.Base.Attributes;
using ISUF.Base.Enum;
using ISUF.Base.Template;
using System;
using System.Collections.Generic;

namespace BrnoParkingIS.Modules
{
    public class Parking : BaseItem
    {
        [UIIgnore]
        public new string Description { get; set; }

        [LinkedTable(LinkedTableType = typeof(Car), LinkedTableRelation = LinkedTableRelation.Many)]
        [UIParams(LabelDescription = "Cars selector", UIOrder = 3)]
        public List<int> Cars { get; set; }

        public override string ToString()
        {
            return Name + "; Cars count: " + Cars.Count;
        }
    }
}
