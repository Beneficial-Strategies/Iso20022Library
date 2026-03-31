// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InterestRate6Choice
{
    /// <summary>
    /// Indicates that the rate is fixed.
    /// </summary>
    [IsoId("_nf6kwSc1EeaCIe3n1Gx9ug")]
    [DisplayName("Fixed")]
    public record Fixed : InterestRate6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Rate expressed as a percentage, that is, in hundredths, for example, 0.7 is 7/10 of a percent, and 7.0 is 7%.
        /// </summary>
        [IsoXmlTag("Fxd")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public required IsoPercentageRate Value { get; init; }
    }
}
