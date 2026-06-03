// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PendingReason79Choice
{
    /// <summary>Specifies the reason why the cancellation request is pending.</summary>
    [IsoId("_vDBwdaodEfCG2_q2WT-90w")]
    [DisplayName("Code")]
    public record Code : PendingReason79Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required PendingReason35Code Value { get; init; }
    }
}
