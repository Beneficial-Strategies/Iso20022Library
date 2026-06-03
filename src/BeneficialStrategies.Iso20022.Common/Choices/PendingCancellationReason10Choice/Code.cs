// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationReason10Choice
{
    /// <summary>Standard code to specify the reason why a cancellation request sent for the related instruction is pending.</summary>
    [IsoId("_hPBtsaLNEfCHi7w3_0pcpw")]
    [DisplayName("Code")]
    public record Code : PendingCancellationReason10Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required PendingCancellationReason9Code Value { get; init; }
    }
}
