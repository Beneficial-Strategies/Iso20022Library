// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Corporate Action Event Type113Choice.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType113Choice.Code))]
    [KnownType(typeof(CorporateActionEventType113Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType113Choice.Code),
        nameof(CorporateActionEventType113Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType113Choice.Proprietary),
        nameof(CorporateActionEventType113Choice.Proprietary)
    )]
    [IsoId("_jKs6eZt3Ee-wQIOX0djF2w")]
    [DisplayName("Corporate Action Event Type113Choice")]
    public abstract record CorporateActionEventType113Choice_ { }
}
