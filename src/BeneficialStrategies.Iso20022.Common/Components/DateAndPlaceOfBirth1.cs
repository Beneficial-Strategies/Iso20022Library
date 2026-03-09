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
/// Date and place of birth of a person.
/// </summary>
[IsoId("_jU8IEa9UEeeJJK1oRb-jTw")]
[DisplayName("Date And Place Of Birth")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DateAndPlaceOfBirth1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DateAndPlaceOfBirth1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DateAndPlaceOfBirth1( System.DateOnly reqBirthDate,System.String reqCityOfBirth,string reqCountryOfBirth )
    {
        BirthDate = reqBirthDate;
        CityOfBirth = reqCityOfBirth;
        CountryOfBirth = reqCountryOfBirth;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date on which a person is born.
    /// </summary>
    [IsoId("_jexZga9UEeeJJK1oRb-jTw")]
    [DisplayName("Birth Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BirthDt")]
    #endif
    [IsoXmlTag("BirthDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate BirthDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly BirthDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly BirthDate { get; init; } 
    #else
    public System.DateOnly BirthDate { get; set; } 
    #endif
    
    /// <summary>
    /// Province where a person was born.
    /// </summary>
    [IsoId("_jexZg69UEeeJJK1oRb-jTw")]
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
    [IsoId("_jexZha9UEeeJJK1oRb-jTw")]
    [DisplayName("City Of Birth")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CityOfBirth")]
    #endif
    [IsoXmlTag("CityOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text CityOfBirth { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CityOfBirth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CityOfBirth { get; init; } 
    #else
    public System.String CityOfBirth { get; set; } 
    #endif
    
    /// <summary>
    /// Country where a person was born.
    /// </summary>
    [IsoId("_jexZh69UEeeJJK1oRb-jTw")]
    [DisplayName("Country Of Birth")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryOfBirth")]
    #endif
    [IsoXmlTag("CtryOfBirth")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCode CountryOfBirth { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string CountryOfBirth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string CountryOfBirth { get; init; } 
    #else
    public string CountryOfBirth { get; set; } 
    #endif
    
    
    #nullable disable
    
}
