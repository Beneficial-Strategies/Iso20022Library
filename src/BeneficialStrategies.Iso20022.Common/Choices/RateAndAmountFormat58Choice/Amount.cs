// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat58Choice
{
    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    public record Amount : RateAndAmountFormat58Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAnd13DecimalAmount Value { get; init; }
    }
}
