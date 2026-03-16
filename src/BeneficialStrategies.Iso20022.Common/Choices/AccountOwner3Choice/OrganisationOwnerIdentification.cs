// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountOwner3Choice
{
    /// <summary>
    /// Identification of the organisation that legally owns the account.
    /// </summary>
    [IsoId("_6hURE5TIEemqYPWMBuVawg")]
    [DisplayName("Organisation Owner Identification")]
    [IsoXmlTag("OrgOwnrId")]
    public record OrganisationOwnerIdentification : AccountOwner3Choice_
    {
        /// <summary>
        /// Identification of the organisation.
        /// </summary>
        [IsoId("_AhTdk5TJEemqYPWMBuVawg")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public PartyIdentification182Choice_? Identification { get; init; }

        /// <summary>
        /// Identification of the organisation with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
        /// </summary>
        [IsoId("_AhTdlZTJEemqYPWMBuVawg")]
        [DisplayName("Legal Entity Identifier")]
        [IsoXmlTag("LglNttyIdr")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public IsoLEIIdentifier? LegalEntityIdentifier { get; init; }
    }
}
