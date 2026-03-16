// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for an investment need.
    /// </summary>
    [KnownType(typeof(InvestmentNeed1Choice.Code))]
    [KnownType(typeof(InvestmentNeed1Choice.Proprietary))]
    [JsonDerivedType(typeof(InvestmentNeed1Choice.Code), nameof(InvestmentNeed1Choice.Code))]
    [JsonDerivedType(
        typeof(InvestmentNeed1Choice.Proprietary),
        nameof(InvestmentNeed1Choice.Proprietary)
    )]
    [IsoId("_FFLMcDcdEeidBoT_PugKiA")]
    [DisplayName("Investment Need 1 Choice")]
    public abstract record InvestmentNeed1Choice_ { }
}
