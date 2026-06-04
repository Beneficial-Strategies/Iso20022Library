// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TransactionToPerform8Choice
{
    /// <summary>Transaction to perform expressed as a loyalty request.</summary>
    [IsoId("_By-kR7ZaEfCUZfsQO4rYeA")]
    [DisplayName("Loyalty Request")]
    public record LoyaltyRequest : TransactionToPerform8Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("LltyReq")]
        public required LoyaltyRequest8 Value { get; init; }
    }
}
