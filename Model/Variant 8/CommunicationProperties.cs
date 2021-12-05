using System;

namespace MDTA_Labs.Model.Variant_8
{
    [Flags]
    public enum CommunicationProperties
    {
        None = 0,
        CantBeRead = 1,
        DoNotNeedSpecialPreparation = 1 << 1,
        CantBeSuppressed = 1 << 2,
        CanSendSound = 1 << 3
    }
}
