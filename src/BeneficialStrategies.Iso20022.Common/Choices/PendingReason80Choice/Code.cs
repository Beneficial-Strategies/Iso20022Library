// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PendingReason80Choice
{
    /// <summary>Specifies the reason code why the instruction or request is pending.</summary>
    [IsoId("_lyBXxaogEfCG2_q2WT-90w")]
    [DisplayName("Code")]
    public record Code : PendingReason80Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required PendingReason32Code Value { get; init; }
    }
}
