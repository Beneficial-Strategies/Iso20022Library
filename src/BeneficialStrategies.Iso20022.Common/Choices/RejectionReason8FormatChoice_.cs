// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the reason of a rejection of an election amendment request.
    /// </summary>
    [KnownType(typeof(RejectionReason8FormatChoice.Code))]
    [KnownType(typeof(RejectionReason8FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason8FormatChoice.Code),nameof(RejectionReason8FormatChoice.Code))]
    [JsonDerivedType(typeof(RejectionReason8FormatChoice.Proprietary),nameof(RejectionReason8FormatChoice.Proprietary))]
    [IsoId("_Roovwtp-Ed-ak6NoX_4Aeg_520363786")]
    [DisplayName("Rejection Reason 8 Format Choice")]
    public abstract partial record RejectionReason8FormatChoice_
    {
    }
}
