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
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
/// </summary>
[IsoId("_QCHd4tp-Ed-ak6NoX_4Aeg_-1362353308")]
[DisplayName("Individual Person")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IndividualPerson8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IndividualPerson8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IndividualPerson8( System.String reqName,System.String reqGivenName,PostalAddress1 reqIndividualInvestorAddress )
    {
        Name = reqName;
        GivenName = reqGivenName;
        IndividualInvestorAddress = reqIndividualInvestorAddress;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_QCHd49p-Ed-ak6NoX_4Aeg_-1362352862")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Name { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Name { get; init; } 
    #else
    public System.String Name { get; set; } 
    #endif
    
    /// <summary>
    /// First name of a person.
    /// </summary>
    [IsoId("_QCHd5Np-Ed-ak6NoX_4Aeg_-1362350362")]
    [DisplayName("Given Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GvnNm")]
    #endif
    [IsoXmlTag("GvnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text GivenName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String GivenName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String GivenName { get; init; } 
    #else
    public System.String GivenName { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the terms used to formally address a person.
    /// </summary>
    [IsoId("_QCHd5dp-Ed-ak6NoX_4Aeg_-1354042162")]
    [DisplayName("Name Prefix")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmPrfx")]
    #endif
    [IsoXmlTag("NmPrfx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NamePrefix1Code? NamePrefix { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NamePrefix1Code? NamePrefix { get; init; } 
    #else
    public NamePrefix1Code? NamePrefix { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about a person that follows a person&apos;s name, for example, qualification such as Doctor of Philosophy (PhD).
    /// </summary>
    [IsoId("_QCHd5tp-Ed-ak6NoX_4Aeg_-1354041990")]
    [DisplayName("Name Suffix")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmSfx")]
    #endif
    [IsoXmlTag("NmSfx")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? NameSuffix { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NameSuffix { get; init; } 
    #else
    public System.String? NameSuffix { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the gender of the person.
    /// </summary>
    [IsoId("_QCHd59p-Ed-ak6NoX_4Aeg_-1354041947")]
    [DisplayName("Gender")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Gndr")]
    #endif
    [IsoXmlTag("Gndr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenderCode? Gender { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenderCode? Gender { get; init; } 
    #else
    public GenderCode? Gender { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which a person is born.
    /// </summary>
    [IsoId("_QCRO4Np-Ed-ak6NoX_4Aeg_-1354041887")]
    [DisplayName("Birth Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BirthDt")]
    #endif
    [IsoXmlTag("BirthDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? BirthDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? BirthDate { get; init; } 
    #else
    public System.DateOnly? BirthDate { get; set; } 
    #endif
    
    /// <summary>
    /// Number assigned by a social security agency.
    /// </summary>
    [IsoId("_QCRO4dp-Ed-ak6NoX_4Aeg_-1354041515")]
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
    /// Postal address of a party.
    /// </summary>
    [IsoId("_QCRO4tp-Ed-ak6NoX_4Aeg_349983267")]
    [DisplayName("Individual Investor Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndvInvstrAdr")]
    #endif
    [IsoXmlTag("IndvInvstrAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PostalAddress1 IndividualInvestorAddress { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PostalAddress1 IndividualInvestorAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress1 IndividualInvestorAddress { get; init; } 
    #else
    public PostalAddress1 IndividualInvestorAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
