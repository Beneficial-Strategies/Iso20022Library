// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AcknowledgedAcceptedStatus34Choice
{
    /// <summary>Specifies the reason of the acknowledged accepted status.</summary>
    [IsoId("_XJtf8Y5bEfC_4ZEXsY0Xyg")]
    [DisplayName("Reason")]
    public record Reason : AcknowledgedAcceptedStatus34Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rsn")]
        public required AcknowledgementReason22 Value { get; init; }
    }
}
