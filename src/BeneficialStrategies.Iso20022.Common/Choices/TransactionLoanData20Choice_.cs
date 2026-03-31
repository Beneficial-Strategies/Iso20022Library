// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the details of the reported transaction.
    /// </summary>
    [KnownType(typeof(TransactionLoanData20Choice.RepurchaseTrade))]
    [KnownType(typeof(TransactionLoanData20Choice.BuySellBack))]
    [KnownType(typeof(TransactionLoanData20Choice.SecuritiesLending))]
    [KnownType(typeof(TransactionLoanData20Choice.MarginLending))]
    [JsonDerivedType(
        typeof(TransactionLoanData20Choice.RepurchaseTrade),
        nameof(TransactionLoanData20Choice.RepurchaseTrade)
    )]
    [JsonDerivedType(
        typeof(TransactionLoanData20Choice.BuySellBack),
        nameof(TransactionLoanData20Choice.BuySellBack)
    )]
    [JsonDerivedType(
        typeof(TransactionLoanData20Choice.SecuritiesLending),
        nameof(TransactionLoanData20Choice.SecuritiesLending)
    )]
    [JsonDerivedType(
        typeof(TransactionLoanData20Choice.MarginLending),
        nameof(TransactionLoanData20Choice.MarginLending)
    )]
    [IsoId("_lelb3bONEemDE9K-I5TT8Q")]
    [DisplayName("Transaction Loan Data 20 Choice")]
    public abstract record TransactionLoanData20Choice_ { }
}
