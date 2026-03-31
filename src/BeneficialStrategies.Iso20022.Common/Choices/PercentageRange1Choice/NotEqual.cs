// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PercentageRange1Choice
{
    /// <summary>
    /// Value that percentage rate must not match to be considered valid.
    /// </summary>
    [IsoId("_7_LCoqMgEeCJ6YNENx4h-w_-1954279776")]
    [DisplayName("Not Equal")]
    public record NotEqual : PercentageRange1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Rate expressed as a percentage, that is, in hundredths, for example, 0.7 is 7/10 of a percent, and 7.0 is 7%.
        /// </summary>
        [IsoXmlTag("NEQ")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public required IsoPercentageRate Value { get; init; }
    }
}
