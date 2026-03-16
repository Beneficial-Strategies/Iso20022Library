// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Corporate Action Event Type122Choice.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType122Choice.Code))]
    [KnownType(typeof(CorporateActionEventType122Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType122Choice.Code),nameof(CorporateActionEventType122Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType122Choice.Proprietary),nameof(CorporateActionEventType122Choice.Proprietary))]
    [IsoId("_l6NOBZt3Ee-wQIOX0djF2w")]
    [DisplayName("Corporate Action Event Type122Choice")]
    public abstract partial record CorporateActionEventType122Choice_
    {
    }
}
