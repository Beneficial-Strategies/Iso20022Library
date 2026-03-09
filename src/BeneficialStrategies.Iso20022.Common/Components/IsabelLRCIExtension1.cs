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
/// Specifies the LRCI protocol extension details.
/// </summary>
[IsoId("_FMiK8M_cEeWjSMe6YTKHlQ")]
[DisplayName("Isabel LRCI Extension")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IsabelLRCIExtension1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IsabelLRCIExtension1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IsabelLRCIExtension1( System.String reqImageHashAlgorithm,IsabelEpaymentTokenResponse1 reqTokenResponse,System.UInt64 reqTokenResponsePaymentInformationIndex )
    {
        ImageHashAlgorithm = reqImageHashAlgorithm;
        TokenResponse = reqTokenResponse;
        TokenResponsePaymentInformationIndex = reqTokenResponsePaymentInformationIndex;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Effective method for calculating the (cryptographic) hash value of each visual representation of a payment file.
    /// </summary>
    [IsoId("_ZZE8wM_cEeWjSMe6YTKHlQ")]
    [DisplayName("Image Hash Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ImgHashAlgo")]
    #endif
    [IsoXmlTag("ImgHashAlgo")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax105Text ImageHashAlgorithm { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ImageHashAlgorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ImageHashAlgorithm { get; init; } 
    #else
    public System.String ImageHashAlgorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Block of data on which the signature is calculated by the LRCI client.
    /// </summary>
    [IsoId("_o5QGEM_cEeWjSMe6YTKHlQ")]
    [DisplayName("Token Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TknRspn")]
    #endif
    [IsoXmlTag("TknRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsabelEpaymentTokenResponse1 TokenResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IsabelEpaymentTokenResponse1 TokenResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IsabelEpaymentTokenResponse1 TokenResponse { get; init; } 
    #else
    public IsabelEpaymentTokenResponse1 TokenResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Index of the payment information element containing the hash of the visual representation and the hash of the payment file relevant for this signature.
    /// </summary>
    [IsoId("_4jCeYM_cEeWjSMe6YTKHlQ")]
    [DisplayName("Token Response Payment Information Index")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TknRspnPmtInfIndx")]
    #endif
    [IsoXmlTag("TknRspnPmtInfIndx")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPositiveNumber TokenResponsePaymentInformationIndex { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 TokenResponsePaymentInformationIndex { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 TokenResponsePaymentInformationIndex { get; init; } 
    #else
    public System.UInt64 TokenResponsePaymentInformationIndex { get; set; } 
    #endif
    
    
    #nullable disable
    
}
