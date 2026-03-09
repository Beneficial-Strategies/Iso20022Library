// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of unique and unambiguous ways to identify a person.
/// </summary>
[IsoId("_rpSyYeWjEeevU7McUP3D1w")]
[DisplayName("Person Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PersonIdentification15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Number assigned by a license authority to a driver&apos;s license.
    /// </summary>
    [IsoId("_ryM2w-WjEeevU7McUP3D1w")]
    [DisplayName("Driver License Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrvrLicNb")]
    #endif
    [IsoXmlTag("DrvrLicNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DriverLicenseNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DriverLicenseNumber { get; init; } 
    #else
    public System.String? DriverLicenseNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Country, state or province, issuer of the driver license.
    /// </summary>
    [IsoId("_ryM2xeWjEeevU7McUP3D1w")]
    [DisplayName("Driver License Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrvrLicLctn")]
    #endif
    [IsoXmlTag("DrvrLicLctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DriverLicenseLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DriverLicenseLocation { get; init; } 
    #else
    public System.String? DriverLicenseLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Name or title of the driver license.
    /// </summary>
    [IsoId("_ryM2x-WjEeevU7McUP3D1w")]
    [DisplayName("Driver License Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrvrLicNm")]
    #endif
    [IsoXmlTag("DrvrLicNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DriverLicenseName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DriverLicenseName { get; init; } 
    #else
    public System.String? DriverLicenseName { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the driver in the fleet of vehicle.
    /// </summary>
    [IsoId("_ryM2yeWjEeevU7McUP3D1w")]
    [DisplayName("Driver Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrvrId")]
    #endif
    [IsoXmlTag("DrvrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DriverIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DriverIdentification { get; init; } 
    #else
    public System.String? DriverIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Number assigned by an agent to identify its customer.
    /// </summary>
    [IsoId("_ryM2y-WjEeevU7McUP3D1w")]
    [DisplayName("Customer Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrNb")]
    #endif
    [IsoXmlTag("CstmrNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CustomerNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CustomerNumber { get; init; } 
    #else
    public System.String? CustomerNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number assigned by a social security agency.
    /// </summary>
    [IsoId("_ryM2zeWjEeevU7McUP3D1w")]
    [DisplayName("Social Security Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SclSctyNb")]
    #endif
    [IsoXmlTag("SclSctyNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SocialSecurityNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SocialSecurityNumber { get; init; } 
    #else
    public System.String? SocialSecurityNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// </summary>
    [IsoId("_ryM2z-WjEeevU7McUP3D1w")]
    [DisplayName("Alien Registration Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AlnRegnNb")]
    #endif
    [IsoXmlTag("AlnRegnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AlienRegistrationNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AlienRegistrationNumber { get; init; } 
    #else
    public System.String? AlienRegistrationNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number assigned by a passport authority to a passport.
    /// </summary>
    [IsoId("_ryM20eWjEeevU7McUP3D1w")]
    [DisplayName("Passport Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PsptNb")]
    #endif
    [IsoXmlTag("PsptNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PassportNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PassportNumber { get; init; } 
    #else
    public System.String? PassportNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// </summary>
    [IsoId("_ryM20-WjEeevU7McUP3D1w")]
    [DisplayName("Tax Identification Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxIdNb")]
    #endif
    [IsoXmlTag("TaxIdNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TaxIdentificationNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TaxIdentificationNumber { get; init; } 
    #else
    public System.String? TaxIdentificationNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number assigned by a national authority to an identity card.
    /// </summary>
    [IsoId("_ryM21eWjEeevU7McUP3D1w")]
    [DisplayName("Identity Card Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IdntyCardNb")]
    #endif
    [IsoXmlTag("IdntyCardNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? IdentityCardNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IdentityCardNumber { get; init; } 
    #else
    public System.String? IdentityCardNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number assigned to an employer by a registration authority.
    /// </summary>
    [IsoId("_ryM21-WjEeevU7McUP3D1w")]
    [DisplayName("Employer Identification Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MplyrIdNb")]
    #endif
    [IsoXmlTag("MplyrIdNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? EmployerIdentificationNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EmployerIdentificationNumber { get; init; } 
    #else
    public System.String? EmployerIdentificationNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number assigned to an employee by a employer.
    /// </summary>
    [IsoId("_ryM22eWjEeevU7McUP3D1w")]
    [DisplayName("Employee Identification Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MplyeeIdNb")]
    #endif
    [IsoXmlTag("MplyeeIdNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? EmployeeIdentificationNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EmployeeIdentificationNumber { get; init; } 
    #else
    public System.String? EmployeeIdentificationNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the job.
    /// </summary>
    [IsoId("_ryM22-WjEeevU7McUP3D1w")]
    [DisplayName("Job Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="JobNb")]
    #endif
    [IsoXmlTag("JobNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? JobNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? JobNumber { get; init; } 
    #else
    public System.String? JobNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the department.
    /// </summary>
    [IsoId("_ryM23eWjEeevU7McUP3D1w")]
    [DisplayName("Department")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dept")]
    #endif
    [IsoXmlTag("Dept")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Department { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Department { get; init; } 
    #else
    public System.String? Department { get; set; } 
    #endif
    
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_ryM23-WjEeevU7McUP3D1w")]
    [DisplayName("Email Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EmailAdr")]
    #endif
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? EmailAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EmailAddress { get; init; } 
    #else
    public System.String? EmailAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Date and place of birth of a person.
    /// </summary>
    [IsoId("_ryM24eWjEeevU7McUP3D1w")]
    [DisplayName("Date And Place Of Birth")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtAndPlcOfBirth")]
    #endif
    [IsoXmlTag("DtAndPlcOfBirth")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndPlaceOfBirth1? DateAndPlaceOfBirth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndPlaceOfBirth1? DateAndPlaceOfBirth { get; init; } 
    #else
    public DateAndPlaceOfBirth1? DateAndPlaceOfBirth { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of a person, as assigned by an institution, using an identification scheme.
    /// </summary>
    [IsoId("_ryM24-WjEeevU7McUP3D1w")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification4? Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification4? Other { get; init; } 
    #else
    public GenericIdentification4? Other { get; set; } 
    #endif
    
    
    #nullable disable
    
}
