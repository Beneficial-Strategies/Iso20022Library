// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Details of the loan used for financing the transaction.
    /// </summary>
    [KnownType(typeof(TransactionLoanData26Choice.RepurchaseTrade))]
    [KnownType(typeof(TransactionLoanData26Choice.BuySellBack))]
    [KnownType(typeof(TransactionLoanData26Choice.SecuritiesLending))]
    [KnownType(typeof(TransactionLoanData26Choice.MarginLending))]
    [JsonDerivedType(
        typeof(TransactionLoanData26Choice.RepurchaseTrade),
        nameof(TransactionLoanData26Choice.RepurchaseTrade)
    )]
    [JsonDerivedType(
        typeof(TransactionLoanData26Choice.BuySellBack),
        nameof(TransactionLoanData26Choice.BuySellBack)
    )]
    [JsonDerivedType(
        typeof(TransactionLoanData26Choice.SecuritiesLending),
        nameof(TransactionLoanData26Choice.SecuritiesLending)
    )]
    [JsonDerivedType(
        typeof(TransactionLoanData26Choice.MarginLending),
        nameof(TransactionLoanData26Choice.MarginLending)
    )]
    [IsoId("_388OoXz2EeurrJrNxcsszQ")]
    [DisplayName("Transaction Loan Data 26 Choice")]
    public abstract record TransactionLoanData26Choice_ { }
}
