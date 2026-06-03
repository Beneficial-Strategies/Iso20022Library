// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RejectedStatus63Choice
{
    /// <summary>Specifies no specified reason for the rejected status.</summary>
    [IsoId("_0EVEYd78Ee-NrtAAlrBEgQ")]
    [DisplayName("No Specified Reason")]
    public record NoSpecifiedReason : RejectedStatus63Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NoSpcfdRsn")]
        public required NoReasonCode Value { get; init; }
    }
}
