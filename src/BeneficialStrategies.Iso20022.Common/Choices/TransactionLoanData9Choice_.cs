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
    [KnownType(typeof(TransactionLoanData9Choice.RepurchaseTrade))]
    [KnownType(typeof(TransactionLoanData9Choice.BuySellBack))]
    [KnownType(typeof(TransactionLoanData9Choice.SecuritiesLending))]
    [KnownType(typeof(TransactionLoanData9Choice.MarginLending))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionLoanData9Choice.RepurchaseTrade),nameof(TransactionLoanData9Choice.RepurchaseTrade))]
    [JsonDerivedType(typeof(TransactionLoanData9Choice.BuySellBack),nameof(TransactionLoanData9Choice.BuySellBack))]
    [JsonDerivedType(typeof(TransactionLoanData9Choice.SecuritiesLending),nameof(TransactionLoanData9Choice.SecuritiesLending))]
    [JsonDerivedType(typeof(TransactionLoanData9Choice.MarginLending),nameof(TransactionLoanData9Choice.MarginLending))]
    #endif
    [IsoId("_Hg0sIKoMEemdLtwzt4CWxg")]
    [DisplayName("Transaction Loan Data 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionLoanData9Choice_
    #else
    public abstract partial class TransactionLoanData9Choice_
    #endif
    {
    }
}
