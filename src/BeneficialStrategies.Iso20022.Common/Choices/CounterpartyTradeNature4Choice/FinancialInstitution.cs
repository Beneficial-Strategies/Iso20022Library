// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CounterpartyTradeNature4Choice
{
    /// <summary>
    /// Indicates that reporting counterparty is a financial institution.
    /// </summary>
    [IsoId("_6j9NMbsAEea-m5tPqiasmQ")]
    [DisplayName("Financial Institution")]
    public partial record FinancialInstitution : CounterpartyTradeNature4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the taxonomy type of a financial party.
        /// </summary>
        [IsoXmlTag("FI")]
        public required FinancialPartySectorType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
