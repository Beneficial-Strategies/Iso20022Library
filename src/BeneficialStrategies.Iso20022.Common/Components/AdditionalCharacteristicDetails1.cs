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
/// Identifies the specific classification or details.
/// </summary>
[IsoId("_0ywmlPJYEeiJn9rM2Znz2w")]
[DisplayName("Additional Characteristic Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditionalCharacteristicDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AdditionalCharacteristicDetails1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AdditionalCharacteristicDetails1( System.String reqType )
    {
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specific type of business.
    /// </summary>
    [IsoId("_0ywml_JYEeiJn9rM2Znz2w")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Type { get; init; } 
    #else
    public System.String Type { get; set; } 
    #endif
    
    /// <summary>
    /// Party that provided the type information.
    /// </summary>
    [IsoId("_0ywmlfJYEeiJn9rM2Znz2w")]
    [DisplayName("Provided By")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvddBy")]
    #endif
    [IsoXmlTag("PrvddBy")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ProvidedBy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProvidedBy { get; init; } 
    #else
    public System.String? ProvidedBy { get; set; } 
    #endif
    
    
    #nullable disable
    
}
