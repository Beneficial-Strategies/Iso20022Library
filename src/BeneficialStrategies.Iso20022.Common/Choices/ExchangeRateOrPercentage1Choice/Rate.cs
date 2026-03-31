// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ExchangeRateOrPercentage1Choice
{
    /// <summary>
    /// Rate is expressed an currency exchange rate.
    /// </summary>
    [IsoId("_zZKxgNfvEeqoweZZxm4TPQ")]
    [DisplayName("Rate")]
    public record Rate : ExchangeRateOrPercentage1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Rate expressed as a decimal, for example, 0.7 is 7/10 and 70%.
        /// </summary>
        [IsoXmlTag("Rate")]
        [IsoSimpleType(IsoSimpleType.BaseOneRate)]
        public required IsoBaseOneRate Value { get; init; }
    }
}
