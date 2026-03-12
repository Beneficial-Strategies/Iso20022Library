// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ReconciliationMatchedStatus9Choice
{
    /// <summary>
    /// Indication that the reports subject of reconciliation do not match.
    /// </summary>
    [IsoId("_AxRVQ8K3EeuFNp8LZAnorg")]
    [DisplayName("Not Matched")]
    public partial record NotMatched : ReconciliationMatchedStatus9Choice_
    {
        #nullable enable
        
        /// <summary>
        /// First side of the contract that needs to be matched.
        /// </summary>
        [IsoId("_Ays4ocK3EeuFNp8LZAnorg")]
        [DisplayName("Counterparty")]
        [IsoXmlTag("CtrPty1")]
        public required OrganisationIdentification15Choice_ Counterparty1 { get; init; } 
        
        /// <summary>
        /// Second side of the contract that needs to be matched.
        /// </summary>
        [IsoId("_Ays4o8K3EeuFNp8LZAnorg")]
        [DisplayName("Counterparty")]
        [IsoXmlTag("CtrPty2")]
        public required OrganisationIdentification15Choice_ Counterparty2 { get; init; } 
        
        /// <summary>
        /// Criteria used to match the sides of the contract.
        /// </summary>
        [IsoId("_Ays4pcK3EeuFNp8LZAnorg")]
        [DisplayName("Matching Criteria")]
        [IsoXmlTag("MtchgCrit")]
        public required MatchingCriteria10 MatchingCriteria { get; init; } 
        
        
        #nullable disable
        
    }
}
