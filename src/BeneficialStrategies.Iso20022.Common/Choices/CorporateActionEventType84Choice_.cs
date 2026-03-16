// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType84Choice.Code))]
    [KnownType(typeof(CorporateActionEventType84Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType84Choice.Code),
        nameof(CorporateActionEventType84Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType84Choice.Proprietary),
        nameof(CorporateActionEventType84Choice.Proprietary)
    )]
    [IsoId("_cgUAteXmEemEj48jhmlA0Q")]
    [DisplayName("Corporate Action Event Type 84 Choice")]
    public abstract record CorporateActionEventType84Choice_ { }
}
