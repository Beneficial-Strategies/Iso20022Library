// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party49Choice
{
    /// <summary>
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    [IsoId("_dbeBY-EpEemRzcIkmUETeA")]
    [DisplayName("Organisation Identification")]
    [IsoXmlTag("OrgId")]
    public record OrganisationIdentification : Party49Choice_
    {
        /// <summary>
        /// Business identification code of the organisation.
        /// </summary>
        [IsoId("_gSyz0-EpEemRzcIkmUETeA")]
        [DisplayName("Any BIC")]
        [IsoXmlTag("AnyBIC")]
        [IsoSimpleType(IsoSimpleType.AnyBICDec2014Identifier)]
        public IsoAnyBICDec2014Identifier? AnyBIC { get; init; }

        /// <summary>
        /// Legal entity identification as an alternate identification for a party.
        /// </summary>
        [IsoId("_gSyz1eEpEemRzcIkmUETeA")]
        [DisplayName("LEI")]
        [IsoXmlTag("LEI")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public IsoLEIIdentifier? LEI { get; init; }

        /// <summary>
        /// Address for electronic mail (e-mail).
        /// </summary>
        [IsoId("_hfVfceEpEemRzcIkmUETeA")]
        [DisplayName("Email Address")]
        [IsoXmlTag("EmailAdr")]
        [IsoSimpleType(IsoSimpleType.Max256Text)]
        [StringLength(maximumLength: 256, MinimumLength = 1)]
        public IsoMax256Text? EmailAddress { get; init; }

        /// <summary>
        /// Unique identification of an organisation, as assigned by an institution, using an identification scheme.
        /// </summary>
        [IsoId("_gSyz1-EpEemRzcIkmUETeA")]
        [DisplayName("Other")]
        [IsoXmlTag("Othr")]
        public GenericOrganisationIdentification1? Other { get; init; }
    }
}
