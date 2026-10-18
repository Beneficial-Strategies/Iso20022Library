// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RegulatoryReportingType1Choice
{
    /// <inheritdoc cref="ICode"/>
    [IsoId("_rJAakHeLEfCdoODv2ypKfw")]
    [DisplayName("Code")]
    public partial record Code : RegulatoryReportingType1Choice_
    {
        /// <inheritdoc cref="ICode.Value"/>
        [IsoXmlTag("Cd")]
        public required ExternalRegulatoryReportingType1Code Value { get; init; }
    }
}
