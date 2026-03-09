// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.CounterpartyTradeNature7Choice
{
    /// <summary>
    /// Indicates that reporting counterparty is a non financial institution.
    /// </summary>
    [IsoId("_-UtqQ6n9EemdLtwzt4CWxg")]
    [DisplayName("Non Financial Institution")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record NonFinancialInstitution : CounterpartyTradeNature7Choice_
    #else
    public partial class NonFinancialInstitution : CounterpartyTradeNature7Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Classification of the business activities of the reporting counterparty.
        /// </summary>
        [IsoId("_0uXHsbHXEemRPNDOvJwndA")]
        [DisplayName("Classification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Clssfctn")]
        #endif
        [IsoXmlTag("Clssfctn")]
        [IsoSimpleType(IsoSimpleType.NACEDomainIdentifier)]
        public SimpleValueList<System.String> Classification { get; init; } = new SimpleValueList<System.String>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _0uXHsbHXEemRPNDOvJwndA
        
        /// <summary>
        /// Nature business activities of the reporting counterparty as an investment fund.
        /// </summary>
        [IsoId("_0ugRobHXEemRPNDOvJwndA")]
        [DisplayName("Investment Fund Classification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="InvstmtFndClssfctn")]
        #endif
        [IsoXmlTag("InvstmtFndClssfctn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FundType2Code? InvestmentFundClassification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FundType2Code? InvestmentFundClassification { get; init; } 
        #else
        public FundType2Code? InvestmentFundClassification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
