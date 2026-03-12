// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType7Choice.Code))]
    [KnownType(typeof(CorporateActionEventType7Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType7Choice.Code),nameof(CorporateActionEventType7Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType7Choice.Proprietary),nameof(CorporateActionEventType7Choice.Proprietary))]
    [IsoId("_VhKUofmQEeC_eLZALo-S0A")]
    [DisplayName("Corporate Action Event Type 7 Choice")]
    public abstract partial record CorporateActionEventType7Choice_
    {
    }
}
