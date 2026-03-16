// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat4Choice
{
    /// <summary>
    /// Ratio expressed as a quantity to amount ratio.
    /// </summary>
    [IsoId("_Q1h32dp-Ed-ak6NoX_4Aeg_-1878091141")]
    [DisplayName("Quantity To Amount")]
    [IsoXmlTag("QtyToAmt")]
    public record QuantityToAmount : RatioFormat4Choice_
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
