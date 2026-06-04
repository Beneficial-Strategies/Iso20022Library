// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.TransactionToPerform8Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between different types of transaction to perform.</summary>
    [IsoId("_Bx5mMbZaEfCUZfsQO4rYeA")]
    [DisplayName("Transaction To Perform 8 Choice")]
    [KnownType(typeof(TransactionToPerform8Choice.PaymentRequest))]
    [KnownType(typeof(TransactionToPerform8Choice.LoyaltyRequest))]
    [KnownType(typeof(TransactionToPerform8Choice.ReversalRequest))]
    [JsonDerivedType(typeof(TransactionToPerform8Choice.PaymentRequest))]
    [JsonDerivedType(typeof(TransactionToPerform8Choice.LoyaltyRequest))]
    [JsonDerivedType(typeof(TransactionToPerform8Choice.ReversalRequest))]
    public abstract record TransactionToPerform8Choice_
    {
    }
}
