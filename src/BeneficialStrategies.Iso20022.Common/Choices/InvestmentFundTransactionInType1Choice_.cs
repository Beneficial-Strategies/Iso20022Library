// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the transaction-in type.
    /// </summary>
    [KnownType(typeof(InvestmentFundTransactionInType1Choice.Code))]
    [KnownType(typeof(InvestmentFundTransactionInType1Choice.Proprietary))]
    [JsonDerivedType(typeof(InvestmentFundTransactionInType1Choice.Code),nameof(InvestmentFundTransactionInType1Choice.Code))]
    [JsonDerivedType(typeof(InvestmentFundTransactionInType1Choice.Proprietary),nameof(InvestmentFundTransactionInType1Choice.Proprietary))]
    [IsoId("_SMsrUQaxEeS3lpTattq7hg")]
    [DisplayName("Investment Fund Transaction In Type 1 Choice")]
    public abstract partial record InvestmentFundTransactionInType1Choice_
    {
    }
}
