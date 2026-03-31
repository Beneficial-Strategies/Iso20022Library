// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the reason of a rejection of a standing instruction cancellation request.
    /// </summary>
    [KnownType(typeof(RejectionReason10FormatChoice.Code))]
    [KnownType(typeof(RejectionReason10FormatChoice.Proprietary))]
    [JsonDerivedType(
        typeof(RejectionReason10FormatChoice.Code),
        nameof(RejectionReason10FormatChoice.Code)
    )]
    [JsonDerivedType(
        typeof(RejectionReason10FormatChoice.Proprietary),
        nameof(RejectionReason10FormatChoice.Proprietary)
    )]
    [IsoId("_RoC54dp-Ed-ak6NoX_4Aeg_1992373934")]
    [DisplayName("Rejection Reason 10 Format Choice")]
    public abstract record RejectionReason10FormatChoice_ { }
}
