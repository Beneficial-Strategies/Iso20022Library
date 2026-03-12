// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the reason of a rejection of the interest request.
    /// </summary>
    [KnownType(typeof(RejectionReason21FormatChoice.Code))]
    [KnownType(typeof(RejectionReason21FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason21FormatChoice.Code),nameof(RejectionReason21FormatChoice.Code))]
    [JsonDerivedType(typeof(RejectionReason21FormatChoice.Proprietary),nameof(RejectionReason21FormatChoice.Proprietary))]
    [IsoId("_Qki1gdp-Ed-ak6NoX_4Aeg_172364056")]
    [DisplayName("Rejection Reason 21 Format Choice")]
    public abstract partial record RejectionReason21FormatChoice_
    {
    }
}
