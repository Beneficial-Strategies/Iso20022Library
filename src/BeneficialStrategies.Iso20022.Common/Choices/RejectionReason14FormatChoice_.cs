// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the reason of a rejection of a movement cancellation request.
    /// </summary>
    [KnownType(typeof(RejectionReason14FormatChoice.Code))]
    [KnownType(typeof(RejectionReason14FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason14FormatChoice.Code),nameof(RejectionReason14FormatChoice.Code))]
    [JsonDerivedType(typeof(RejectionReason14FormatChoice.Proprietary),nameof(RejectionReason14FormatChoice.Proprietary))]
    [IsoId("_RoMq5dp-Ed-ak6NoX_4Aeg_-1393087527")]
    [DisplayName("Rejection Reason 14 Format Choice")]
    public abstract partial record RejectionReason14FormatChoice_
    {
    }
}
