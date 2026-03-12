// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Content of the Batch Request message.
    /// </summary>
    [KnownType(typeof(TransactionToPerform1Choice.PaymentRequest))]
    [KnownType(typeof(TransactionToPerform1Choice.LoyaltyRequest))]
    [KnownType(typeof(TransactionToPerform1Choice.ReversalRequest))]
    [JsonDerivedType(typeof(TransactionToPerform1Choice.PaymentRequest),nameof(TransactionToPerform1Choice.PaymentRequest))]
    [JsonDerivedType(typeof(TransactionToPerform1Choice.LoyaltyRequest),nameof(TransactionToPerform1Choice.LoyaltyRequest))]
    [JsonDerivedType(typeof(TransactionToPerform1Choice.ReversalRequest),nameof(TransactionToPerform1Choice.ReversalRequest))]
    [IsoId("_uF9jANuREeiB5uLfkg9ZJA")]
    [DisplayName("Transaction To Perform 1 Choice")]
    public abstract partial record TransactionToPerform1Choice_
    {
    }
}
