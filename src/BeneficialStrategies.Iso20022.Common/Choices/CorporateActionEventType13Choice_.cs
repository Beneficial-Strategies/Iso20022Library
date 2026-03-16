// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType13Choice.Code))]
    [KnownType(typeof(CorporateActionEventType13Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType13Choice.Code),
        nameof(CorporateActionEventType13Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType13Choice.Proprietary),
        nameof(CorporateActionEventType13Choice.Proprietary)
    )]
    [IsoId("_07ByCREuEeKp2ZN13DI_pA")]
    [DisplayName("Corporate Action Event Type 13 Choice")]
    public abstract record CorporateActionEventType13Choice_ { }
}
