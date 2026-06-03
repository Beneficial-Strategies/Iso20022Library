// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PendingReason82Choice
{
    /// <summary>Pending reason specified as a code.</summary>
    [IsoId("_jGVR0bMZEfCEXew4g5B5oA")]
    [DisplayName("Code")]
    public record Code : PendingReason82Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required PendingReason38Code Value { get; init; }
    }
}
