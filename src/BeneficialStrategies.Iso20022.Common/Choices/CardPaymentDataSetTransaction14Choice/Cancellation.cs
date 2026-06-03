// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction14Choice
{
    /// <summary>Cancelled card payment transaction to be captured.</summary>
    [IsoId("_tKIfW7YJEfCUZfsQO4rYeA")]
    [DisplayName("Cancellation")]
    public record Cancellation : CardPaymentDataSetTransaction14Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cxl")]
        public required CardPaymentDataSetTransaction54 Value { get; init; }
    }
}
