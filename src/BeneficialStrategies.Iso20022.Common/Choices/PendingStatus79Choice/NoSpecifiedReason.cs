// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus79Choice
{
    /// <summary>Reason not specified.</summary>
    [IsoId("_X5NngeSkEe-qVZLXW4RRBw")]
    [DisplayName("No Specified Reason")]
    public record NoSpecifiedReason : PendingStatus79Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NoSpcfdRsn")]
        public required NoReasonCode Value { get; init; }
    }
}
