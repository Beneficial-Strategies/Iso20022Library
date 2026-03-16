// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Corporate Action Event Type109Choice.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType109Choice.Code))]
    [KnownType(typeof(CorporateActionEventType109Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType109Choice.Code),nameof(CorporateActionEventType109Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType109Choice.Proprietary),nameof(CorporateActionEventType109Choice.Proprietary))]
    [IsoId("_N2KeTYCfEe-3UrLQHGsjgQ")]
    [DisplayName("Corporate Action Event Type109Choice")]
    public abstract partial record CorporateActionEventType109Choice_
    {
    }
}
