// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the reason of a rejection cancellation request.
    /// </summary>
    [KnownType(typeof(RejectionReason7FormatChoice.Code))]
    [KnownType(typeof(RejectionReason7FormatChoice.Proprietary))]
    [JsonDerivedType(
        typeof(RejectionReason7FormatChoice.Code),
        nameof(RejectionReason7FormatChoice.Code)
    )]
    [JsonDerivedType(
        typeof(RejectionReason7FormatChoice.Proprietary),
        nameof(RejectionReason7FormatChoice.Proprietary)
    )]
    [IsoId("_Rofl2Np-Ed-ak6NoX_4Aeg_-1503733328")]
    [DisplayName("Rejection Reason 7 Format Choice")]
    public abstract record RejectionReason7FormatChoice_ { }
}
