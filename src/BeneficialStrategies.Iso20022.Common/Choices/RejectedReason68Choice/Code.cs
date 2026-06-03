// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RejectedReason68Choice
{
    /// <summary>Specifies the code.</summary>
    [IsoId("_pS4SYaKsEfCHi7w3_0pcpw")]
    [DisplayName("Code")]
    public record Code : RejectedReason68Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason89Code Value { get; init; }
    }
}
