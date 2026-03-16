// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the details of the reported transaction.
    /// </summary>
    [KnownType(typeof(TransactionLoanData17Choice.RepurchaseTrade))]
    [KnownType(typeof(TransactionLoanData17Choice.BuySellBack))]
    [KnownType(typeof(TransactionLoanData17Choice.SecuritiesLending))]
    [KnownType(typeof(TransactionLoanData17Choice.MarginLending))]
    [JsonDerivedType(
        typeof(TransactionLoanData17Choice.RepurchaseTrade),
        nameof(TransactionLoanData17Choice.RepurchaseTrade)
    )]
    [JsonDerivedType(
        typeof(TransactionLoanData17Choice.BuySellBack),
        nameof(TransactionLoanData17Choice.BuySellBack)
    )]
    [JsonDerivedType(
        typeof(TransactionLoanData17Choice.SecuritiesLending),
        nameof(TransactionLoanData17Choice.SecuritiesLending)
    )]
    [JsonDerivedType(
        typeof(TransactionLoanData17Choice.MarginLending),
        nameof(TransactionLoanData17Choice.MarginLending)
    )]
    [IsoId("_1xq-Pa1KEemojPqsRBB5Lg")]
    [DisplayName("Transaction Loan Data 17 Choice")]
    public abstract record TransactionLoanData17Choice_ { }
}
