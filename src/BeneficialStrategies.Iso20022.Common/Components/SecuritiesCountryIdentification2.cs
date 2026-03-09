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
/// Details an individual country including its name and country code.
/// </summary>
[IsoId("_lv3_EYAMEeaYeOsLN4966A")]
[DisplayName("Securities Country Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesCountryIdentification2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesCountryIdentification2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesCountryIdentification2( CountryCodeAndName3 reqCountry,System.String reqEEACountry,Period4Choice_ reqValidityPeriod )
    {
        Country = reqCountry;
        EEACountry = reqEEACountry;
        ValidityPeriod = reqValidityPeriod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Two character country code and country name as per ISO 3166.
    /// </summary>
    [IsoId("_l7Ja8YAMEeaYeOsLN4966A")]
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
    /// Flag which reflects if the country is a member of the EEA (European Economic Area) or not.
    /// </summary>
    [IsoId("_l7Ja84AMEeaYeOsLN4966A")]
    [DisplayName("EEA Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EEACtry")]
    #endif
    [IsoXmlTag("EEACtry")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator EEACountry { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String EEACountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String EEACountry { get; init; } 
    #else
    public System.String EEACountry { get; set; } 
    #endif
    
    /// <summary>
    /// Modification status for the record compared to the previous report.
    /// </summary>
    [IsoId("_l7Ja9YAMEeaYeOsLN4966A")]
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
    /// Details the validity of the specific record.
    /// </summary>
    [IsoId("_l7Ja94AMEeaYeOsLN4966A")]
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
    /// Date when this record was last modified.
    /// </summary>
    [IsoId("_l7Ja-YAMEeaYeOsLN4966A")]
    [DisplayName("Last Updated")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastUpdtd")]
    #endif
    [IsoXmlTag("LastUpdtd")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? LastUpdated { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? LastUpdated { get; init; } 
    #else
    public System.DateOnly? LastUpdated { get; set; } 
    #endif
    
    
    #nullable disable
    
}
