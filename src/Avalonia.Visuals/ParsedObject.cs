using System;
using System.Collections.Generic;
using System.Text;

namespace Avalonia
{
    public enum ParsedEventType
    {
        Unknown,
        IsMeasureValid_set,
        IsArrangeValid_set,
        Bounds_set,
        DesiredSize_set,
        InvalidateMeasure,
        InvalidateArrange,
        ChildDesiredSizeChanged,
        Measuring,
        Arranging
    }

    public class ParsedObject
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public DateTime TimeStamp { get; set; }
        public ParsedEventType EventType { get; set; }
        public string Tag { get; set; }
        public Dictionary<string, string> Attributes { get; set; }
    }
}
