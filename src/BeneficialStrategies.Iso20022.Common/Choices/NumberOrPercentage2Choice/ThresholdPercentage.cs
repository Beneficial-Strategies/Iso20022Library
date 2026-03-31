// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NumberOrPercentage2Choice
{
    /// <summary>
    /// Threshold Percentage.
    /// </summary>
    [DisplayName("Threshold Percentage")]
    public record ThresholdPercentage : NumberOrPercentage2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("ThrshldPctg")]
        public required IsoPercentage14Rate Value { get; init; }
    }
}
