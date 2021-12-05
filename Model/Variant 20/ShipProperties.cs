using System;

namespace MDTA_Labs.Model.Variant_20
{
    [Flags]
    public enum ShipProperties
    {
        None = 0,
        option1 = 1,
        option2 = 1 << 1,
        option3 = 1 << 2,
        option4 = 1 << 3,
    }
}
