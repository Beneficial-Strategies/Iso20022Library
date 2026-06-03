// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RejectedReason67Choice
{
    /// <summary>Specifies the code.</summary>
    [IsoId("cd4e4981-231b-45a8-8b0b-f1145b4ae28e")]
    [DisplayName("Code")]
    public record Code : RejectedReason67Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required RejectedStatusReason15Code Value { get; init; }
    }
}
