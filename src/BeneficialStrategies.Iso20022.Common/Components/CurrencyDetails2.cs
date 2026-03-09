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
[IsoId("_uN0q0YomEeSaAcF2oE2GNQ")]
[DisplayName("Currency Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CurrencyDetails2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Alpha currency code (ISO 4217, 3 alphanumeric characters).
    /// </summary>
    [IsoId("_ubGR0YomEeSaAcF2oE2GNQ")]
    [DisplayName("Alpha Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AlphaCd")]
    #endif
    [IsoXmlTag("AlphaCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? AlphaCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? AlphaCode { get; init; } 
    #else
    public string? AlphaCode { get; set; } 
    #endif
    
    /// <summary>
    /// Numeric currency code (ISO 4217, 3 numeric characters).
    /// </summary>
    [IsoId("_ubGR04omEeSaAcF2oE2GNQ")]
    [DisplayName("Numeric Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmrcCd")]
    #endif
    [IsoXmlTag("NmrcCd")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact3NumericText? NumericCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NumericCode { get; init; } 
    #else
    public System.String? NumericCode { get; set; } 
    #endif
    
    /// <summary>
    /// Maximal number of digits after the decimal separator for the currency.
    /// </summary>
    [IsoId("_ubGR1YomEeSaAcF2oE2GNQ")]
    [DisplayName("Decimal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dcml")]
    #endif
    [IsoXmlTag("Dcml")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? Decimal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Decimal { get; init; } 
    #else
    public System.UInt64? Decimal { get; set; } 
    #endif
    
    /// <summary>
    /// Full name of the currency.
    /// </summary>
    [IsoId("_ubGR14omEeSaAcF2oE2GNQ")]
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
