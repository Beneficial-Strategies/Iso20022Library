// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RejectedStatus64Choice
{
    /// <summary>Specifies no specified reason for the rejected status.</summary>
    [IsoId("_5CDhAaKsEfCHi7w3_0pcpw")]
    [DisplayName("No Specified Reason")]
    public record NoSpecifiedReason : RejectedStatus64Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NoSpcfdRsn")]
        public required NoReasonCode Value { get; init; }
    }
}
