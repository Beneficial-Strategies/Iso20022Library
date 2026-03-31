// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the transaction-out type.
    /// </summary>
    [KnownType(typeof(InvestmentFundTransactionOutType1Choice.Code))]
    [KnownType(typeof(InvestmentFundTransactionOutType1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(InvestmentFundTransactionOutType1Choice.Code),
        nameof(InvestmentFundTransactionOutType1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(InvestmentFundTransactionOutType1Choice.Proprietary),
        nameof(InvestmentFundTransactionOutType1Choice.Proprietary)
    )]
    [IsoId("_SxyAcRMJEeSopak1K45eVQ")]
    [DisplayName("Investment Fund Transaction Out Type 1 Choice")]
    public abstract record InvestmentFundTransactionOutType1Choice_ { }
}
