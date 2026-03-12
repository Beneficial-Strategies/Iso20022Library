// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the status of the CA option.
    /// </summary>
    [KnownType(typeof(CorporateActionEventStatus2FormatChoice.Code))]
    [KnownType(typeof(CorporateActionEventStatus2FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventStatus2FormatChoice.Code),nameof(CorporateActionEventStatus2FormatChoice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventStatus2FormatChoice.Proprietary),nameof(CorporateActionEventStatus2FormatChoice.Proprietary))]
    [IsoId("_RmQKIdp-Ed-ak6NoX_4Aeg_-108007853")]
    [DisplayName("Corporate Action Event Status 2 Format Choice")]
    public abstract partial record CorporateActionEventStatus2FormatChoice_
    {
    }
}
