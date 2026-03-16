// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Transaction To Perform6Choice.
    /// </summary>
    [KnownType(typeof(TransactionToPerform6Choice.LoyaltyRequest))]
    [KnownType(typeof(TransactionToPerform6Choice.PaymentRequest))]
    [KnownType(typeof(TransactionToPerform6Choice.ReversalRequest))]
    [JsonDerivedType(typeof(TransactionToPerform6Choice.LoyaltyRequest),nameof(TransactionToPerform6Choice.LoyaltyRequest))]
    [JsonDerivedType(typeof(TransactionToPerform6Choice.PaymentRequest),nameof(TransactionToPerform6Choice.PaymentRequest))]
    [JsonDerivedType(typeof(TransactionToPerform6Choice.ReversalRequest),nameof(TransactionToPerform6Choice.ReversalRequest))]
    [IsoId("_1EhJAZRHEe6mHLZGMDWxvg")]
    [DisplayName("Transaction To Perform6Choice")]
    public abstract partial record TransactionToPerform6Choice_
    {
    }
}
