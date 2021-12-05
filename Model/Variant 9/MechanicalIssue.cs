using System;

namespace MDTA_Labs.Model.Variant_9
{
    [Flags]
    public enum MechanicalIssue
    {
        None = 0,
        option1 = 1,
        option2 = 1 << 1,
        option3 = 1 << 2,
        option4 = 1 << 3,
        option5 = 1 << 4,
        option6 = 1 << 5
    }
}
