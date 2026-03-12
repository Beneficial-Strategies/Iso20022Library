// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InvestmentFundTransactionOutType1Choice
{
    /// <summary>
    /// Transaction type expressed as a code.
    /// </summary>
    [IsoId("_TMto8RMJEeSopak1K45eVQ")]
    [DisplayName("Code")]
    public partial record Code : InvestmentFundTransactionOutType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of investment fund transaction that results in a cash movement out of a fund.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InvestmentFundTransactionOutType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
