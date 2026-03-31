// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat24Choice
{
    /// <summary>
    /// Ratio expressed as a quotient of amounts.
    /// </summary>
    [IsoId("_cti6jJKQEeWHWpTQn1FFVg")]
    [DisplayName("Amount To Amount")]
    [IsoXmlTag("AmtToAmt")]
    public record AmountToAmount : RatioFormat24Choice_
    {
        /// <summary>
        /// Numerator of the quotient of amounts.
        /// </summary>
        [IsoId("_WPPHetp-Ed-ak6NoX_4Aeg_-917310424")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt1")]
        public required RestrictedFINActiveCurrencyAnd13DecimalAmount Amount1 { get; init; }

        /// <summary>
        /// Denominator of the quotient of amounts.
        /// </summary>
        [IsoId("_WPPHe9p-Ed-ak6NoX_4Aeg_1383512166")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt2")]
        public required RestrictedFINActiveCurrencyAnd13DecimalAmount Amount2 { get; init; }
    }
}
