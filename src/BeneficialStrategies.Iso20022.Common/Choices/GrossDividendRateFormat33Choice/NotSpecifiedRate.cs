// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.GrossDividendRateFormat33Choice
{
    /// <summary>
    /// Value of the rate not specified.
    /// </summary>
    [IsoId("_k9oCsc3xEee5nJBZsW8MFQ")]
    [DisplayName("Not Specified Rate")]
    public record NotSpecifiedRate : GrossDividendRateFormat33Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of rate.
        /// </summary>
        [IsoXmlTag("NotSpcfdRate")]
        public required RateType13Code Value { get; init; }
    }
}
