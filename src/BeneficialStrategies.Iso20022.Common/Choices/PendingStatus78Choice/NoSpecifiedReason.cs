// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus78Choice
{
    /// <summary>Reason not specified.</summary>
    [IsoId("_5ABosd8EEe-NrtAAlrBEgQ")]
    [DisplayName("No Specified Reason")]
    public record NoSpecifiedReason : PendingStatus78Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NoSpcfdRsn")]
        public required NoReasonCode Value { get; init; }
    }
}
