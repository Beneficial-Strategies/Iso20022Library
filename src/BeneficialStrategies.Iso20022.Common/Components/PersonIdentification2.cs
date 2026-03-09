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
/// Unique and unambiguous way to identify a person.
/// </summary>
[IsoId("_QDwctNp-Ed-ak6NoX_4Aeg_-1972067649")]
[DisplayName("Person Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PersonIdentification2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PersonIdentification2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PersonIdentification2( System.String reqDriversLicenseNumber,System.String reqSocialSecurityNumber,System.String reqAlienRegistrationNumber,System.String reqPassportNumber,System.String reqTaxIdentificationNumber,System.String reqIdentityCardNumber,System.String reqEmployerIdentificationNumber,GenericIdentification4 reqOtherIdentification )
    {
        DriversLicenseNumber = reqDriversLicenseNumber;
        SocialSecurityNumber = reqSocialSecurityNumber;
        AlienRegistrationNumber = reqAlienRegistrationNumber;
        PassportNumber = reqPassportNumber;
        TaxIdentificationNumber = reqTaxIdentificationNumber;
        IdentityCardNumber = reqIdentityCardNumber;
        EmployerIdentificationNumber = reqEmployerIdentificationNumber;
        OtherIdentification = reqOtherIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number assigned by a license authority to a driver&apos;s license.
    /// </summary>
    [IsoId("_QDwctdp-Ed-ak6NoX_4Aeg_1404901307")]
    [DisplayName("Drivers License Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrvrsLicNb")]
    #endif
    [IsoXmlTag("DrvrsLicNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text DriversLicenseNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DriversLicenseNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DriversLicenseNumber { get; init; } 
    #else
    public System.String DriversLicenseNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number assigned by a social security agency.
    /// </summary>
    [IsoId("_QD6NoNp-Ed-ak6NoX_4Aeg_1404902315")]
    [DisplayName("Social Security Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SclSctyNb")]
    #endif
    [IsoXmlTag("SclSctyNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text SocialSecurityNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SocialSecurityNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SocialSecurityNumber { get; init; } 
    #else
    public System.String SocialSecurityNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// </summary>
    [IsoId("_QD6Nodp-Ed-ak6NoX_4Aeg_1404902764")]
    [DisplayName("Alien Registration Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AlnRegnNb")]
    #endif
    [IsoXmlTag("AlnRegnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text AlienRegistrationNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AlienRegistrationNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AlienRegistrationNumber { get; init; } 
    #else
    public System.String AlienRegistrationNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number assigned by a passport authority to a passport.
    /// </summary>
    [IsoId("_QD6Notp-Ed-ak6NoX_4Aeg_1404903125")]
    [DisplayName("Passport Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PsptNb")]
    #endif
    [IsoXmlTag("PsptNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text PassportNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PassportNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PassportNumber { get; init; } 
    #else
    public System.String PassportNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// </summary>
    [IsoId("_QD6No9p-Ed-ak6NoX_4Aeg_1404903365")]
    [DisplayName("Tax Identification Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxIdNb")]
    #endif
    [IsoXmlTag("TaxIdNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TaxIdentificationNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TaxIdentificationNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TaxIdentificationNumber { get; init; } 
    #else
    public System.String TaxIdentificationNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number assigned by a national authority to an identity card.
    /// </summary>
    [IsoId("_QD6NpNp-Ed-ak6NoX_4Aeg_-1540075051")]
    [DisplayName("Identity Card Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IdntyCardNb")]
    #endif
    [IsoXmlTag("IdntyCardNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text IdentityCardNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String IdentityCardNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String IdentityCardNumber { get; init; } 
    #else
    public System.String IdentityCardNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number assigned to an employer by a registration authority.
    /// </summary>
    [IsoId("_QD6Npdp-Ed-ak6NoX_4Aeg_1404903678")]
    [DisplayName("Employer Identification Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MplyrIdNb")]
    #endif
    [IsoXmlTag("MplyrIdNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text EmployerIdentificationNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String EmployerIdentificationNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String EmployerIdentificationNumber { get; init; } 
    #else
    public System.String EmployerIdentificationNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier issued to a person for which no specific identifier has been defined.
    /// </summary>
    [IsoId("_QD6Nptp-Ed-ak6NoX_4Aeg_-1268666477")]
    [DisplayName("Other Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrId")]
    #endif
    [IsoXmlTag("OthrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification4 OtherIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification4 OtherIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification4 OtherIdentification { get; init; } 
    #else
    public GenericIdentification4 OtherIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that assigns the identifier.
    /// </summary>
    [IsoId("_QD6Np9p-Ed-ak6NoX_4Aeg_-2082130067")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Issuer { get; init; } 
    #else
    public System.String? Issuer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
