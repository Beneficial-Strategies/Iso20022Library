// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.UnderlyingData13Choice
{
    /// <summary>Underlying data expressed as payment initiation details.</summary>
    [IsoId("02510b57-5ee1-4399-929a-e9755ca10d57")]
    [DisplayName("Initiation")]
    public record Initiation : UnderlyingData13Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Initn")]
        public required UnderlyingPaymentInstruction11 Value { get; init; }
    }
}
