// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party8Choice
{
    /// <summary>
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    [IsoId("_PXDusNp-Ed-ak6NoX_4Aeg_-1912923115")]
    [DisplayName("Organisation Identification")]
    [IsoXmlTag("OrgId")]
    public record OrganisationIdentification : Party8Choice_
    {
        /// <summary>
        /// Code allocated to organisations by the ISO 9362 Registration Authority, under an international identification scheme, as described in the latest version of the standard ISO 9362 Banking (Banking telecommunication messages, Business Identifier Codes).
        /// </summary>
        [IsoId("_QPrYx9p-Ed-ak6NoX_4Aeg_320818611")]
        [DisplayName("BIC")]
        [IsoXmlTag("BIC")]
        [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
        public IsoAnyBICIdentifier? BIC { get; init; }

        /// <summary>
        /// Unique identification of an organisation, as assigned by an institution, using an identification scheme.
        /// </summary>
        [IsoId("_QPrYyNp-Ed-ak6NoX_4Aeg_-676253742")]
        [DisplayName("Other")]
        [IsoXmlTag("Othr")]
        public GenericOrganisationIdentification1? Other { get; init; }
    }
}
