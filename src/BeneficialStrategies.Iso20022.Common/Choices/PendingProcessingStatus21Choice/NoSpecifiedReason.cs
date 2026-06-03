// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PendingProcessingStatus21Choice
{
    /// <summary>Reason not specified.</summary>
    [IsoId("46128f72-5d21-4f0e-a813-6412e172f8c0")]
    [DisplayName("No Specified Reason")]
    public record NoSpecifiedReason : PendingProcessingStatus21Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NoSpcfdRsn")]
        public required NoReasonCode Value { get; init; }
    }
}
