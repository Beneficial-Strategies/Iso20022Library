// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a type of investment plan.
    /// </summary>
    [KnownType(typeof(InvestmentFundPlanType1Choice.Code))]
    [KnownType(typeof(InvestmentFundPlanType1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(InvestmentFundPlanType1Choice.Code),
        nameof(InvestmentFundPlanType1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(InvestmentFundPlanType1Choice.Proprietary),
        nameof(InvestmentFundPlanType1Choice.Proprietary)
    )]
    [IsoId("_UxNjoF9CEeicg40_9gK9vQ")]
    [DisplayName("Investment Fund Plan Type 1 Choice")]
    public abstract record InvestmentFundPlanType1Choice_ { }
}
