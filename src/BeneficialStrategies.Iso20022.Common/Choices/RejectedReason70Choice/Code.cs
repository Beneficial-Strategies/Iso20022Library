// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RejectedReason70Choice
{
    /// <summary>Specifies the code.</summary>
    [IsoId("_Eah7AajVEfCzuLlmLrhIvA")]
    [DisplayName("Code")]
    public record Code : RejectedReason70Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason91Code Value { get; init; }
    }
}
