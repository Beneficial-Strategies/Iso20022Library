// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party2Choice
{
    /// <inheritdoc cref="IPrivateIdentification"/>
    [IsoId("_RCDQ4tp-Ed-ak6NoX_4Aeg_-1657924072")]
    [DisplayName("Private Identification")]
    [IsoXmlTag("PrvtId")]
    public partial record PrivateIdentification : Party2Choice_
    {
        /// <inheritdoc cref="IPrivateIdentification.DriversLicenseNumber"/>
        [IsoId("_QED-pNp-Ed-ak6NoX_4Aeg_-1604713254")]
        [DisplayName("Drivers License Number")]
        [IsoXmlTag("DrvrsLicNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text DriversLicenseNumber { get; init; }

        /// <inheritdoc cref="IPrivateIdentification.CustomerNumber"/>
        [IsoId("_QED-pdp-Ed-ak6NoX_4Aeg_140421516")]
        [DisplayName("Customer Number")]
        [IsoXmlTag("CstmrNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text CustomerNumber { get; init; }

        /// <inheritdoc cref="IPrivateIdentification.SocialSecurityNumber"/>
        [IsoId("_QED-ptp-Ed-ak6NoX_4Aeg_-1604712929")]
        [DisplayName("Social Security Number")]
        [IsoXmlTag("SclSctyNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text SocialSecurityNumber { get; init; }

        /// <inheritdoc cref="IPrivateIdentification.AlienRegistrationNumber"/>
        [IsoId("_QED-p9p-Ed-ak6NoX_4Aeg_-1604712869")]
        [DisplayName("Alien Registration Number")]
        [IsoXmlTag("AlnRegnNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text AlienRegistrationNumber { get; init; }

        /// <inheritdoc cref="IPrivateIdentification.PassportNumber"/>
        [IsoId("_QED-qNp-Ed-ak6NoX_4Aeg_-1604712809")]
        [DisplayName("Passport Number")]
        [IsoXmlTag("PsptNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text PassportNumber { get; init; }

        /// <inheritdoc cref="IPrivateIdentification.TaxIdentificationNumber"/>
        [IsoId("_QED-qdp-Ed-ak6NoX_4Aeg_-1604712757")]
        [DisplayName("Tax Identification Number")]
        [IsoXmlTag("TaxIdNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text TaxIdentificationNumber { get; init; }

        /// <inheritdoc cref="IPrivateIdentification.IdentityCardNumber"/>
        [IsoId("_QED-qtp-Ed-ak6NoX_4Aeg_-1604712462")]
        [DisplayName("Identity Card Number")]
        [IsoXmlTag("IdntyCardNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text IdentityCardNumber { get; init; }

        /// <inheritdoc cref="IPrivateIdentification.EmployerIdentificationNumber"/>
        [IsoId("_QED-q9p-Ed-ak6NoX_4Aeg_-1604712402")]
        [DisplayName("Employer Identification Number")]
        [IsoXmlTag("MplyrIdNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text EmployerIdentificationNumber { get; init; }

        /// <inheritdoc cref="IPrivateIdentification.DateAndPlaceOfBirth"/>
        [IsoId("_QENIkNp-Ed-ak6NoX_4Aeg_-1597135816")]
        [DisplayName("Date And Place Of Birth")]
        [IsoXmlTag("DtAndPlcOfBirth")]
        public required DateAndPlaceOfBirth DateAndPlaceOfBirth { get; init; }

        /// <inheritdoc cref="IPrivateIdentification.OtherIdentification"/>
        [IsoId("_QENIkdp-Ed-ak6NoX_4Aeg_-1604711972")]
        [DisplayName("Other Identification")]
        [IsoXmlTag("OthrId")]
        public required GenericIdentification4 OtherIdentification { get; init; }

        /// <inheritdoc cref="IPrivateIdentification.Issuer"/>
        [IsoId("_QENIktp-Ed-ak6NoX_4Aeg_-495106709")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Issuer { get; init; }
    }
}
