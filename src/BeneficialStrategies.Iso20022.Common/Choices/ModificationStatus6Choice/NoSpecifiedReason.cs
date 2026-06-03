// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.ModificationStatus6Choice
{
    /// <summary>Indicates that there is no reason available or to report.</summary>
    [IsoId("9c99c1cf-19b9-47da-b39b-648871101da7")]
    [DisplayName("No Specified Reason")]
    public record NoSpecifiedReason : ModificationStatus6Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NoSpcfdRsn")]
        public required NoReasonCode Value { get; init; }
    }
}
