// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus99Choice
{
    /// <summary>Specifies the proprietary status.</summary>
    [IsoId("_XHwYMY5bEfC_4ZEXsY0Xyg")]
    [DisplayName("Proprietary")]
    public record Proprietary : ProcessingStatus99Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required ProprietaryStatusAndReason6 Value { get; init; }
    }
}
