// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceRateOrAmount1Choice
{
    /// <summary>
    /// Price expressed as a currency and value.
    /// </summary>
    [IsoId("_Wi6RZNp-Ed-ak6NoX_4Aeg_-1237359352")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public record Amount : PriceRateOrAmount1Choice_
    {
        /// <summary>
        /// The currency in which this amount is measured.
        /// </summary>
        [IsoId("_WOMlp9p-Ed-ak6NoX_4Aeg_-1678737059_Currency")]
        [DisplayName("Restricted FIN Active Or Historic Currency And 13 Decimal Amount _ Currency")]
        [IsoXmlTag("Currency")]
        public required System.String Currency { get; init; }

        /// <summary>
        /// Amount of the transaction.
        /// </summary>
        [IsoXmlTag("Amount")]
        public required System.Decimal Value { get; init; }
    }
}
