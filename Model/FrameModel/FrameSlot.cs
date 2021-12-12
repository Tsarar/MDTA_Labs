using System;

namespace MDTA_Labs.Model.FrameModel
{
    public class FrameSlot
    {
        public string SlotName { get; set; }
        public string SlotValue { get; set; }
        public Func<string, string> OnAdd { get; set; }
        public Func<string, string> OnEdit { get; set; }
        public Func<string, string> OnDelete { get; set; }
    }
}
