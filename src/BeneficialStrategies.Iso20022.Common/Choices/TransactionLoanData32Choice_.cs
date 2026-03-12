// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the details of the reported transaction.
    /// </summary>
    [KnownType(typeof(TransactionLoanData32Choice.RepurchaseTrade))]
    [KnownType(typeof(TransactionLoanData32Choice.BuySellBack))]
    [KnownType(typeof(TransactionLoanData32Choice.SecuritiesLending))]
    [JsonDerivedType(typeof(TransactionLoanData32Choice.RepurchaseTrade),nameof(TransactionLoanData32Choice.RepurchaseTrade))]
    [JsonDerivedType(typeof(TransactionLoanData32Choice.BuySellBack),nameof(TransactionLoanData32Choice.BuySellBack))]
    [JsonDerivedType(typeof(TransactionLoanData32Choice.SecuritiesLending),nameof(TransactionLoanData32Choice.SecuritiesLending))]
    [IsoId("_J_G2Acz4EeufhKfUxzsnrQ")]
    [DisplayName("Transaction Loan Data 32 Choice")]
    public abstract partial record TransactionLoanData32Choice_
    {
    }
}
