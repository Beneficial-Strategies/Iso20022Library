// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Content of the Batch Request message.
    /// </summary>
    [KnownType(typeof(TransactionToPerform2Choice.PaymentRequest))]
    [KnownType(typeof(TransactionToPerform2Choice.LoyaltyRequest))]
    [KnownType(typeof(TransactionToPerform2Choice.ReversalRequest))]
    [JsonDerivedType(typeof(TransactionToPerform2Choice.PaymentRequest),nameof(TransactionToPerform2Choice.PaymentRequest))]
    [JsonDerivedType(typeof(TransactionToPerform2Choice.LoyaltyRequest),nameof(TransactionToPerform2Choice.LoyaltyRequest))]
    [JsonDerivedType(typeof(TransactionToPerform2Choice.ReversalRequest),nameof(TransactionToPerform2Choice.ReversalRequest))]
    [IsoId("_reKJAQxrEeqdx6buGpCCQw")]
    [DisplayName("Transaction To Perform 2 Choice")]
    public abstract partial record TransactionToPerform2Choice_
    {
    }
}
