// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify a type of change.
    /// </summary>
    [KnownType(typeof(CorporateActionChangeTypeFormat6Choice.Code))]
    [KnownType(typeof(CorporateActionChangeTypeFormat6Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionChangeTypeFormat6Choice.Code),
        nameof(CorporateActionChangeTypeFormat6Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionChangeTypeFormat6Choice.Proprietary),
        nameof(CorporateActionChangeTypeFormat6Choice.Proprietary)
    )]
    [IsoId("_4pLWIUGTEeWqy4niLuXETA")]
    [DisplayName("Corporate Action Change Type Format 6 Choice")]
    public abstract record CorporateActionChangeTypeFormat6Choice_ { }
}
