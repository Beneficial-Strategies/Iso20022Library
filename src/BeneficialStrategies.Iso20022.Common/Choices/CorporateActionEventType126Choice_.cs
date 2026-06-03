// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a corporate event type or an extended corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType126Choice.PlainCorporateEventType))]
    [KnownType(typeof(CorporateActionEventType126Choice.ExtendedCorporateEventType))]
    [JsonDerivedType(typeof(CorporateActionEventType126Choice.PlainCorporateEventType), nameof(CorporateActionEventType126Choice.PlainCorporateEventType))]
    [JsonDerivedType(typeof(CorporateActionEventType126Choice.ExtendedCorporateEventType), nameof(CorporateActionEventType126Choice.ExtendedCorporateEventType))]
    [IsoId("_tqMIQaNZEfC9id413JK-Ig")]
    [DisplayName("Corporate Action Event Type 126 Choice")]
    public abstract record CorporateActionEventType126Choice_ { }
}
