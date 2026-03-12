// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CounterpartyTradeNature7Choice
{
    /// <summary>
    /// Indicates that reporting counterparty is a non financial institution.
    /// </summary>
    [IsoId("_-UtqQ6n9EemdLtwzt4CWxg")]
    [DisplayName("Non Financial Institution")]
    public partial record NonFinancialInstitution : CounterpartyTradeNature7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Classification of the business activities of the reporting counterparty.
        /// </summary>
        [IsoId("_0uXHsbHXEemRPNDOvJwndA")]
        [DisplayName("Classification")]
        [IsoXmlTag("Clssfctn")]
        [IsoSimpleType(IsoSimpleType.NACEDomainIdentifier)]
        public SimpleValueList<System.String> Classification { get; init; } = new SimpleValueList<System.String>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _0uXHsbHXEemRPNDOvJwndA
        
        /// <summary>
        /// Nature business activities of the reporting counterparty as an investment fund.
        /// </summary>
        [IsoId("_0ugRobHXEemRPNDOvJwndA")]
        [DisplayName("Investment Fund Classification")]
        [IsoXmlTag("InvstmtFndClssfctn")]
        public FundType2Code? InvestmentFundClassification { get; init; } 
        
        
        #nullable disable
        
    }
}
