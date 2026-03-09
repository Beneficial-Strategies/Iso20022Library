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
/// Details of a currency.
/// </summary>
[IsoId("_k8F0MfayEeerBJ4shjAzSA")]
[DisplayName("Currency Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CurrencyDetails3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CurrencyDetails3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CurrencyDetails3( string reqAlphaCode,System.String reqNumericCode,System.UInt64 reqDecimal )
    {
        AlphaCode = reqAlphaCode;
        NumericCode = reqNumericCode;
        Decimal = reqDecimal;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Alpha currency code (ISO 4217, 3 alphanumeric characters).
    /// </summary>
    [IsoId("_lM53YfayEeerBJ4shjAzSA")]
    [DisplayName("Alpha Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AlphaCd")]
    #endif
    [IsoXmlTag("AlphaCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyCode AlphaCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string AlphaCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string AlphaCode { get; init; } 
    #else
    public string AlphaCode { get; set; } 
    #endif
    
    /// <summary>
    /// Numeric currency code (ISO 4217, 3 numeric characters).
    /// </summary>
    [IsoId("_lM53Y_ayEeerBJ4shjAzSA")]
    [DisplayName("Numeric Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmrcCd")]
    #endif
    [IsoXmlTag("NmrcCd")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact3NumericText NumericCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String NumericCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String NumericCode { get; init; } 
    #else
    public System.String NumericCode { get; set; } 
    #endif
    
    /// <summary>
    /// Maximal number of digits after the decimal separator for the currency.
    /// </summary>
    [IsoId("_lM53ZfayEeerBJ4shjAzSA")]
    [DisplayName("Decimal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dcml")]
    #endif
    [IsoXmlTag("Dcml")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber Decimal { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 Decimal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 Decimal { get; init; } 
    #else
    public System.UInt64 Decimal { get; set; } 
    #endif
    
    /// <summary>
    /// Full name of the currency.
    /// </summary>
    [IsoId("_lM53Z_ayEeerBJ4shjAzSA")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    
    #nullable disable
    
}
