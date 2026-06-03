// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PendingReason76Choice
{
    /// <summary>Pending reason specified as a code.</summary>
    [IsoId("_2k33caKtEfCHi7w3_0pcpw")]
    [DisplayName("Code")]
    public record Code : PendingReason76Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required PendingReason37Code Value { get; init; }
    }
}
