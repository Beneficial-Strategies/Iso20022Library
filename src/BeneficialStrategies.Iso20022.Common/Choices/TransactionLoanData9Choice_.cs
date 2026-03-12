// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Details of the loan used for financing the transaction.
    /// </summary>
    [KnownType(typeof(TransactionLoanData9Choice.RepurchaseTrade))]
    [KnownType(typeof(TransactionLoanData9Choice.BuySellBack))]
    [KnownType(typeof(TransactionLoanData9Choice.SecuritiesLending))]
    [KnownType(typeof(TransactionLoanData9Choice.MarginLending))]
    [JsonDerivedType(typeof(TransactionLoanData9Choice.RepurchaseTrade),nameof(TransactionLoanData9Choice.RepurchaseTrade))]
    [JsonDerivedType(typeof(TransactionLoanData9Choice.BuySellBack),nameof(TransactionLoanData9Choice.BuySellBack))]
    [JsonDerivedType(typeof(TransactionLoanData9Choice.SecuritiesLending),nameof(TransactionLoanData9Choice.SecuritiesLending))]
    [JsonDerivedType(typeof(TransactionLoanData9Choice.MarginLending),nameof(TransactionLoanData9Choice.MarginLending))]
    [IsoId("_Hg0sIKoMEemdLtwzt4CWxg")]
    [DisplayName("Transaction Loan Data 9 Choice")]
    public abstract partial record TransactionLoanData9Choice_
    {
    }
}
