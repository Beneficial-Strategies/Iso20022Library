// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.UnderlyingData13Choice
{
    /// <summary>Underlying data expressed as interbank payment transaction details.</summary>
    [IsoId("e84dee1f-bde7-430e-aee2-8c846ea56966")]
    [DisplayName("Interbank")]
    public record Interbank : UnderlyingData13Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("IntrBk")]
        public required UnderlyingPaymentTransaction11 Value { get; init; }
    }
}
