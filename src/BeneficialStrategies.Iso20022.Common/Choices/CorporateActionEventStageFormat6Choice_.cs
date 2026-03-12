// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the event stage type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventStageFormat6Choice.Code))]
    [KnownType(typeof(CorporateActionEventStageFormat6Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventStageFormat6Choice.Code),nameof(CorporateActionEventStageFormat6Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventStageFormat6Choice.Proprietary),nameof(CorporateActionEventStageFormat6Choice.Proprietary))]
    [IsoId("_DcfjGiUoEeO8eOSw0QN9mA")]
    [DisplayName("Corporate Action Event Stage Format 6 Choice")]
    public abstract partial record CorporateActionEventStageFormat6Choice_
    {
    }
}
