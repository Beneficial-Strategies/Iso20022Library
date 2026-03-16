// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat4Choice
{
    /// <summary>
    /// Ratio expressed as a quotient of amounts.
    /// </summary>
    [IsoId("_Q1h319p-Ed-ak6NoX_4Aeg_-1917800920")]
    [DisplayName("Amount To Amount")]
    public record AmountToAmount : RatioFormat4Choice_
    {
        /// <summary>
        /// Numerator of the quotient of amounts.
        /// </summary>
        [IsoId("_UHohytp-Ed-ak6NoX_4Aeg_1560297783")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt1")]
        public required ActiveCurrencyAnd13DecimalAmount Amount1 { get; init; }

        /// <summary>
        /// Denominator of the quotient of amounts.
        /// </summary>
        [IsoId("_UHohy9p-Ed-ak6NoX_4Aeg_1248536401")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt2")]
        public required ActiveCurrencyAnd13DecimalAmount Amount2 { get; init; }
    }
}
