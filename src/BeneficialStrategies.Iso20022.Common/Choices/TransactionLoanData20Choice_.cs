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
    [KnownType(typeof(TransactionLoanData20Choice.RepurchaseTrade))]
    [KnownType(typeof(TransactionLoanData20Choice.BuySellBack))]
    [KnownType(typeof(TransactionLoanData20Choice.SecuritiesLending))]
    [KnownType(typeof(TransactionLoanData20Choice.MarginLending))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionLoanData20Choice.RepurchaseTrade),nameof(TransactionLoanData20Choice.RepurchaseTrade))]
    [JsonDerivedType(typeof(TransactionLoanData20Choice.BuySellBack),nameof(TransactionLoanData20Choice.BuySellBack))]
    [JsonDerivedType(typeof(TransactionLoanData20Choice.SecuritiesLending),nameof(TransactionLoanData20Choice.SecuritiesLending))]
    [JsonDerivedType(typeof(TransactionLoanData20Choice.MarginLending),nameof(TransactionLoanData20Choice.MarginLending))]
    #endif
    [IsoId("_lelb3bONEemDE9K-I5TT8Q")]
    [DisplayName("Transaction Loan Data 20 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionLoanData20Choice_
    #else
    public abstract partial class TransactionLoanData20Choice_
    #endif
    {
    }
}
