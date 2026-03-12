// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AssetHolding1Choice
{
    /// <summary>
    /// Identification and value of the outright investment.
    /// </summary>
    [IsoId("_GHPngK_7EeaE9YROwd69hA")]
    [DisplayName("Security")]
    public partial record Security : AssetHolding1Choice_
    {
        #nullable enable
        
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
        
        
        #nullable disable
        
    }
}
