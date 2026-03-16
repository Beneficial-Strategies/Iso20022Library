// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat6Choice
{
    /// <summary>
    /// Ratio expressed as a quantity to amount ratio.
    /// </summary>
    [IsoId("_Q1-jytp-Ed-ak6NoX_4Aeg_-1274444744")]
    [DisplayName("Quantity To Amount")]
    public record QuantityToAmount : RatioFormat6Choice_
    {
        /// <summary>
        /// Cash amount.
        /// </summary>
        [IsoId("_UHySzdp-Ed-ak6NoX_4Aeg_1510604904")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

        /// <summary>
        /// Quantity expressed as number.
        /// </summary>
        [IsoId("_UHySztp-Ed-ak6NoX_4Aeg_1510604921")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public required IsoDecimalNumber Quantity { get; init; }
    }
}
