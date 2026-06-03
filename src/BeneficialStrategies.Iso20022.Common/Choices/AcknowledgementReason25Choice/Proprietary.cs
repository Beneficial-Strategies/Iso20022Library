// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AcknowledgementReason25Choice
{
    /// <summary>Specifies additional information about the processed instruction.</summary>
    [IsoId("_XNInWY5bEfC_4ZEXsY0Xyg")]
    [DisplayName("Proprietary")]
    public record Proprietary : AcknowledgementReason25Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
