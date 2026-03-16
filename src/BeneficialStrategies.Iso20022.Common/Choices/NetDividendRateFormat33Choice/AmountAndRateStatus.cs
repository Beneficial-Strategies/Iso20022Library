// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NetDividendRateFormat33Choice
{
    /// <summary>
    /// Specifies an amount and a rate status.
    /// </summary>
    [IsoId("_skrJsc3wEee5nJBZsW8MFQ")]
    [DisplayName("Amount And Rate Status")]
    public record AmountAndRateStatus : NetDividendRateFormat33Choice_
    {
        /// <summary>
        /// Value expressed as an amount.
        /// </summary>
        [IsoId("_g2FhhZnREeWLs7cvLxlyAg")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required RestrictedFINActiveCurrencyAnd13DecimalAmount Amount { get; init; }

        /// <summary>
        /// Value expressed as a rate status.
        /// </summary>
        [IsoId("_g2FhhJnREeWLs7cvLxlyAg")]
        [DisplayName("Rate Status")]
        [IsoXmlTag("RateSts")]
        public required RateStatus1Code RateStatus { get; init; }
    }
}
