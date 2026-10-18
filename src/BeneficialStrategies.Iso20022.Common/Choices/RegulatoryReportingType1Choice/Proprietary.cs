// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RegulatoryReportingType1Choice
{
    /// <inheritdoc cref="IProprietary"/>
    [IsoId("_75HhwHeLEfCdoODv2ypKfw")]
    [DisplayName("Proprietary")]
    public partial record Proprietary : RegulatoryReportingType1Choice_
    {
        /// <inheritdoc cref="IProprietary.Value"/>
        [IsoXmlTag("Prtry")]
        public required IsoMax35Text Value { get; init; }
    }
}
