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
    /// Content of the batch request message.
    /// </summary>
    [KnownType(typeof(TransactionToPerform5Choice.PaymentRequest))]
    [KnownType(typeof(TransactionToPerform5Choice.LoyaltyRequest))]
    [KnownType(typeof(TransactionToPerform5Choice.ReversalRequest))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionToPerform5Choice.PaymentRequest),nameof(TransactionToPerform5Choice.PaymentRequest))]
    [JsonDerivedType(typeof(TransactionToPerform5Choice.LoyaltyRequest),nameof(TransactionToPerform5Choice.LoyaltyRequest))]
    [JsonDerivedType(typeof(TransactionToPerform5Choice.ReversalRequest),nameof(TransactionToPerform5Choice.ReversalRequest))]
    #endif
    [IsoId("_XnUecXGwEe2TbaNWBpRZpQ")]
    [DisplayName("Transaction To Perform 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionToPerform5Choice_
    #else
    public abstract partial class TransactionToPerform5Choice_
    #endif
    {
    }
}
