// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateFormat24Choice
{
    /// <summary>
    /// Not Specified Rate.
    /// </summary>
    [DisplayName("Not Specified Rate")]
    public record NotSpecifiedRate : RateFormat24Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("NotSpcfdRate")]
        public required RateType5Code Value { get; init; }
    }
}
