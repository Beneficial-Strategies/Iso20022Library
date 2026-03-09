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
/// Extension for additional information.
/// </summary>
[IsoId("_FWA4v2CUEeK8P92abE6HIA")]
[DisplayName("Updated Additional Information 6 SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UpdatedAdditionalInformation6SD3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_FWA4y2CUEeK8P92abE6HIA")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the securities account to be credited.
    /// 会社法制の見直し要綱の、22ページ第３－１－①をご参照ください。.
    /// </summary>
    [IsoId("_lYWXUGCVEeK8P92abE6HIA")]
    [DisplayName("Securities Credit Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesCdtAcctId")]
    #endif
    [IsoXmlTag("SctiesCdtAcctId")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax50Text? SecuritiesCreditAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecuritiesCreditAccountIdentification { get; init; } 
    #else
    public System.String? SecuritiesCreditAccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// ISIN of Offeror&apos;s share when the corporate action event type code is TEND.
    /// </summary>
    [IsoId("_48yLQGxREeK_SqccejsxHw")]
    [DisplayName("Offeror Share")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OfferrShr")]
    #endif
    [IsoXmlTag("OfferrShr")]
    [IsoSimpleType(IsoSimpleType.ISINIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISINIdentifier? OfferorShare { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OfferorShare { get; init; } 
    #else
    public System.String? OfferorShare { get; set; } 
    #endif
    
    /// <summary>
    /// Local code of Offeror&apos;s share when the corporate action event type code is TEND.
    /// 買付者 銘柄コード.
    /// </summary>
    [IsoId("_48yLQ2xREeK_SqccejsxHw")]
    [DisplayName("Offeror Share Local Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OfferrShrLclCd")]
    #endif
    [IsoXmlTag("OfferrShrLclCd")]
    [IsoSimpleType(IsoSimpleType.Max5AlphaNumericText)]
    [StringLength(maximumLength: 5 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5AlphaNumericText? OfferorShareLocalCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OfferorShareLocalCode { get; init; } 
    #else
    public System.String? OfferorShareLocalCode { get; set; } 
    #endif
    
    /// <summary>
    /// Name in the local language by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_48yLRmxREeK_SqccejsxHw")]
    [DisplayName("Local Language Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclLangNm")]
    #endif
    [IsoXmlTag("LclLangNm")]
    [IsoSimpleType(IsoSimpleType.Max240Text)]
    [StringLength(maximumLength: 240 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax240Text? LocalLanguageName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LocalLanguageName { get; init; } 
    #else
    public System.String? LocalLanguageName { get; set; } 
    #endif
    
    
    #nullable disable
    
}
