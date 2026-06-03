// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationStatus17Choice
{
    /// <summary>Reason not specified.</summary>
    [IsoId("_dZcQwd8QEe-NrtAAlrBEgQ")]
    [DisplayName("Not Specified Reason")]
    public record NotSpecifiedReason : PendingCancellationStatus17Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NotSpcfdRsn")]
        public required NoReasonCode Value { get; init; }
    }
}
