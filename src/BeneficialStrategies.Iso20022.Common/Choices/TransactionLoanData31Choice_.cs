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
    [KnownType(typeof(TransactionLoanData31Choice.RepurchaseTrade))]
    [KnownType(typeof(TransactionLoanData31Choice.BuySellBack))]
    [KnownType(typeof(TransactionLoanData31Choice.SecuritiesLending))]
    [KnownType(typeof(TransactionLoanData31Choice.MarginLending))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionLoanData31Choice.RepurchaseTrade),nameof(TransactionLoanData31Choice.RepurchaseTrade))]
    [JsonDerivedType(typeof(TransactionLoanData31Choice.BuySellBack),nameof(TransactionLoanData31Choice.BuySellBack))]
    [JsonDerivedType(typeof(TransactionLoanData31Choice.SecuritiesLending),nameof(TransactionLoanData31Choice.SecuritiesLending))]
    [JsonDerivedType(typeof(TransactionLoanData31Choice.MarginLending),nameof(TransactionLoanData31Choice.MarginLending))]
    #endif
    [IsoId("_lmwk8czsEeux2uvSBFU54Q")]
    [DisplayName("Transaction Loan Data 31 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionLoanData31Choice_
    #else
    public abstract partial class TransactionLoanData31Choice_
    #endif
    {
    }
}
