// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the details of the reported transaction.
    /// </summary>
    [KnownType(typeof(TransactionLoanData21Choice.RepurchaseTrade))]
    [KnownType(typeof(TransactionLoanData21Choice.BuySellBack))]
    [KnownType(typeof(TransactionLoanData21Choice.SecuritiesLending))]
    [JsonDerivedType(
        typeof(TransactionLoanData21Choice.RepurchaseTrade),
        nameof(TransactionLoanData21Choice.RepurchaseTrade)
    )]
    [JsonDerivedType(
        typeof(TransactionLoanData21Choice.BuySellBack),
        nameof(TransactionLoanData21Choice.BuySellBack)
    )]
    [JsonDerivedType(
        typeof(TransactionLoanData21Choice.SecuritiesLending),
        nameof(TransactionLoanData21Choice.SecuritiesLending)
    )]
    [IsoId("_4AyNrf_qEemm3skPVSMJQg")]
    [DisplayName("Transaction Loan Data 21 Choice")]
    public abstract record TransactionLoanData21Choice_ { }
}
