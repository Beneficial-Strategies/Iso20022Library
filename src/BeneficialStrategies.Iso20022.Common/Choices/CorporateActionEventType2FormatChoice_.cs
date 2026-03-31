// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType2FormatChoice.Code))]
    [KnownType(typeof(CorporateActionEventType2FormatChoice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType2FormatChoice.Code),
        nameof(CorporateActionEventType2FormatChoice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType2FormatChoice.Proprietary),
        nameof(CorporateActionEventType2FormatChoice.Proprietary)
    )]
    [IsoId("_RjRuo9p-Ed-ak6NoX_4Aeg_-1524831811")]
    [DisplayName("Corporate Action Event Type 2 Format Choice")]
    public abstract record CorporateActionEventType2FormatChoice_ { }
}
