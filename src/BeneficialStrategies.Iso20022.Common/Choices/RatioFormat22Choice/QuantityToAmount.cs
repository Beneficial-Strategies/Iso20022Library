// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat22Choice
{
    /// <summary>
    /// Ratio expressed as a quantity to amount ratio.
    /// </summary>
    [IsoId("_ckCYcpKQEeWHWpTQn1FFVg")]
    [DisplayName("Quantity To Amount")]
    public record QuantityToAmount : RatioFormat22Choice_
    {
        /// <summary>
        /// Cash amount.
        /// </summary>
        [IsoId("_ckCYlJKQEeWHWpTQn1FFVg")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required RestrictedFINActiveCurrencyAnd13DecimalAmount Amount { get; init; }

        /// <summary>
        /// Quantity expressed as number.
        /// </summary>
        [IsoId("_ckCYnJKQEeWHWpTQn1FFVg")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINDecimalNumber)]
        public required IsoRestrictedFINDecimalNumber Quantity { get; init; }
    }
}
