// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NumberOrPercentage2Choice
{
    /// <summary>
    /// Threshold Number.
    /// </summary>
    [DisplayName("Threshold Number")]
    public record ThresholdNumber : NumberOrPercentage2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("ThrshldNb")]
        public required IsoNumber Value { get; init; }
    }
}
