// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RejectedReason64Choice
{
    /// <summary>Specifies the code.</summary>
    [IsoId("_j-z3sd8PEe-NrtAAlrBEgQ")]
    [DisplayName("Code")]
    public record Code : RejectedReason64Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason88Code Value { get; init; }
    }
}
