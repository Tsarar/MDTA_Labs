using System.Collections.Generic;

namespace MDTA_Labs.Model.FrameModel
{
    public class Frame
    {
        public string FrameName { get; set; }
        public Frame BaseFrame { get; set; }
        public List<FrameSlot> Slots { get; set; }
    }
}
