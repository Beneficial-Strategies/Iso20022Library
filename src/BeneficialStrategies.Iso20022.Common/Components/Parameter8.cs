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
[IsoId("_fYx5UWmREeS7iYydEtv3Ug")]
[DisplayName("Parameter")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Parameter8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Parameter8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Parameter8( Algorithm11Code reqDigestAlgorithm,AlgorithmIdentification12 reqMaskGeneratorAlgorithm,System.UInt64 reqSaltLength )
    {
        DigestAlgorithm = reqDigestAlgorithm;
        MaskGeneratorAlgorithm = reqMaskGeneratorAlgorithm;
        SaltLength = reqSaltLength;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the digest algorithm.
    /// </summary>
    [IsoId("_fmEuc2mREeS7iYydEtv3Ug")]
    [DisplayName("Digest Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgstAlgo")]
    #endif
    [IsoXmlTag("DgstAlgo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Algorithm11Code DigestAlgorithm { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Algorithm11Code DigestAlgorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Algorithm11Code DigestAlgorithm { get; init; } 
    #else
    public Algorithm11Code DigestAlgorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Mask generator function cryptographic algorithm and parameters.
    /// </summary>
    [IsoId("_fmEudWmREeS7iYydEtv3Ug")]
    [DisplayName("Mask Generator Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MskGnrtrAlgo")]
    #endif
    [IsoXmlTag("MskGnrtrAlgo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AlgorithmIdentification12 MaskGeneratorAlgorithm { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AlgorithmIdentification12 MaskGeneratorAlgorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AlgorithmIdentification12 MaskGeneratorAlgorithm { get; init; } 
    #else
    public AlgorithmIdentification12 MaskGeneratorAlgorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Length of the salt to include in the signature.
    /// </summary>
    [IsoId("_3JFFwGmREeS7iYydEtv3Ug")]
    [DisplayName("Salt Length")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaltLngth")]
    #endif
    [IsoXmlTag("SaltLngth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber SaltLength { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 SaltLength { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 SaltLength { get; init; } 
    #else
    public System.UInt64 SaltLength { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer field number.
    /// </summary>
    [IsoId("_9NBlMGmREeS7iYydEtv3Ug")]
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
    
    
    #nullable disable
    
}
