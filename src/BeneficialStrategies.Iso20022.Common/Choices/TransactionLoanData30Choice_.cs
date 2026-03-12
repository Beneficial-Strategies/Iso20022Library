// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the details of the reported transaction.
    /// </summary>
    [KnownType(typeof(TransactionLoanData30Choice.RepurchaseTrade))]
    [KnownType(typeof(TransactionLoanData30Choice.BuySellBack))]
    [KnownType(typeof(TransactionLoanData30Choice.SecuritiesLending))]
    [KnownType(typeof(TransactionLoanData30Choice.MarginLending))]
    [JsonDerivedType(typeof(TransactionLoanData30Choice.RepurchaseTrade),nameof(TransactionLoanData30Choice.RepurchaseTrade))]
    [JsonDerivedType(typeof(TransactionLoanData30Choice.BuySellBack),nameof(TransactionLoanData30Choice.BuySellBack))]
    [JsonDerivedType(typeof(TransactionLoanData30Choice.SecuritiesLending),nameof(TransactionLoanData30Choice.SecuritiesLending))]
    [JsonDerivedType(typeof(TransactionLoanData30Choice.MarginLending),nameof(TransactionLoanData30Choice.MarginLending))]
    [IsoId("_gF0WAcg4Eeu4ecZgAYuz5w")]
    [DisplayName("Transaction Loan Data 30 Choice")]
    public abstract partial record TransactionLoanData30Choice_
    {
    }
}
