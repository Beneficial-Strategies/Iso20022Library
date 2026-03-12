// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of unique and unambiguous ways to identify a person.
/// </summary>
[IsoId("_rpSyYeWjEeevU7McUP3D1w")]
[DisplayName("Person Identification")]
public partial record PersonIdentification15
{
    #nullable enable
    
    /// <summary>
    /// Number assigned by a license authority to a driver&apos;s license.
    /// </summary>
    [IsoId("_ryM2w-WjEeevU7McUP3D1w")]
    [DisplayName("Driver License Number")]
    [IsoXmlTag("DrvrLicNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? DriverLicenseNumber { get; init; } 
    
    /// <summary>
    /// Country, state or province, issuer of the driver license.
    /// </summary>
    [IsoId("_ryM2xeWjEeevU7McUP3D1w")]
    [DisplayName("Driver License Location")]
    [IsoXmlTag("DrvrLicLctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? DriverLicenseLocation { get; init; } 
    
    /// <summary>
    /// Name or title of the driver license.
    /// </summary>
    [IsoId("_ryM2x-WjEeevU7McUP3D1w")]
    [DisplayName("Driver License Name")]
    [IsoXmlTag("DrvrLicNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? DriverLicenseName { get; init; } 
    
    /// <summary>
    /// Identification of the driver in the fleet of vehicle.
    /// </summary>
    [IsoId("_ryM2yeWjEeevU7McUP3D1w")]
    [DisplayName("Driver Identification")]
    [IsoXmlTag("DrvrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? DriverIdentification { get; init; } 
    
    /// <summary>
    /// Number assigned by an agent to identify its customer.
    /// </summary>
    [IsoId("_ryM2y-WjEeevU7McUP3D1w")]
    [DisplayName("Customer Number")]
    [IsoXmlTag("CstmrNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CustomerNumber { get; init; } 
    
    /// <summary>
    /// Number assigned by a social security agency.
    /// </summary>
    [IsoId("_ryM2zeWjEeevU7McUP3D1w")]
    [DisplayName("Social Security Number")]
    [IsoXmlTag("SclSctyNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SocialSecurityNumber { get; init; } 
    
    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// </summary>
    [IsoId("_ryM2z-WjEeevU7McUP3D1w")]
    [DisplayName("Alien Registration Number")]
    [IsoXmlTag("AlnRegnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AlienRegistrationNumber { get; init; } 
    
    /// <summary>
    /// Number assigned by a passport authority to a passport.
    /// </summary>
    [IsoId("_ryM20eWjEeevU7McUP3D1w")]
    [DisplayName("Passport Number")]
    [IsoXmlTag("PsptNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PassportNumber { get; init; } 
    
    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// </summary>
    [IsoId("_ryM20-WjEeevU7McUP3D1w")]
    [DisplayName("Tax Identification Number")]
    [IsoXmlTag("TaxIdNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TaxIdentificationNumber { get; init; } 
    
    /// <summary>
    /// Number assigned by a national authority to an identity card.
    /// </summary>
    [IsoId("_ryM21eWjEeevU7McUP3D1w")]
    [DisplayName("Identity Card Number")]
    [IsoXmlTag("IdntyCardNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? IdentityCardNumber { get; init; } 
    
    /// <summary>
    /// Number assigned to an employer by a registration authority.
    /// </summary>
    [IsoId("_ryM21-WjEeevU7McUP3D1w")]
    [DisplayName("Employer Identification Number")]
    [IsoXmlTag("MplyrIdNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? EmployerIdentificationNumber { get; init; } 
    
    /// <summary>
    /// Number assigned to an employee by a employer.
    /// </summary>
    [IsoId("_ryM22eWjEeevU7McUP3D1w")]
    [DisplayName("Employee Identification Number")]
    [IsoXmlTag("MplyeeIdNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? EmployeeIdentificationNumber { get; init; } 
    
    /// <summary>
    /// Identification of the job.
    /// </summary>
    [IsoId("_ryM22-WjEeevU7McUP3D1w")]
    [DisplayName("Job Number")]
    [IsoXmlTag("JobNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? JobNumber { get; init; } 
    
    /// <summary>
    /// Identification of the department.
    /// </summary>
    [IsoId("_ryM23eWjEeevU7McUP3D1w")]
    [DisplayName("Department")]
    [IsoXmlTag("Dept")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Department { get; init; } 
    
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_ryM23-WjEeevU7McUP3D1w")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? EmailAddress { get; init; } 
    
    /// <summary>
    /// Date and place of birth of a person.
    /// </summary>
    [IsoId("_ryM24eWjEeevU7McUP3D1w")]
    [DisplayName("Date And Place Of Birth")]
    [IsoXmlTag("DtAndPlcOfBirth")]
    public DateAndPlaceOfBirth1? DateAndPlaceOfBirth { get; init; } 
    
    /// <summary>
    /// Unique identification of a person, as assigned by an institution, using an identification scheme.
    /// </summary>
    [IsoId("_ryM24-WjEeevU7McUP3D1w")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public GenericIdentification4? Other { get; init; } 
    
    
    #nullable disable
    
}
