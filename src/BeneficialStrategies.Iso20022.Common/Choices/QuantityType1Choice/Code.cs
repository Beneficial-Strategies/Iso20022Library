// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.QuantityType1Choice
{
    /// <summary>
    /// Quantity type expressed as a code.
    /// </summary>
    [IsoId("_2-19cQaxEeS3lpTattq7hg")]
    [DisplayName("Code")]
    public record Code : QuantityType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies how the order is placed, eg by quantity of units or by amount of money.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OrderQuantityType2Code Value { get; init; }
    }
}
