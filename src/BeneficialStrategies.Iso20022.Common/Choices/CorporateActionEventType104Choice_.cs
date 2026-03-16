// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Corporate Action Event Type104Choice.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType104Choice.Code))]
    [KnownType(typeof(CorporateActionEventType104Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType104Choice.Code),nameof(CorporateActionEventType104Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType104Choice.Proprietary),nameof(CorporateActionEventType104Choice.Proprietary))]
    [IsoId("_ZWH7YT3lEe-thIfLZ94a1w")]
    [DisplayName("Corporate Action Event Type104Choice")]
    public abstract partial record CorporateActionEventType104Choice_
    {
    }
}
