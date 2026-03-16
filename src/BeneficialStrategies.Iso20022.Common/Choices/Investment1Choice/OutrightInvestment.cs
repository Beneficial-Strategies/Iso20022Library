// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Investment1Choice
{
    /// <summary>
    /// Indicates that the investment was an outright purchase of a financial instrument or security as an investment.
    /// </summary>
    [IsoId("_0_ysALLnEeavNMum-T1eEA")]
    [DisplayName("Outright Investment")]
    public record OutrightInvestment : Investment1Choice_
    {
        /// <summary>
        /// ISIN of the outright investment.
        /// </summary>
        [IsoId("_RK0CoK_7EeaE9YROwd69hA")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
        public required IsoISINOct2015Identifier Identification { get; init; }

        /// <summary>
        /// Value of the outright investment according to the CCP’s system of record.
        /// </summary>
        [IsoId("_ULeXQK_7EeaE9YROwd69hA")]
        [DisplayName("Market Value")]
        [IsoXmlTag("MktVal")]
        public required ActiveCurrencyAnd24Amount MarketValue { get; init; }

        /// <summary>
        /// Type of a financial instrument: an equity, bond or other.
        /// </summary>
        [IsoId("_kn10ADXsEemdWfjs3tykFQ")]
        [DisplayName("Financial Instrument Type")]
        [IsoXmlTag("FinInstrmTp")]
        public required ProductType7Code FinancialInstrumentType { get; init; }
    }
}
