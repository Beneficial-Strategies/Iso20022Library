// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AcknowledgementReason25Choice
{
    /// <summary>Specifies additional information about the processed instruction.</summary>
    [IsoId("_XNInUY5bEfC_4ZEXsY0Xyg")]
    [DisplayName("Code")]
    public record Code : AcknowledgementReason25Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required AcknowledgementReason11Code Value { get; init; }
    }
}
