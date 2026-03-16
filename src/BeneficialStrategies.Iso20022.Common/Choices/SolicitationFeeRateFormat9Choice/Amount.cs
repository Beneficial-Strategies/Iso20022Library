// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SolicitationFeeRateFormat9Choice
{
    /// <summary>
    /// Cash amount.
    /// </summary>
    [IsoId("_ckNXrZKQEeWHWpTQn1FFVg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public record Amount : SolicitationFeeRateFormat9Choice_
    {
        /// <summary>
        /// The currency in which this amount is measured.
        /// </summary>
        [IsoId("_WN5Dptp-Ed-ak6NoX_4Aeg_-154812387_Currency")]
        [DisplayName("Restricted FIN Active Currency And 13 Decimal Amount _ Currency")]
        [IsoXmlTag("Currency")]
        public required System.String Currency { get; init; }

        /// <summary>
        /// Amount of the transaction.
        /// </summary>
        [IsoXmlTag("Amount")]
        public required System.Decimal Value { get; init; }
    }
}
