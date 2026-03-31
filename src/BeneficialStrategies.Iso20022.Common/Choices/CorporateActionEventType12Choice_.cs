// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType12Choice.Code))]
    [KnownType(typeof(CorporateActionEventType12Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType12Choice.Code),
        nameof(CorporateActionEventType12Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType12Choice.Proprietary),
        nameof(CorporateActionEventType12Choice.Proprietary)
    )]
    [IsoId("_p5kqEQ4zEeKVsZQr6J31Tg")]
    [DisplayName("Corporate Action Event Type 12 Choice")]
    public abstract record CorporateActionEventType12Choice_ { }
}
