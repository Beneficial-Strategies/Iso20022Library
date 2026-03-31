// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateType17Choice
{
    /// <summary>
    /// Standard code to specify the type of tax rate.
    /// </summary>
    [IsoId("_uSEE4finEd-0JoSb983HHw")]
    [DisplayName("Code")]
    public record Code : RateType17Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of dividend rate.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DividendRateType1Code Value { get; init; }
    }
}
