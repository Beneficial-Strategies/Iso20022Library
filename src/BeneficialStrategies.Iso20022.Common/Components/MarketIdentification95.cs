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
/// Details on a trading venue as per ISO 10383.
/// </summary>
[IsoId("_Q8VpYS6mEeiLE6ldFr13hQ")]
[DisplayName("Market Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MarketIdentification95
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MarketIdentification95 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MarketIdentification95( System.String reqOperating,System.String reqSegment,MarketIdentification1Code reqType,System.String reqInstitutionName,CountryCodeAndName3 reqCountry,Period4Choice_ reqValidityPeriod )
    {
        Operating = reqOperating;
        Segment = reqSegment;
        Type = reqType;
        InstitutionName = reqInstitutionName;
        Country = reqCountry;
        ValidityPeriod = reqValidityPeriod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Operating MIC of the venue.
    /// </summary>
    [IsoId("_RLF3ES6mEeiLE6ldFr13hQ")]
    [DisplayName("Operating")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Oprg")]
    #endif
    [IsoXmlTag("Oprg")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMICIdentifier Operating { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Operating { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Operating { get; init; } 
    #else
    public System.String Operating { get; set; } 
    #endif
    
    /// <summary>
    /// Segment MIC of the venue where it exists, otherwise the Operating MIC.
    /// </summary>
    [IsoId("_RLF3Ey6mEeiLE6ldFr13hQ")]
    [DisplayName("Segment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sgmt")]
    #endif
    [IsoXmlTag("Sgmt")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMICIdentifier Segment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Segment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Segment { get; init; } 
    #else
    public System.String Segment { get; set; } 
    #endif
    
    /// <summary>
    /// Define the type of Market Identification Code that is being supplied.
    /// </summary>
    [IsoId("_RLF3FS6mEeiLE6ldFr13hQ")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MarketIdentification1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MarketIdentification1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketIdentification1Code Type { get; init; } 
    #else
    public MarketIdentification1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the category of market the venue operates in.
    /// </summary>
    [IsoId("_RLF3Fy6mEeiLE6ldFr13hQ")]
    [DisplayName("Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctgy")]
    #endif
    [IsoXmlTag("Ctgy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MICEntityType1Code? Category { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MICEntityType1Code? Category { get; init; } 
    #else
    public MICEntityType1Code? Category { get; set; } 
    #endif
    
    /// <summary>
    /// The name or description of the institution, market, or infrastructure.
    /// </summary>
    [IsoId("_RLF3GS6mEeiLE6ldFr13hQ")]
    [DisplayName("Institution Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstnNm")]
    #endif
    [IsoXmlTag("InstnNm")]
    [IsoSimpleType(IsoSimpleType.Max450Text)]
    [StringLength(maximumLength: 450 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax450Text InstitutionName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String InstitutionName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String InstitutionName { get; init; } 
    #else
    public System.String InstitutionName { get; set; } 
    #endif
    
    /// <summary>
    /// Known acronym of the institution, market, or infrastructure.
    /// </summary>
    [IsoId("_RLF3Gy6mEeiLE6ldFr13hQ")]
    [DisplayName("Acronym")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acrnm")]
    #endif
    [IsoXmlTag("Acrnm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Acronym { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Acronym { get; init; } 
    #else
    public System.String? Acronym { get; set; } 
    #endif
    
    /// <summary>
    /// City where the institution, market, or infrastructure operates.
    /// </summary>
    [IsoId("_RLF3HS6mEeiLE6ldFr13hQ")]
    [DisplayName("City")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="City")]
    #endif
    [IsoXmlTag("City")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? City { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? City { get; init; } 
    #else
    public System.String? City { get; set; } 
    #endif
    
    /// <summary>
    /// Two character country code and country name as per ISO 3166.
    /// </summary>
    [IsoId("_RLF3Hy6mEeiLE6ldFr13hQ")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCodeAndName3 Country { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CountryCodeAndName3 Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CountryCodeAndName3 Country { get; init; } 
    #else
    public CountryCodeAndName3 Country { get; set; } 
    #endif
    
    /// <summary>
    /// The name of the national competent authority associated with the MIC.
    /// </summary>
    [IsoId("_RLF3IS6mEeiLE6ldFr13hQ")]
    [DisplayName("Authority Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthrtyNm")]
    #endif
    [IsoXmlTag("AuthrtyNm")]
    [IsoSimpleType(IsoSimpleType.Max450Text)]
    [StringLength(maximumLength: 450 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax450Text? AuthorityName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AuthorityName { get; init; } 
    #else
    public System.String? AuthorityName { get; set; } 
    #endif
    
    /// <summary>
    /// Website URI of the institution, market, or infrastructure.
    /// </summary>
    [IsoId("_RLF3Iy6mEeiLE6ldFr13hQ")]
    [DisplayName("Web Site")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WebSite")]
    #endif
    [IsoXmlTag("WebSite")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax210Text? WebSite { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? WebSite { get; init; } 
    #else
    public System.String? WebSite { get; set; } 
    #endif
    
    /// <summary>
    /// Details additional information about the market operator.
    /// </summary>
    [IsoId("_RLF3JS6mEeiLE6ldFr13hQ")]
    [DisplayName("Note")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Note")]
    #endif
    [IsoXmlTag("Note")]
    [IsoSimpleType(IsoSimpleType.Max450Text)]
    [StringLength(maximumLength: 450 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax450Text? Note { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Note { get; init; } 
    #else
    public System.String? Note { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information to help users identify the exchange or understand a modification.
    /// </summary>
    [IsoId("_RLF3Jy6mEeiLE6ldFr13hQ")]
    [DisplayName("Modification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mod")]
    #endif
    [IsoXmlTag("Mod")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Modification1Code? Modification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Modification1Code? Modification { get; init; } 
    #else
    public Modification1Code? Modification { get; set; } 
    #endif
    
    /// <summary>
    /// First date of the MIC issuance.
    /// </summary>
    [IsoId("_RLF3KS6mEeiLE6ldFr13hQ")]
    [DisplayName("Creation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CreDt")]
    #endif
    [IsoXmlTag("CreDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? CreationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? CreationDate { get; init; } 
    #else
    public System.DateOnly? CreationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Details the validity of the specific record.
    /// </summary>
    [IsoId("_RLF3Ky6mEeiLE6ldFr13hQ")]
    [DisplayName("Validity Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldtyPrd")]
    #endif
    [IsoXmlTag("VldtyPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Period4Choice_ ValidityPeriod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Period4Choice_ ValidityPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period4Choice_ ValidityPeriod { get; init; } 
    #else
    public Period4Choice_ ValidityPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Date when the market identification code was last modified.
    /// </summary>
    [IsoId("_RLF3LS6mEeiLE6ldFr13hQ")]
    [DisplayName("Status Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsDt")]
    #endif
    [IsoXmlTag("StsDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? StatusDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? StatusDate { get; init; } 
    #else
    public System.DateOnly? StatusDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date when this record was last modified.
    /// </summary>
    [IsoId("_RLF3Ly6mEeiLE6ldFr13hQ")]
    [DisplayName("Last Updated Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastUpdtdDt")]
    #endif
    [IsoXmlTag("LastUpdtdDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? LastUpdatedDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? LastUpdatedDate { get; init; } 
    #else
    public System.DateTime? LastUpdatedDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
