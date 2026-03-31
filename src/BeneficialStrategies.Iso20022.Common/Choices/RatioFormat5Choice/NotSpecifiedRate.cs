// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat5Choice
{
    /// <summary>
    /// Value of the ratio not specified.
    /// </summary>
    [IsoId("_Q2IUx9p-Ed-ak6NoX_4Aeg_1134486972")]
    [DisplayName("Not Specified Rate")]
    public record NotSpecifiedRate : RatioFormat5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the value of a rate.
        /// </summary>
        [IsoXmlTag("NotSpcfdRate")]
        public required RateValueType6Code Value { get; init; }
    }
}
