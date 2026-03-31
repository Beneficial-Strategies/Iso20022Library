// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NumberOrPercentage1Choice
{
    /// <summary>
    /// Threshold provided as a decimal number.
    /// </summary>
    [IsoId("_4TLdUK4pEemG7MmivSuE5g")]
    [DisplayName("Threshold Number")]
    public record ThresholdNumber : NumberOrPercentage1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as an integer.
        /// </summary>
        [IsoXmlTag("ThrshldNb")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public required IsoNumber Value { get; init; }
    }
}
