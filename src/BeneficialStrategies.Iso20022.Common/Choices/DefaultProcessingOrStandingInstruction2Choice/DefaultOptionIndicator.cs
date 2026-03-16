// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DefaultProcessingOrStandingInstruction2Choice
{
    /// <summary>
    /// Default Option Indicator.
    /// </summary>
    [DisplayName("Default Option Indicator")]
    public record DefaultOptionIndicator : DefaultProcessingOrStandingInstruction2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("DfltOptnInd")]
        public required IsoYesNoIndicator Value { get; init; }
    }
}
