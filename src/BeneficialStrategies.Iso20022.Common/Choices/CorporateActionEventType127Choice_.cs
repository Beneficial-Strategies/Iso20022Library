// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType127Choice.Code))]
    [KnownType(typeof(CorporateActionEventType127Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType127Choice.Code), nameof(CorporateActionEventType127Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType127Choice.Proprietary), nameof(CorporateActionEventType127Choice.Proprietary))]
    [IsoId("_zx5tYaNZEfC9id413JK-Ig")]
    [DisplayName("Corporate Action Event Type 127 Choice")]
    public abstract record CorporateActionEventType127Choice_ { }
}
