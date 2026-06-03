// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RejectedReason65Choice
{
    /// <summary>Specifies the code.</summary>
    [IsoId("_Crapkd79Ee-NrtAAlrBEgQ")]
    [DisplayName("Code")]
    public record Code : RejectedReason65Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason87Code Value { get; init; }
    }
}
