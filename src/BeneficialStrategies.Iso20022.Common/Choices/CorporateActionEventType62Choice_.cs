// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType62Choice.Code))]
    [KnownType(typeof(CorporateActionEventType62Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType62Choice.Code),
        nameof(CorporateActionEventType62Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType62Choice.Proprietary),
        nameof(CorporateActionEventType62Choice.Proprietary)
    )]
    [IsoId("_9EuinZwsEeazcsnODTksnQ")]
    [DisplayName("Corporate Action Event Type 62 Choice")]
    public abstract record CorporateActionEventType62Choice_ { }
}
