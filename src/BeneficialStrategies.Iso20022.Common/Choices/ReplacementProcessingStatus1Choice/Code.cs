// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReplacementProcessingStatus1Choice
{
    /// <summary>
    /// Provides the processing status of the replacement request.
    /// </summary>
    [IsoId("_UXSHUdp-Ed-ak6NoX_4Aeg_-220686661")]
    [DisplayName("Code")]
    public record Code : ReplacementProcessingStatus1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the processing status of the replacement request.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ReplacementProcessingStatus1Code Value { get; init; }
    }
}
