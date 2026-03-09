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
/// Contains additional characteristics of addendum data.
/// </summary>
[IsoId("_IocXk_JZEeiJn9rM2Znz2w")]
[DisplayName("Additional Characteristics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditionalCharacteristics1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the specific classification or type of business.
    /// </summary>
    [IsoId("_IocXlPJZEeiJn9rM2Znz2w")]
    [DisplayName("Business Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BizTp")]
    #endif
    [IsoXmlTag("BizTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalCharacteristicDetails1? BusinessType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalCharacteristicDetails1? BusinessType { get; init; } 
    #else
    public AdditionalCharacteristicDetails1? BusinessType { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies specific characteristics about the
    /// business owner.
    /// </summary>
    [IsoId("_IocXlfJZEeiJn9rM2Znz2w")]
    [DisplayName("Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ownr")]
    #endif
    [IsoXmlTag("Ownr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalCharacteristicDetails1? Owner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalCharacteristicDetails1? Owner { get; init; } 
    #else
    public AdditionalCharacteristicDetails1? Owner { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies specific characteristics about the business certification type, such as small business, disadvantaged, or other certification type.
    /// </summary>
    [IsoId("_fs81AfJZEeiJn9rM2Znz2w")]
    [DisplayName("Certification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Certfctn")]
    #endif
    [IsoXmlTag("Certfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalCharacteristicDetails1? Certification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalCharacteristicDetails1? Certification { get; init; } 
    #else
    public AdditionalCharacteristicDetails1? Certification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the racial or ethnic type of
    /// the majority owner of the business.
    /// </summary>
    [IsoId("_gHCI8fJZEeiJn9rM2Znz2w")]
    [DisplayName("Owner Ethnicity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OwnrEthncty")]
    #endif
    [IsoXmlTag("OwnrEthncty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalCharacteristicDetails1? OwnerEthnicity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalCharacteristicDetails1? OwnerEthnicity { get; init; } 
    #else
    public AdditionalCharacteristicDetails1? OwnerEthnicity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
