// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Party1Choice
{
    /// <summary>
    /// Unique and unambiguous identification of a person, eg, passport.
    /// </summary>
    [IsoId("_Rca4udp-Ed-ak6NoX_4Aeg_-69784778")]
    [DisplayName("Private Identification")]
    public partial record PrivateIdentification : Party1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Number assigned by a license authority to a driver&apos;s license.
        /// </summary>
        [IsoId("_QDwctdp-Ed-ak6NoX_4Aeg_1404901307")]
        [DisplayName("Drivers License Number")]
        [IsoXmlTag("DrvrsLicNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text DriversLicenseNumber { get; init; } 
        
        /// <summary>
        /// Number assigned by a social security agency.
        /// </summary>
        [IsoId("_QD6NoNp-Ed-ak6NoX_4Aeg_1404902315")]
        [DisplayName("Social Security Number")]
        [IsoXmlTag("SclSctyNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text SocialSecurityNumber { get; init; } 
        
        /// <summary>
        /// Number assigned by a government agency to identify foreign nationals.
        /// </summary>
        [IsoId("_QD6Nodp-Ed-ak6NoX_4Aeg_1404902764")]
        [DisplayName("Alien Registration Number")]
        [IsoXmlTag("AlnRegnNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text AlienRegistrationNumber { get; init; } 
        
        /// <summary>
        /// Number assigned by a passport authority to a passport.
        /// </summary>
        [IsoId("_QD6Notp-Ed-ak6NoX_4Aeg_1404903125")]
        [DisplayName("Passport Number")]
        [IsoXmlTag("PsptNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text PassportNumber { get; init; } 
        
        /// <summary>
        /// Number assigned by a tax authority to an entity.
        /// </summary>
        [IsoId("_QD6No9p-Ed-ak6NoX_4Aeg_1404903365")]
        [DisplayName("Tax Identification Number")]
        [IsoXmlTag("TaxIdNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text TaxIdentificationNumber { get; init; } 
        
        /// <summary>
        /// Number assigned by a national authority to an identity card.
        /// </summary>
        [IsoId("_QD6NpNp-Ed-ak6NoX_4Aeg_-1540075051")]
        [DisplayName("Identity Card Number")]
        [IsoXmlTag("IdntyCardNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text IdentityCardNumber { get; init; } 
        
        /// <summary>
        /// Number assigned to an employer by a registration authority.
        /// </summary>
        [IsoId("_QD6Npdp-Ed-ak6NoX_4Aeg_1404903678")]
        [DisplayName("Employer Identification Number")]
        [IsoXmlTag("MplyrIdNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text EmployerIdentificationNumber { get; init; } 
        
        /// <summary>
        /// Identifier issued to a person for which no specific identifier has been defined.
        /// </summary>
        [IsoId("_QD6Nptp-Ed-ak6NoX_4Aeg_-1268666477")]
        [DisplayName("Other Identification")]
        [IsoXmlTag("OthrId")]
        public required GenericIdentification4 OtherIdentification { get; init; } 
        
        /// <summary>
        /// Entity that assigns the identifier.
        /// </summary>
        [IsoId("_QD6Np9p-Ed-ak6NoX_4Aeg_-2082130067")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? Issuer { get; init; } 
        
        
        #nullable disable
        
    }
}
