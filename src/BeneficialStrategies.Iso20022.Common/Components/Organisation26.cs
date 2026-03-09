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
/// Merchant performing the transaction.
/// </summary>
[IsoId("__V4_MY0VEeWRYffwL7E13A")]
[DisplayName("Organisation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Organisation26
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Organisation26 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Organisation26( System.String reqCommonName,string reqCountryCode,System.String reqMerchantCategoryCode,System.String reqRegisteredIdentifier )
    {
        CommonName = reqCommonName;
        CountryCode = reqCountryCode;
        MerchantCategoryCode = reqMerchantCategoryCode;
        RegisteredIdentifier = reqRegisteredIdentifier;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the merchant.
    /// </summary>
    [IsoId("__hDtY40VEeWRYffwL7E13A")]
    [DisplayName("Common Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmonNm")]
    #endif
    [IsoXmlTag("CmonNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax70Text CommonName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CommonName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CommonName { get; init; } 
    #else
    public System.String CommonName { get; set; } 
    #endif
    
    /// <summary>
    /// Location of the merchant.
    /// </summary>
    [IsoId("_o5JP4I0WEeWRYffwL7E13A")]
    [DisplayName("Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adr")]
    #endif
    [IsoXmlTag("Adr")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Address { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Address { get; init; } 
    #else
    public System.String? Address { get; set; } 
    #endif
    
    /// <summary>
    /// Country of the merchant.
    /// </summary>
    [IsoId("_sv7UMI0WEeWRYffwL7E13A")]
    [DisplayName("Country Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryCd")]
    #endif
    [IsoXmlTag("CtryCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ISO3NumericCountryCode CountryCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string CountryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string CountryCode { get; init; } 
    #else
    public string CountryCode { get; set; } 
    #endif
    
    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    [IsoId("_xl7Z0I0WEeWRYffwL7E13A")]
    [DisplayName("Merchant Category Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrchntCtgyCd")]
    #endif
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Min3Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 3)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMin3Max4Text MerchantCategoryCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MerchantCategoryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MerchantCategoryCode { get; init; } 
    #else
    public System.String MerchantCategoryCode { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier of the sponsored merchant assigned by the payment facilitator of their acquirer.
    /// </summary>
    [IsoId("_1yBm0I0WEeWRYffwL7E13A")]
    [DisplayName("Registered Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegdIdr")]
    #endif
    [IsoXmlTag("RegdIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text RegisteredIdentifier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RegisteredIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RegisteredIdentifier { get; init; } 
    #else
    public System.String RegisteredIdentifier { get; set; } 
    #endif
    
    
    #nullable disable
    
}
