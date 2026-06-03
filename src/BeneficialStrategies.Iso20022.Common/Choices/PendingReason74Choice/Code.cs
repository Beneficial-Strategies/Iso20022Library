// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PendingReason74Choice
{
    /// <summary>Pending reason specified as a code.</summary>
    [IsoId("_FPP-od8FEe-NrtAAlrBEgQ")]
    [DisplayName("Code")]
    public record Code : PendingReason74Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required PendingReason30Code Value { get; init; }
    }
}
