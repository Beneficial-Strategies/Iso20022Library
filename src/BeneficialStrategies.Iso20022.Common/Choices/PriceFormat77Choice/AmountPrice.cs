// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat77Choice
{
    /// <summary>
    /// Amount Price.
    /// </summary>
    [DisplayName("Amount Price")]
    public record AmountPrice : PriceFormat77Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("AmtPric")]
        public required AmountPrice3 Value { get; init; }
    }
}
