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
/// Location information.
/// </summary>
[IsoId("_MbodocW3EeuhguwJmlgagQ")]
[DisplayName("Location")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Location4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains the location code.
    /// </summary>
    [IsoId("_Mf-yIcW3EeuhguwJmlgagQ")]
    [DisplayName("Location Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LctnCd")]
    #endif
    [IsoXmlTag("LctnCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? LocationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LocationCode { get; init; } 
    #else
    public System.String? LocationCode { get; set; } 
    #endif
    
    /// <summary>
    /// Name (label) of the location.
    /// </summary>
    [IsoId("_Mf-yI8W3EeuhguwJmlgagQ")]
    [DisplayName("Location Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LctnNm")]
    #endif
    [IsoXmlTag("LctnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? LocationName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LocationName { get; init; } 
    #else
    public System.String? LocationName { get; set; } 
    #endif
    
    /// <summary>
    /// Specific explanation of the location or directions. 
    /// </summary>
    [IsoId("_Mf-yJcW3EeuhguwJmlgagQ")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the address details. 
    /// </summary>
    [IsoId("_Mf-yJ8W3EeuhguwJmlgagQ")]
    [DisplayName("Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adr")]
    #endif
    [IsoXmlTag("Adr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Address2? Address { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Address2? Address { get; init; } 
    #else
    public Address2? Address { get; set; } 
    #endif
    
    /// <summary>
    /// Local time zone.
    /// </summary>
    [IsoId("_Mf-yKcW3EeuhguwJmlgagQ")]
    [DisplayName("Local Time Zone")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclTmZone")]
    #endif
    [IsoXmlTag("LclTmZone")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? LocalTimeZone { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LocalTimeZone { get; init; } 
    #else
    public System.String? LocalTimeZone { get; set; } 
    #endif
    
    /// <summary>
    /// Local currency.
    /// </summary>
    [IsoId("_Mf-yK8W3EeuhguwJmlgagQ")]
    [DisplayName("Local Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclCcy")]
    #endif
    [IsoXmlTag("LclCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISO3NumericCurrencyCode? LocalCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? LocalCurrency { get; init; } 
    #else
    public string? LocalCurrency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
