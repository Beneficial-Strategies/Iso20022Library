// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TransactionToPerform8Choice
{
    /// <summary>Transaction to perform expressed as a reversal request.</summary>
    [IsoId("_By-kTbZaEfCUZfsQO4rYeA")]
    [DisplayName("Reversal Request")]
    public record ReversalRequest : TransactionToPerform8Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("RvslReq")]
        public required ReversalRequest8 Value { get; init; }
    }
}
