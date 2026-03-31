// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType14Choice.Code))]
    [KnownType(typeof(CorporateActionEventType14Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType14Choice.Code),
        nameof(CorporateActionEventType14Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType14Choice.Proprietary),
        nameof(CorporateActionEventType14Choice.Proprietary)
    )]
    [IsoId("_0xw2AREwEeKp2ZN13DI_pA")]
    [DisplayName("Corporate Action Event Type 14 Choice")]
    public abstract record CorporateActionEventType14Choice_ { }
}
