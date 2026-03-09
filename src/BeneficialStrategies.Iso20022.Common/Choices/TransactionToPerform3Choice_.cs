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
    /// Content of the Batch Request message.
    /// </summary>
    [KnownType(typeof(TransactionToPerform3Choice.PaymentRequest))]
    [KnownType(typeof(TransactionToPerform3Choice.LoyaltyRequest))]
    [KnownType(typeof(TransactionToPerform3Choice.ReversalRequest))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionToPerform3Choice.PaymentRequest),nameof(TransactionToPerform3Choice.PaymentRequest))]
    [JsonDerivedType(typeof(TransactionToPerform3Choice.LoyaltyRequest),nameof(TransactionToPerform3Choice.LoyaltyRequest))]
    [JsonDerivedType(typeof(TransactionToPerform3Choice.ReversalRequest),nameof(TransactionToPerform3Choice.ReversalRequest))]
    #endif
    [IsoId("_xOWDUS8QEeu125Ip9zFcsQ")]
    [DisplayName("Transaction To Perform 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionToPerform3Choice_
    #else
    public abstract partial class TransactionToPerform3Choice_
    #endif
    {
    }
}
