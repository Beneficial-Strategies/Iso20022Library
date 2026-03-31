// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.GrossDividendRateFormat33Choice
{
    /// <summary>
    /// Specifies an amount and a rate status.
    /// </summary>
    [IsoId("_k9oCp83xEee5nJBZsW8MFQ")]
    [DisplayName("Amount And Rate Status")]
    [IsoXmlTag("AmtAndRateSts")]
    public record AmountAndRateStatus : GrossDividendRateFormat33Choice_
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
