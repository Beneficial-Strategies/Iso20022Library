// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus70Choice
{
    /// <summary>Specifies the processing status as a proprietary value.</summary>
    [IsoId("_mXWx0-GHEeWCAvUNsZ5u6g")]
    [DisplayName("Proprietary")]
    public record Proprietary : ProcessingStatus70Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
