// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RejectedStatus62Choice
{
    /// <summary>Specifies no specified reason for the rejected status.</summary>
    [IsoId("_j2C9Qd8PEe-NrtAAlrBEgQ")]
    [DisplayName("No Specified Reason")]
    public record NoSpecifiedReason : RejectedStatus62Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NoSpcfdRsn")]
        public required NoReasonCode Value { get; init; }
    }
}
