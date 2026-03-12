// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous way to identify a person.
/// </summary>
[IsoId("_QED-o9p-Ed-ak6NoX_4Aeg_-1604713297")]
[DisplayName("Person Identification")]
public partial record PersonIdentification3
{
    #nullable enable
    
    /// <summary>
    /// Number assigned by a license authority to a driver&apos;s license.
    /// </summary>
    [IsoId("_QED-pNp-Ed-ak6NoX_4Aeg_-1604713254")]
    [DisplayName("Drivers License Number")]
    [IsoXmlTag("DrvrsLicNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text DriversLicenseNumber { get; init; } 
    
    /// <summary>
    /// Number assigned by an agent to identify its customer.
    /// </summary>
    [IsoId("_QED-pdp-Ed-ak6NoX_4Aeg_140421516")]
    [DisplayName("Customer Number")]
    [IsoXmlTag("CstmrNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text CustomerNumber { get; init; } 
    
    /// <summary>
    /// Number assigned by a social security agency.
    /// </summary>
    [IsoId("_QED-ptp-Ed-ak6NoX_4Aeg_-1604712929")]
    [DisplayName("Social Security Number")]
    [IsoXmlTag("SclSctyNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text SocialSecurityNumber { get; init; } 
    
    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// </summary>
    [IsoId("_QED-p9p-Ed-ak6NoX_4Aeg_-1604712869")]
    [DisplayName("Alien Registration Number")]
    [IsoXmlTag("AlnRegnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text AlienRegistrationNumber { get; init; } 
    
    /// <summary>
    /// Number assigned by a passport authority to a passport.
    /// </summary>
    [IsoId("_QED-qNp-Ed-ak6NoX_4Aeg_-1604712809")]
    [DisplayName("Passport Number")]
    [IsoXmlTag("PsptNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text PassportNumber { get; init; } 
    
    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// </summary>
    [IsoId("_QED-qdp-Ed-ak6NoX_4Aeg_-1604712757")]
    [DisplayName("Tax Identification Number")]
    [IsoXmlTag("TaxIdNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TaxIdentificationNumber { get; init; } 
    
    /// <summary>
    /// Number assigned by a national authority to an identity card.
    /// </summary>
    [IsoId("_QED-qtp-Ed-ak6NoX_4Aeg_-1604712462")]
    [DisplayName("Identity Card Number")]
    [IsoXmlTag("IdntyCardNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text IdentityCardNumber { get; init; } 
    
    /// <summary>
    /// Number assigned to an employer by a registration authority.
    /// </summary>
    [IsoId("_QED-q9p-Ed-ak6NoX_4Aeg_-1604712402")]
    [DisplayName("Employer Identification Number")]
    [IsoXmlTag("MplyrIdNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text EmployerIdentificationNumber { get; init; } 
    
    /// <summary>
    /// Date and place of birth of a person.
    /// </summary>
    [IsoId("_QENIkNp-Ed-ak6NoX_4Aeg_-1597135816")]
    [DisplayName("Date And Place Of Birth")]
    [IsoXmlTag("DtAndPlcOfBirth")]
    public required DateAndPlaceOfBirth DateAndPlaceOfBirth { get; init; } 
    
    /// <summary>
    /// Identifier issued to a person for which no specific identifier has been defined.
    /// </summary>
    [IsoId("_QENIkdp-Ed-ak6NoX_4Aeg_-1604711972")]
    [DisplayName("Other Identification")]
    [IsoXmlTag("OthrId")]
    public required GenericIdentification4 OtherIdentification { get; init; } 
    
    /// <summary>
    /// Entity that assigns the identifier.
    /// </summary>
    [IsoId("_QENIktp-Ed-ak6NoX_4Aeg_-495106709")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; } 
    
    
    #nullable disable
    
}
