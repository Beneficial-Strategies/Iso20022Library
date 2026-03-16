// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Corporate Action Event Type110Choice.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType110Choice.Code))]
    [KnownType(typeof(CorporateActionEventType110Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType110Choice.Code),
        nameof(CorporateActionEventType110Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType110Choice.Proprietary),
        nameof(CorporateActionEventType110Choice.Proprietary)
    )]
    [IsoId("_mmvLwYybEe-PVZsedaAGaA")]
    [DisplayName("Corporate Action Event Type110Choice")]
    public abstract record CorporateActionEventType110Choice_ { }
}
