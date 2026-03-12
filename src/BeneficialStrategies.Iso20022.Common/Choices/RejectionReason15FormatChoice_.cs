// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the reason of a rejection of an information advice.
    /// </summary>
    [KnownType(typeof(RejectionReason15FormatChoice.Code))]
    [KnownType(typeof(RejectionReason15FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason15FormatChoice.Code),nameof(RejectionReason15FormatChoice.Code))]
    [JsonDerivedType(typeof(RejectionReason15FormatChoice.Proprietary),nameof(RejectionReason15FormatChoice.Proprietary))]
    [IsoId("_RoV00Np-Ed-ak6NoX_4Aeg_-1737450655")]
    [DisplayName("Rejection Reason 15 Format Choice")]
    public abstract partial record RejectionReason15FormatChoice_
    {
    }
}
