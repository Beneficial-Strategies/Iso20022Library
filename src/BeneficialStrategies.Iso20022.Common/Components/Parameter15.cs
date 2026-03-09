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
/// Parameters of the RSASSA-PSS digital signature algorithm (RSA signature algorithm with appendix: Probabilistic Signature Scheme).
/// </summary>
[IsoId("_G4BX4S_JEeugIJ3Gvoevmg")]
[DisplayName("Parameter")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Parameter15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the digest algorithm.
    /// </summary>
    [IsoId("_HC81gS_JEeugIJ3Gvoevmg")]
    [DisplayName("Digest Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgstAlgo")]
    #endif
    [IsoXmlTag("DgstAlgo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Algorithm16Code? DigestAlgorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Algorithm16Code? DigestAlgorithm { get; init; } 
    #else
    public Algorithm16Code? DigestAlgorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Mask generator function cryptographic algorithm and parameters.
    /// </summary>
    [IsoId("_HC81gy_JEeugIJ3Gvoevmg")]
    [DisplayName("Mask Generator Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MskGnrtrAlgo")]
    #endif
    [IsoXmlTag("MskGnrtrAlgo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AlgorithmIdentification12? MaskGeneratorAlgorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AlgorithmIdentification12? MaskGeneratorAlgorithm { get; init; } 
    #else
    public AlgorithmIdentification12? MaskGeneratorAlgorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Length of the salt to include in the signature.
    /// </summary>
    [IsoId("_HC81hS_JEeugIJ3Gvoevmg")]
    [DisplayName("Salt Length")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaltLngth")]
    #endif
    [IsoXmlTag("SaltLngth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? SaltLength { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? SaltLength { get; init; } 
    #else
    public System.UInt64? SaltLength { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer field number.
    /// </summary>
    [IsoId("_HC81hy_JEeugIJ3Gvoevmg")]
    [DisplayName("Trailer Field")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrlrFld")]
    #endif
    [IsoXmlTag("TrlrFld")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? TrailerField { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TrailerField { get; init; } 
    #else
    public System.UInt64? TrailerField { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the Elliptic Curve according to the OID notation.
    /// </summary>
    [IsoId("_WPWHMC_JEeugIJ3Gvoevmg")]
    [DisplayName("OID Curve Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OIDCrvNm")]
    #endif
    [IsoXmlTag("OIDCrvNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? OIDCurveName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OIDCurveName { get; init; } 
    #else
    public System.String? OIDCurveName { get; set; } 
    #endif
    
    
    #nullable disable
    
}
