// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat24Choice
{
    /// <summary>
    /// Value of the ratio not specified.
    /// </summary>
    [IsoId("_cti6hJKQEeWHWpTQn1FFVg")]
    [DisplayName("Not Specified Rate")]
    public record NotSpecifiedRate : RatioFormat24Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the value of a rate.
        /// </summary>
        [IsoXmlTag("NotSpcfdRate")]
        public required RateValueType7Code Value { get; init; }
    }
}
