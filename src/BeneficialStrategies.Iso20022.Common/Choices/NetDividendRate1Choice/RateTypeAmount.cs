// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NetDividendRate1Choice
{
    /// <summary>
    /// Value is expressed as an amount related to an underlying securities, eg, underlying security for which an interest is paid.
    /// </summary>
    [IsoId("_UPh5gtp-Ed-ak6NoX_4Aeg_-398759257")]
    [DisplayName("Rate Type Amount")]
    [IsoXmlTag("RateTpAmt")]
    public record RateTypeAmount : NetDividendRate1Choice_
    {
        /// <summary>
        /// Type of underlying securities to which the rate is related, eg, underlying security for which an interest is paid.
        /// </summary>
        [IsoId("_UPrqgdp-Ed-ak6NoX_4Aeg_-2120201442")]
        [DisplayName("Rate Type")]
        [IsoXmlTag("RateTp")]
        public required NetDividendRateType1FormatChoice_ RateType { get; init; }

        /// <summary>
        /// Value expressed as an amount.
        /// </summary>
        [IsoId("_UPrqgtp-Ed-ak6NoX_4Aeg_-2120201411")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAndAmount Amount { get; init; }
    }
}
