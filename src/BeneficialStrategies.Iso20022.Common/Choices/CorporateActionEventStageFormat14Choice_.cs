// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the event stage type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventStageFormat14Choice.Code))]
    [KnownType(typeof(CorporateActionEventStageFormat14Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventStageFormat14Choice.Code),
        nameof(CorporateActionEventStageFormat14Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventStageFormat14Choice.Proprietary),
        nameof(CorporateActionEventStageFormat14Choice.Proprietary)
    )]
    [IsoId("_yPzIUUGKEeWqy4niLuXETA")]
    [DisplayName("Corporate Action Event Stage Format 14 Choice")]
    public abstract record CorporateActionEventStageFormat14Choice_ { }
}
