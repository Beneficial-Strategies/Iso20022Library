// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat19Choice
{
    /// <summary>
    /// Ratio expressed as an amount to quantity ratio.
    /// </summary>
    [IsoId("_gCEKtIlWEeWPSZi0kAOXhg")]
    [DisplayName("Amount To Quantity")]
    public record AmountToQuantity : RatioFormat19Choice_
    {
        /// <summary>
        /// Cash amount.
        /// </summary>
        [IsoId("_7y0l5UEKEeWVgfuHGaKtRQ")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

        /// <summary>
        /// Quantity expressed as number.
        /// </summary>
        [IsoId("_7y0l7UEKEeWVgfuHGaKtRQ")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public required IsoDecimalNumber Quantity { get; init; }
    }
}
