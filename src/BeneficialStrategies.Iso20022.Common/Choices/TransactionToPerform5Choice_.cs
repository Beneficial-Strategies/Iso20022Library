// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Content of the batch request message.
    /// </summary>
    [KnownType(typeof(TransactionToPerform5Choice.PaymentRequest))]
    [KnownType(typeof(TransactionToPerform5Choice.LoyaltyRequest))]
    [KnownType(typeof(TransactionToPerform5Choice.ReversalRequest))]
    [JsonDerivedType(
        typeof(TransactionToPerform5Choice.PaymentRequest),
        nameof(TransactionToPerform5Choice.PaymentRequest)
    )]
    [JsonDerivedType(
        typeof(TransactionToPerform5Choice.LoyaltyRequest),
        nameof(TransactionToPerform5Choice.LoyaltyRequest)
    )]
    [JsonDerivedType(
        typeof(TransactionToPerform5Choice.ReversalRequest),
        nameof(TransactionToPerform5Choice.ReversalRequest)
    )]
    [IsoId("_XnUecXGwEe2TbaNWBpRZpQ")]
    [DisplayName("Transaction To Perform 5 Choice")]
    public abstract record TransactionToPerform5Choice_ { }
}
