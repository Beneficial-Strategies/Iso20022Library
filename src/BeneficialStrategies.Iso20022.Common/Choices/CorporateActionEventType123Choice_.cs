// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Corporate Action Event Type123Choice.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType123Choice.Code))]
    [KnownType(typeof(CorporateActionEventType123Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType123Choice.Code),nameof(CorporateActionEventType123Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType123Choice.Proprietary),nameof(CorporateActionEventType123Choice.Proprietary))]
    [IsoId("_m45EY5t3Ee-wQIOX0djF2w")]
    [DisplayName("Corporate Action Event Type123Choice")]
    public abstract partial record CorporateActionEventType123Choice_
    {
    }
}
