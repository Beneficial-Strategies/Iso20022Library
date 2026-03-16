// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Corporate Action Event Type111Choice.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType111Choice.Code))]
    [KnownType(typeof(CorporateActionEventType111Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType111Choice.Code),nameof(CorporateActionEventType111Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType111Choice.Proprietary),nameof(CorporateActionEventType111Choice.Proprietary))]
    [IsoId("_qXMeE4-uEe-KeYPogYaQJw")]
    [DisplayName("Corporate Action Event Type111Choice")]
    public abstract partial record CorporateActionEventType111Choice_
    {
    }
}
