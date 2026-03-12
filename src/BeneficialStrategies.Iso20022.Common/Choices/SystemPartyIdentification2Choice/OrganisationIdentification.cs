// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SystemPartyIdentification2Choice
{
    /// <summary>
    /// Provides the identification of a party.
    /// </summary>
    [IsoId("_w8OZgWc-EemvNLufWGIVOQ")]
    [DisplayName("Organisation Identification")]
    public partial record OrganisationIdentification : SystemPartyIdentification2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique identification of the party.
        /// </summary>
        [IsoId("_VulSIbpYEeifFaUMRKyMMw")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public required PartyIdentification120Choice_ Identification { get; init; } 
        
        /// <summary>
        /// Legal entity identification as an alternate identification for a party.
        /// </summary>
        [IsoId("_VulSI7pYEeifFaUMRKyMMw")]
        [DisplayName("LEI")]
        [IsoXmlTag("LEI")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public IsoLEIIdentifier? LEI { get; init; } 
        
        
        #nullable disable
        
    }
}
