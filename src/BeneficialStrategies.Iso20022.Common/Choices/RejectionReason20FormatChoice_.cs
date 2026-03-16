// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the reason of a rejection of the standing instruction request.
    /// </summary>
    [KnownType(typeof(RejectionReason20FormatChoice.Code))]
    [KnownType(typeof(RejectionReason20FormatChoice.Proprietary))]
    [JsonDerivedType(
        typeof(RejectionReason20FormatChoice.Code),
        nameof(RejectionReason20FormatChoice.Code)
    )]
    [JsonDerivedType(
        typeof(RejectionReason20FormatChoice.Proprietary),
        nameof(RejectionReason20FormatChoice.Proprietary)
    )]
    [IsoId("_Rofl0tp-Ed-ak6NoX_4Aeg_362684216")]
    [DisplayName("Rejection Reason 20 Format Choice")]
    public abstract record RejectionReason20FormatChoice_ { }
}
