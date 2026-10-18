// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party2Choice
{
    /// <inheritdoc cref="IOrganisationIdentification"/>
    [IsoId("_RCDQ4dp-Ed-ak6NoX_4Aeg_-1691234013")]
    [DisplayName("Organisation Identification")]
    [IsoXmlTag("OrgId")]
    public partial record OrganisationIdentification : Party2Choice_
    {
        /// <inheritdoc cref="IOrganisationIdentification.BIC"/>
        [IsoId("_QQa_pdp-Ed-ak6NoX_4Aeg_-916094981")]
        [DisplayName("BIC")]
        [IsoXmlTag("BIC")]
        [IsoSimpleType(IsoSimpleType.BICIdentifier)]
        public IsoBICIdentifier? BIC { get; init; }

        /// <inheritdoc cref="IOrganisationIdentification.IBEI"/>
        [IsoId("_QQa_ptp-Ed-ak6NoX_4Aeg_-857912325")]
        [DisplayName("IBEI")]
        [IsoXmlTag("IBEI")]
        [IsoSimpleType(IsoSimpleType.IBEIIdentifier)]
        public IsoIBEIIdentifier? IBEI { get; init; }

        /// <inheritdoc cref="IOrganisationIdentification.BEI"/>
        [IsoId("_QQa_p9p-Ed-ak6NoX_4Aeg_-987206748")]
        [DisplayName("BEI")]
        [IsoXmlTag("BEI")]
        [IsoSimpleType(IsoSimpleType.BEIIdentifier)]
        public IsoBEIIdentifier? BEI { get; init; }

        /// <inheritdoc cref="IOrganisationIdentification.EANGLN"/>
        [IsoId("_QQa_qNp-Ed-ak6NoX_4Aeg_-987206671")]
        [DisplayName("EANGLN")]
        [IsoXmlTag("EANGLN")]
        [IsoSimpleType(IsoSimpleType.EANGLNIdentifier)]
        public IsoEANGLNIdentifier? EANGLN { get; init; }

        /// <inheritdoc cref="IOrganisationIdentification.CHIPSUniversalIdentification"/>
        [IsoId("_QQkwoNp-Ed-ak6NoX_4Aeg_-987206611")]
        [DisplayName("CHIPS Universal Identification")]
        [IsoXmlTag("USCHU")]
        [IsoSimpleType(IsoSimpleType.CHIPSUniversalIdentifier)]
        public IsoCHIPSUniversalIdentifier? CHIPSUniversalIdentification { get; init; }

        /// <inheritdoc cref="IOrganisationIdentification.DUNS"/>
        [IsoId("_QQkwodp-Ed-ak6NoX_4Aeg_-987206285")]
        [DisplayName("DUNS")]
        [IsoXmlTag("DUNS")]
        [IsoSimpleType(IsoSimpleType.DunsIdentifier)]
        public IsoDunsIdentifier? DUNS { get; init; }

        /// <inheritdoc cref="IOrganisationIdentification.BankPartyIdentification"/>
        [IsoId("_QQkwotp-Ed-ak6NoX_4Aeg_-987206225")]
        [DisplayName("Bank Party Identification")]
        [IsoXmlTag("BkPtyId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? BankPartyIdentification { get; init; }

        /// <inheritdoc cref="IOrganisationIdentification.TaxIdentificationNumber"/>
        [IsoId("_QQkwo9p-Ed-ak6NoX_4Aeg_-987206148")]
        [DisplayName("Tax Identification Number")]
        [IsoXmlTag("TaxIdNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? TaxIdentificationNumber { get; init; }

        /// <inheritdoc cref="IOrganisationIdentification.ProprietaryIdentification"/>
        [IsoId("_QQkwpNp-Ed-ak6NoX_4Aeg_-987206069")]
        [DisplayName("Proprietary Identification")]
        [IsoXmlTag("PrtryId")]
        public GenericIdentification3? ProprietaryIdentification { get; init; }
    }
}
