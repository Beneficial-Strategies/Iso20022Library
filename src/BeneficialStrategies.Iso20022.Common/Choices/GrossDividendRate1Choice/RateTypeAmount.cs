// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.GrossDividendRate1Choice
{
    /// <summary>
    /// Value is expressed as an amount related to an underlying securities, eg, underlying security for which an interest is paid.
    /// </summary>
    [IsoId("_UPYvkdp-Ed-ak6NoX_4Aeg_1388251896")]
    [DisplayName("Rate Type Amount")]
    [IsoXmlTag("RateTpAmt")]
    public record RateTypeAmount : GrossDividendRate1Choice_
    {
        /// <summary>
        /// Type of underlying securities to which the rate is related, eg, underlying security for which an interest is paid.
        /// </summary>
        [IsoId("_UPh5hNp-Ed-ak6NoX_4Aeg_1284818087")]
        [DisplayName("Rate Type")]
        [IsoXmlTag("RateTp")]
        public required GrossDividendRateType1FormatChoice_ RateType { get; init; }

        /// <summary>
        /// Value expressed as an amount.
        /// </summary>
        [IsoId("_UPh5hdp-Ed-ak6NoX_4Aeg_1284818088")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAndAmount Amount { get; init; }
    }
}
