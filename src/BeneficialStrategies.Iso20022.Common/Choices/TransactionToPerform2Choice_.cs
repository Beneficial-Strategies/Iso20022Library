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
    [KnownType(typeof(TransactionToPerform2Choice.PaymentRequest))]
    [KnownType(typeof(TransactionToPerform2Choice.LoyaltyRequest))]
    [KnownType(typeof(TransactionToPerform2Choice.ReversalRequest))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionToPerform2Choice.PaymentRequest),nameof(TransactionToPerform2Choice.PaymentRequest))]
    [JsonDerivedType(typeof(TransactionToPerform2Choice.LoyaltyRequest),nameof(TransactionToPerform2Choice.LoyaltyRequest))]
    [JsonDerivedType(typeof(TransactionToPerform2Choice.ReversalRequest),nameof(TransactionToPerform2Choice.ReversalRequest))]
    #endif
    [IsoId("_reKJAQxrEeqdx6buGpCCQw")]
    [DisplayName("Transaction To Perform 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionToPerform2Choice_
    #else
    public abstract partial class TransactionToPerform2Choice_
    #endif
    {
    }
}
