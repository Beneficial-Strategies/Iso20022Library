// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus102Choice
{
    /// <summary>Specifies the acknowledged accepted status.</summary>
    [IsoId("a48bbefa-2c1d-4bb9-9747-5903b2fe56ad")]
    [DisplayName("Acknowledged Accepted")]
    public record AcknowledgedAccepted : ProcessingStatus102Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AckdAccptd")]
        public required AcknowledgedAcceptedStatus21Choice_ Value { get; init; }
    }
}
