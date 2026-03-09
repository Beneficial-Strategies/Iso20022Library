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
    [KnownType(typeof(TransactionLoanData32Choice.RepurchaseTrade))]
    [KnownType(typeof(TransactionLoanData32Choice.BuySellBack))]
    [KnownType(typeof(TransactionLoanData32Choice.SecuritiesLending))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionLoanData32Choice.RepurchaseTrade),nameof(TransactionLoanData32Choice.RepurchaseTrade))]
    [JsonDerivedType(typeof(TransactionLoanData32Choice.BuySellBack),nameof(TransactionLoanData32Choice.BuySellBack))]
    [JsonDerivedType(typeof(TransactionLoanData32Choice.SecuritiesLending),nameof(TransactionLoanData32Choice.SecuritiesLending))]
    #endif
    [IsoId("_J_G2Acz4EeufhKfUxzsnrQ")]
    [DisplayName("Transaction Loan Data 32 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionLoanData32Choice_
    #else
    public abstract partial class TransactionLoanData32Choice_
    #endif
    {
    }
}
