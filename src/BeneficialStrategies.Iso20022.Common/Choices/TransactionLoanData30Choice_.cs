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
    [KnownType(typeof(TransactionLoanData30Choice.RepurchaseTrade))]
    [KnownType(typeof(TransactionLoanData30Choice.BuySellBack))]
    [KnownType(typeof(TransactionLoanData30Choice.SecuritiesLending))]
    [KnownType(typeof(TransactionLoanData30Choice.MarginLending))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionLoanData30Choice.RepurchaseTrade),nameof(TransactionLoanData30Choice.RepurchaseTrade))]
    [JsonDerivedType(typeof(TransactionLoanData30Choice.BuySellBack),nameof(TransactionLoanData30Choice.BuySellBack))]
    [JsonDerivedType(typeof(TransactionLoanData30Choice.SecuritiesLending),nameof(TransactionLoanData30Choice.SecuritiesLending))]
    [JsonDerivedType(typeof(TransactionLoanData30Choice.MarginLending),nameof(TransactionLoanData30Choice.MarginLending))]
    #endif
    [IsoId("_gF0WAcg4Eeu4ecZgAYuz5w")]
    [DisplayName("Transaction Loan Data 30 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionLoanData30Choice_
    #else
    public abstract partial class TransactionLoanData30Choice_
    #endif
    {
    }
}
