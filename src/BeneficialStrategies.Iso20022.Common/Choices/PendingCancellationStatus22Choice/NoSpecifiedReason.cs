// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationStatus22Choice
{
    /// <summary>Reason not specified.</summary>
    [IsoId("_JnvH8a8xEfCx2aBifPEdRg")]
    [DisplayName("No Specified Reason")]
    public record NoSpecifiedReason : PendingCancellationStatus22Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NoSpcfdRsn")]
        public required NoReasonCode Value { get; init; }
    }
}
