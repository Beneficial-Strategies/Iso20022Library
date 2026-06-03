// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction14Choice
{
    /// <summary>Completed card payment transaction to be captured.</summary>
    [IsoId("_tKIfVbYJEfCUZfsQO4rYeA")]
    [DisplayName("Completion")]
    public record Completion : CardPaymentDataSetTransaction14Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cmpltn")]
        public required CardPaymentDataSetTransaction55 Value { get; init; }
    }
}
