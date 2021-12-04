using System;

namespace MDTA_Labs.Model.Variant_8
{
    [Flags]
    public enum CommunicationProperties
    {
        None = 0,
        CanBeRead = 1,
        NeedsSpecialPreparation = 1 << 1,
        CanBeSuppressed = 1 << 2,
        CanSendSound = 1 << 3
    }
}
