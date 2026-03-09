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
[IsoId("_Q5lmoQ2hEeSNWNtJlXOAhg")]
[DisplayName("Individual Person")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IndividualPerson19
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IndividualPerson19 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IndividualPerson19( IndividualPersonNameLong1 reqCurrentName )
    {
        CurrentName = reqCurrentName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Current name used.
    /// </summary>
    [IsoId("_VymukA2iEeSNWNtJlXOAhg")]
    [DisplayName("Current Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurNm")]
    #endif
    [IsoXmlTag("CurNm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IndividualPersonNameLong1 CurrentName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IndividualPersonNameLong1 CurrentName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualPersonNameLong1 CurrentName { get; init; } 
    #else
    public IndividualPersonNameLong1 CurrentName { get; set; } 
    #endif
    
    /// <summary>
    /// Previous name used.
    /// </summary>
    [IsoId("_YcDdEA2iEeSNWNtJlXOAhg")]
    [DisplayName("Previous Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsNm")]
    #endif
    [IsoXmlTag("PrvsNm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndividualPersonNameLong1? PreviousName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualPersonNameLong1? PreviousName { get; init; } 
    #else
    public IndividualPersonNameLong1? PreviousName { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the gender of the person.
    /// </summary>
    [IsoId("_7GGPsA2hEeSNWNtJlXOAhg")]
    [DisplayName("Gender")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Gndr")]
    #endif
    [IsoXmlTag("Gndr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Gender1Code? Gender { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Gender1Code? Gender { get; init; } 
    #else
    public Gender1Code? Gender { get; set; } 
    #endif
    
    /// <summary>
    /// Language in which a person communicates.
    /// </summary>
    [IsoId("_33wEYA2hEeSNWNtJlXOAhg")]
    [DisplayName("Language")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lang")]
    #endif
    [IsoXmlTag("Lang")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LanguageCode? Language { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Language { get; init; } 
    #else
    public string? Language { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which a person is born.
    /// </summary>
    [IsoId("_YFl6UA2hEeSNWNtJlXOAhg")]
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
    /// Country where a person was born.
    /// </summary>
    [IsoId("_egpSMA2hEeSNWNtJlXOAhg")]
    [DisplayName("Country Of Birth")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryOfBirth")]
    #endif
    [IsoXmlTag("CtryOfBirth")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? CountryOfBirth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CountryOfBirth { get; init; } 
    #else
    public string? CountryOfBirth { get; set; } 
    #endif
    
    /// <summary>
    /// Province where a person was born.
    /// </summary>
    [IsoId("_0zEycA2hEeSNWNtJlXOAhg")]
    [DisplayName("Province Of Birth")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvcOfBirth")]
    #endif
    [IsoXmlTag("PrvcOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ProvinceOfBirth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProvinceOfBirth { get; init; } 
    #else
    public System.String? ProvinceOfBirth { get; set; } 
    #endif
    
    /// <summary>
    /// City where a person was born.
    /// </summary>
    [IsoId("_xeCJQA2hEeSNWNtJlXOAhg")]
    [DisplayName("City Of Birth")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CityOfBirth")]
    #endif
    [IsoXmlTag("CityOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CityOfBirth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CityOfBirth { get; init; } 
    #else
    public System.String? CityOfBirth { get; set; } 
    #endif
    
    /// <summary>
    /// Country of taxation of an individual person.
    /// </summary>
    [IsoId("_uMHskA2hEeSNWNtJlXOAhg")]
    [DisplayName("Taxation Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxtnCtry")]
    #endif
    [IsoXmlTag("TaxtnCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? TaxationCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? TaxationCountry { get; init; } 
    #else
    public string? TaxationCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Country and residential status of an individual, for example, non-pernament resident.
    /// </summary>
    [IsoId("_bUYxkA2hEeSNWNtJlXOAhg")]
    [DisplayName("Country And Residential Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryAndResdtlSts")]
    #endif
    [IsoXmlTag("CtryAndResdtlSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryAndResidentialStatusType1? CountryAndResidentialStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CountryAndResidentialStatusType1? CountryAndResidentialStatus { get; init; } 
    #else
    public CountryAndResidentialStatusType1? CountryAndResidentialStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Government identification for its citizens.
    /// </summary>
    [IsoId("__URgUA2hEeSNWNtJlXOAhg")]
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
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_iY9AgA2hEeSNWNtJlXOAhg")]
    [DisplayName("Postal Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstlAdr")]
    #endif
    [IsoXmlTag("PstlAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress6? PostalAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress6? PostalAddress { get; init; } 
    #else
    public PostalAddress6? PostalAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Information about a citizen.
    /// </summary>
    [IsoId("_nKO-MA2hEeSNWNtJlXOAhg")]
    [DisplayName("Citizenship Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtznshInf")]
    #endif
    [IsoXmlTag("CtznshInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CitizenshipInformation1? CitizenshipInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CitizenshipInformation1? CitizenshipInformation { get; init; } 
    #else
    public CitizenshipInformation1? CitizenshipInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Address for the primary contact.
    /// </summary>
    [IsoId("_Lp9DkA2iEeSNWNtJlXOAhg")]
    [DisplayName("Primary Communication Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmryComAdr")]
    #endif
    [IsoXmlTag("PmryComAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommunicationAddress3? PrimaryCommunicationAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationAddress3? PrimaryCommunicationAddress { get; init; } 
    #else
    public CommunicationAddress3? PrimaryCommunicationAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Communication device number or electronic address used for communication to an alternate address.
    /// </summary>
    [IsoId("_DnWfEA2iEeSNWNtJlXOAhg")]
    [DisplayName("Secondary Communication Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndryComAdr")]
    #endif
    [IsoXmlTag("ScndryComAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommunicationAddress3? SecondaryCommunicationAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationAddress3? SecondaryCommunicationAddress { get; init; } 
    #else
    public CommunicationAddress3? SecondaryCommunicationAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of identification.
    /// </summary>
    [IsoId("_IQcxIA2iEeSNWNtJlXOAhg")]
    [DisplayName("Other Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrId")]
    #endif
    [IsoXmlTag("OthrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification44? OtherIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification44? OtherIdentification { get; init; } 
    #else
    public GenericIdentification44? OtherIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Additonal information required for the account switch.
    /// </summary>
    [IsoId("_qrxLQA2hEeSNWNtJlXOAhg")]
    [DisplayName("Other Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrDtls")]
    #endif
    [IsoXmlTag("OthrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransferInstruction1? OtherDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferInstruction1? OtherDetails { get; init; } 
    #else
    public TransferInstruction1? OtherDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
