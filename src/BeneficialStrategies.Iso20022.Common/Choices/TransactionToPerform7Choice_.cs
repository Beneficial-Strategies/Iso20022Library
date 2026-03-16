// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Transaction To Perform7Choice.
    /// </summary>
    [KnownType(typeof(TransactionToPerform7Choice.LoyaltyRequest))]
    [KnownType(typeof(TransactionToPerform7Choice.PaymentRequest))]
    [KnownType(typeof(TransactionToPerform7Choice.ReversalRequest))]
    [JsonDerivedType(
        typeof(TransactionToPerform7Choice.LoyaltyRequest),
        nameof(TransactionToPerform7Choice.LoyaltyRequest)
    )]
    [JsonDerivedType(
        typeof(TransactionToPerform7Choice.PaymentRequest),
        nameof(TransactionToPerform7Choice.PaymentRequest)
    )]
    [JsonDerivedType(
        typeof(TransactionToPerform7Choice.ReversalRequest),
        nameof(TransactionToPerform7Choice.ReversalRequest)
    )]
    [IsoId("_GnFUIaETEe-MRKYsaX6JDg")]
    [DisplayName("Transaction To Perform7Choice")]
    public abstract record TransactionToPerform7Choice_ { }
}
