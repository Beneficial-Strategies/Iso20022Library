// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RejectedReason69Choice
{
    /// <summary>Specifies the code.</summary>
    [IsoId("_HhfUIaKvEfCHi7w3_0pcpw")]
    [DisplayName("Code")]
    public record Code : RejectedReason69Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason90Code Value { get; init; }
    }
}
