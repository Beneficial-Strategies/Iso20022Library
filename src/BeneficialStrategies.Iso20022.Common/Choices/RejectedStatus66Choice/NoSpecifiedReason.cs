// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RejectedStatus66Choice
{
    /// <summary>Specifies no specified reason for the rejected status.</summary>
    [IsoId("_EMQ1gajVEfCzuLlmLrhIvA")]
    [DisplayName("No Specified Reason")]
    public record NoSpecifiedReason : RejectedStatus66Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NoSpcfdRsn")]
        public required NoReasonCode Value { get; init; }
    }
}
