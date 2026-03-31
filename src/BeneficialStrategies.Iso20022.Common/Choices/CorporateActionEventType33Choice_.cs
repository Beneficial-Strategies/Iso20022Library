// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType33Choice.Code))]
    [KnownType(typeof(CorporateActionEventType33Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType33Choice.Code),
        nameof(CorporateActionEventType33Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType33Choice.Proprietary),
        nameof(CorporateActionEventType33Choice.Proprietary)
    )]
    [IsoId("_X8tB4TndEeWLJsP1cO-amg")]
    [DisplayName("Corporate Action Event Type 33 Choice")]
    public abstract record CorporateActionEventType33Choice_ { }
}
