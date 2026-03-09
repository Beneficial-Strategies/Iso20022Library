// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the details of the reported transaction.
    /// </summary>
    [KnownType(typeof(TransactionLoanData17Choice.RepurchaseTrade))]
    [KnownType(typeof(TransactionLoanData17Choice.BuySellBack))]
    [KnownType(typeof(TransactionLoanData17Choice.SecuritiesLending))]
    [KnownType(typeof(TransactionLoanData17Choice.MarginLending))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionLoanData17Choice.RepurchaseTrade),nameof(TransactionLoanData17Choice.RepurchaseTrade))]
    [JsonDerivedType(typeof(TransactionLoanData17Choice.BuySellBack),nameof(TransactionLoanData17Choice.BuySellBack))]
    [JsonDerivedType(typeof(TransactionLoanData17Choice.SecuritiesLending),nameof(TransactionLoanData17Choice.SecuritiesLending))]
    [JsonDerivedType(typeof(TransactionLoanData17Choice.MarginLending),nameof(TransactionLoanData17Choice.MarginLending))]
    #endif
    [IsoId("_1xq-Pa1KEemojPqsRBB5Lg")]
    [DisplayName("Transaction Loan Data 17 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionLoanData17Choice_
    #else
    public abstract partial class TransactionLoanData17Choice_
    #endif
    {
    }
}
