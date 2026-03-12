// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Suspended status reason.
    /// </summary>
    [KnownType(typeof(SuspendedStatusReasonChoice.Reason))]
    [KnownType(typeof(SuspendedStatusReasonChoice.Proprietary))]
    [KnownType(typeof(SuspendedStatusReasonChoice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(SuspendedStatusReasonChoice.Reason),nameof(SuspendedStatusReasonChoice.Reason))]
    [JsonDerivedType(typeof(SuspendedStatusReasonChoice.Proprietary),nameof(SuspendedStatusReasonChoice.Proprietary))]
    [JsonDerivedType(typeof(SuspendedStatusReasonChoice.NoSpecifiedReason),nameof(SuspendedStatusReasonChoice.NoSpecifiedReason))]
    [IsoId("_RfGZSdp-Ed-ak6NoX_4Aeg_1537280901")]
    [DisplayName("Suspended Status Reason Choice")]
    public abstract partial record SuspendedStatusReasonChoice_
    {
    }
}
