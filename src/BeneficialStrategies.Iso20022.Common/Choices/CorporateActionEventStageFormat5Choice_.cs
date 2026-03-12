// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the event stage type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventStageFormat5Choice.Code))]
    [KnownType(typeof(CorporateActionEventStageFormat5Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventStageFormat5Choice.Code),nameof(CorporateActionEventStageFormat5Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventStageFormat5Choice.Proprietary),nameof(CorporateActionEventStageFormat5Choice.Proprietary))]
    [IsoId("_oI9aESUfEeO8eOSw0QN9mA")]
    [DisplayName("Corporate Action Event Stage Format 5 Choice")]
    public abstract partial record CorporateActionEventStageFormat5Choice_
    {
    }
}
