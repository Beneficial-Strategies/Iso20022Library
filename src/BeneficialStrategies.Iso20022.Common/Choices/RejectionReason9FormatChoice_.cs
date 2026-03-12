// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the reason of a rejection of an election cancellation request.
    /// </summary>
    [KnownType(typeof(RejectionReason9FormatChoice.Code))]
    [KnownType(typeof(RejectionReason9FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason9FormatChoice.Code),nameof(RejectionReason9FormatChoice.Code))]
    [JsonDerivedType(typeof(RejectionReason9FormatChoice.Proprietary),nameof(RejectionReason9FormatChoice.Proprietary))]
    [IsoId("_Roovxdp-Ed-ak6NoX_4Aeg_-1408419853")]
    [DisplayName("Rejection Reason 9 Format Choice")]
    public abstract partial record RejectionReason9FormatChoice_
    {
    }
}
