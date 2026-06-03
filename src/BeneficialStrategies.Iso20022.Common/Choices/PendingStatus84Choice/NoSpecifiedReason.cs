// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus84Choice
{
    /// <summary>No reason specified.</summary>
    [IsoId("_RlgcMbMVEfCEXew4g5B5oA")]
    [DisplayName("No Specified Reason")]
    public record NoSpecifiedReason : PendingStatus84Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NoSpcfdRsn")]
        public required NoReasonCode Value { get; init; }
    }
}
