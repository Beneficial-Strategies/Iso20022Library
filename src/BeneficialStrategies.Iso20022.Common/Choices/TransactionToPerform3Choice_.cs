// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Content of the Batch Request message.
    /// </summary>
    [KnownType(typeof(TransactionToPerform3Choice.PaymentRequest))]
    [KnownType(typeof(TransactionToPerform3Choice.LoyaltyRequest))]
    [KnownType(typeof(TransactionToPerform3Choice.ReversalRequest))]
    [JsonDerivedType(
        typeof(TransactionToPerform3Choice.PaymentRequest),
        nameof(TransactionToPerform3Choice.PaymentRequest)
    )]
    [JsonDerivedType(
        typeof(TransactionToPerform3Choice.LoyaltyRequest),
        nameof(TransactionToPerform3Choice.LoyaltyRequest)
    )]
    [JsonDerivedType(
        typeof(TransactionToPerform3Choice.ReversalRequest),
        nameof(TransactionToPerform3Choice.ReversalRequest)
    )]
    [IsoId("_xOWDUS8QEeu125Ip9zFcsQ")]
    [DisplayName("Transaction To Perform 3 Choice")]
    public abstract record TransactionToPerform3Choice_ { }
}
