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
    [KnownType(typeof(TransactionLoanData21Choice.RepurchaseTrade))]
    [KnownType(typeof(TransactionLoanData21Choice.BuySellBack))]
    [KnownType(typeof(TransactionLoanData21Choice.SecuritiesLending))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionLoanData21Choice.RepurchaseTrade),nameof(TransactionLoanData21Choice.RepurchaseTrade))]
    [JsonDerivedType(typeof(TransactionLoanData21Choice.BuySellBack),nameof(TransactionLoanData21Choice.BuySellBack))]
    [JsonDerivedType(typeof(TransactionLoanData21Choice.SecuritiesLending),nameof(TransactionLoanData21Choice.SecuritiesLending))]
    #endif
    [IsoId("_4AyNrf_qEemm3skPVSMJQg")]
    [DisplayName("Transaction Loan Data 21 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionLoanData21Choice_
    #else
    public abstract partial class TransactionLoanData21Choice_
    #endif
    {
    }
}
