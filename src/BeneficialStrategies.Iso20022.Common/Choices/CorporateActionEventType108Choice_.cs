// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Corporate Action Event Type108Choice.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType108Choice.Code))]
    [KnownType(typeof(CorporateActionEventType108Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType108Choice.Code),
        nameof(CorporateActionEventType108Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType108Choice.Proprietary),
        nameof(CorporateActionEventType108Choice.Proprietary)
    )]
    [IsoId("_rlPLwYCeEe-3UrLQHGsjgQ")]
    [DisplayName("Corporate Action Event Type108Choice")]
    public abstract record CorporateActionEventType108Choice_ { }
}
