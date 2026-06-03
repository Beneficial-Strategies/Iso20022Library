// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus81Choice
{
    /// <summary>Reason not specified.</summary>
    [IsoId("c4b34a87-11e0-4095-a373-be28bbcee8ff")]
    [DisplayName("No Specified Reason")]
    public record NoSpecifiedReason : PendingStatus81Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NoSpcfdRsn")]
        public required NoReasonCode Value { get; init; }
    }
}
