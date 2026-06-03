// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RegulatoryReportingType1Choice
{
    /// <summary>Specifies the proprietary value.</summary>
    [IsoId("_75HhwHeLEfCdoODv2ypKfw")]
    [DisplayName("Proprietary")]
    public record Proprietary : RegulatoryReportingType1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required IsoMax35Text Value { get; init; }
    }
}
