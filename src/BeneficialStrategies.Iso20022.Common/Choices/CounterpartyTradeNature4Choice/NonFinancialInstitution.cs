// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CounterpartyTradeNature4Choice
{
    /// <summary>
    /// Indicates that reporting counterparty is a non financial institution.
    /// </summary>
    [IsoId("_6j9NM7sAEea-m5tPqiasmQ")]
    [DisplayName("Non Financial Institution")]
    public partial record NonFinancialInstitution : CounterpartyTradeNature4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Taxonomy for non-financial counterparties. The categories correspond to the main sections of NACE classification as defined in the regulation.
        /// </summary>
        [IsoId("_oNJQcIOdEeW2EdhfKzeL1w")]
        [DisplayName("Sector")]
        [IsoXmlTag("Sctr")]
        [IsoSimpleType(IsoSimpleType.NACEDomainIdentifier)]
        public IsoNACEDomainIdentifier? Sector { get; init; } 
        
        /// <summary>
        /// Information whether the reporting counterparty is above the clearing threshold referred to the regulation.
        /// </summary>
        [IsoId("_88jHAfP7EeS_qLctCs2aRQa")]
        [DisplayName("Clearing Threshold")]
        [IsoXmlTag("ClrThrshld")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public required IsoTrueFalseIndicator ClearingThreshold { get; init; } 
        
        /// <summary>
        /// Directly linked to commercial activity or treasury financing: Information on whether the contract is objectively measurable as directly linked to the reporting counterparty&apos;s commercial or treasury financing activity.
        /// </summary>
        [IsoId("_HsMfAIOjEeWqmeP8QNJBew")]
        [DisplayName("Directly Linked Activity")]
        [IsoXmlTag("DrctlyLkdActvty")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public required IsoTrueFalseIndicator DirectlyLinkedActivity { get; init; } 
        
        
        #nullable disable
        
    }
}
