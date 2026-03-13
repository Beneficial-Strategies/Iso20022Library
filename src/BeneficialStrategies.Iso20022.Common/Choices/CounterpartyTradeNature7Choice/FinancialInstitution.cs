// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CounterpartyTradeNature7Choice
{
    /// <summary>
    /// Indicates that reporting counterparty is a financial institution.
    /// </summary>
    [IsoId("_-UtqQan9EemdLtwzt4CWxg")]
    [DisplayName("Financial Institution")]
    public partial record FinancialInstitution : CounterpartyTradeNature7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Classification of the business activities of the reporting counterparty.
        /// </summary>
        [IsoId("_1VoPYan9EemdLtwzt4CWxg")]
        [DisplayName("Classification")]
        [IsoXmlTag("Clssfctn")]
        public SimpleValueList<FinancialPartySectorType2Code> Classification { get; init; } = [];
        // ID for the above is _1VoPYan9EemdLtwzt4CWxg
        
        /// <summary>
        /// Nature business activities of the reporting counterparty as an investment fund.
        /// </summary>
        [IsoId("_1VoPY6n9EemdLtwzt4CWxg")]
        [DisplayName("Investment Fund Classification")]
        [IsoXmlTag("InvstmtFndClssfctn")]
        public FundType2Code? InvestmentFundClassification { get; init; } 
        
        
        #nullable disable
        
    }
}
