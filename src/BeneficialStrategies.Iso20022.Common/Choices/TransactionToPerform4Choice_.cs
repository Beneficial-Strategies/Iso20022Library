// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Content of the Batch Request message.
    /// </summary>
    [KnownType(typeof(TransactionToPerform4Choice.PaymentRequest))]
    [KnownType(typeof(TransactionToPerform4Choice.LoyaltyRequest))]
    [KnownType(typeof(TransactionToPerform4Choice.ReversalRequest))]
    [JsonDerivedType(
        typeof(TransactionToPerform4Choice.PaymentRequest),
        nameof(TransactionToPerform4Choice.PaymentRequest)
    )]
    [JsonDerivedType(
        typeof(TransactionToPerform4Choice.LoyaltyRequest),
        nameof(TransactionToPerform4Choice.LoyaltyRequest)
    )]
    [JsonDerivedType(
        typeof(TransactionToPerform4Choice.ReversalRequest),
        nameof(TransactionToPerform4Choice.ReversalRequest)
    )]
    [IsoId("_8rz5wU31Eey_VecAUE-C9Q")]
    [DisplayName("Transaction To Perform 4 Choice")]
    public abstract record TransactionToPerform4Choice_ { }
}
