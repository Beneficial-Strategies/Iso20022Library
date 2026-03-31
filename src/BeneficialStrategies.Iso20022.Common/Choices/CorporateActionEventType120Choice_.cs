// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Corporate Action Event Type120Choice.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType120Choice.Code))]
    [KnownType(typeof(CorporateActionEventType120Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType120Choice.Code),
        nameof(CorporateActionEventType120Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType120Choice.Proprietary),
        nameof(CorporateActionEventType120Choice.Proprietary)
    )]
    [IsoId("_kv0fYZt3Ee-wQIOX0djF2w")]
    [DisplayName("Corporate Action Event Type120Choice")]
    public abstract record CorporateActionEventType120Choice_ { }
}
