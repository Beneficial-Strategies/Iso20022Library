// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Corporate Action Event Type117Choice.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType117Choice.Code))]
    [KnownType(typeof(CorporateActionEventType117Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType117Choice.Code),
        nameof(CorporateActionEventType117Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType117Choice.Proprietary),
        nameof(CorporateActionEventType117Choice.Proprietary)
    )]
    [IsoId("_j2C9_5t3Ee-wQIOX0djF2w")]
    [DisplayName("Corporate Action Event Type117Choice")]
    public abstract record CorporateActionEventType117Choice_ { }
}
