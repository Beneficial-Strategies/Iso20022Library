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
    /// Details of the loan used for financing the transaction.
    /// </summary>
    [KnownType(typeof(TransactionLoanData26Choice.RepurchaseTrade))]
    [KnownType(typeof(TransactionLoanData26Choice.BuySellBack))]
    [KnownType(typeof(TransactionLoanData26Choice.SecuritiesLending))]
    [KnownType(typeof(TransactionLoanData26Choice.MarginLending))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionLoanData26Choice.RepurchaseTrade),nameof(TransactionLoanData26Choice.RepurchaseTrade))]
    [JsonDerivedType(typeof(TransactionLoanData26Choice.BuySellBack),nameof(TransactionLoanData26Choice.BuySellBack))]
    [JsonDerivedType(typeof(TransactionLoanData26Choice.SecuritiesLending),nameof(TransactionLoanData26Choice.SecuritiesLending))]
    [JsonDerivedType(typeof(TransactionLoanData26Choice.MarginLending),nameof(TransactionLoanData26Choice.MarginLending))]
    #endif
    [IsoId("_388OoXz2EeurrJrNxcsszQ")]
    [DisplayName("Transaction Loan Data 26 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionLoanData26Choice_
    #else
    public abstract partial class TransactionLoanData26Choice_
    #endif
    {
    }
}
