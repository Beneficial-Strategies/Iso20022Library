// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.IntraPositionProcessingStatus11Choice
{
    /// <summary>Specifies a choice of status for the processing of an intra-position movement.</summary>
    [IsoId("8f055fd3-1d3a-40d3-8ddb-516a3a87752a")]
    [DisplayName("Proprietary")]
    public record Proprietary : IntraPositionProcessingStatus11Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required ProprietaryStatusAndReason6 Value { get; init; }
    }
}
