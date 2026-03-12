// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OwnerIdentification3Choice
{
    /// <summary>
    /// Identification of an organisation.
    /// </summary>
    [IsoId("_CKjZs5TREemC09f0MxYkRg")]
    [DisplayName("Organisation Owner Identification")]
    public partial record OrganisationOwnerIdentification : OwnerIdentification3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique identification of the party.
        /// </summary>
        [IsoId("_ceRXo2pTEeipaMTLlhaKMQ")]
        [DisplayName("Party")]
        [IsoXmlTag("Pty")]
        public required PartyIdentification125Choice_ Party { get; init; } 
        
        /// <summary>
        /// Legal entity identification as an alternate identification for the party.
        /// </summary>
        [IsoId("_ceRXpWpTEeipaMTLlhaKMQ")]
        [DisplayName("LEI")]
        [IsoXmlTag("LEI")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public IsoLEIIdentifier? LEI { get; init; } 
        
        
        #nullable disable
        
    }
}
