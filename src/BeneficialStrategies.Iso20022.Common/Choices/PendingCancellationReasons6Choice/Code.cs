// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationReasons6Choice
{
    /// <summary>Specifies the reason why the cancellation request is pending.</summary>
    [IsoId("_2avCAaoWEfCG2_q2WT-90w")]
    [DisplayName("Code")]
    public record Code : PendingCancellationReasons6Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required PendingReason34Code Value { get; init; }
    }
}
