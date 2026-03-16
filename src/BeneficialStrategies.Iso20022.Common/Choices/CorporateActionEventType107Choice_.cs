// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Corporate Action Event Type107Choice.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType107Choice.Code))]
    [KnownType(typeof(CorporateActionEventType107Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType107Choice.Code),nameof(CorporateActionEventType107Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType107Choice.Proprietary),nameof(CorporateActionEventType107Choice.Proprietary))]
    [IsoId("_hfhVQYCdEe-3UrLQHGsjgQ")]
    [DisplayName("Corporate Action Event Type107Choice")]
    public abstract partial record CorporateActionEventType107Choice_
    {
    }
}
