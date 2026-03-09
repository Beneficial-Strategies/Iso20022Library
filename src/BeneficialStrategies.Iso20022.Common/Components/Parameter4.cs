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
/// Parameters of the asymmetric encryption algorithm.
/// </summary>
[IsoId("_T2MB8Wi3EeS87LmvcA55sg")]
[DisplayName("Parameter")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Parameter4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Format of data before encryption, if the format is not plaintext or implicit.
    /// </summary>
    [IsoId("_TVZzoGi4EeS87LmvcA55sg")]
    [DisplayName("Encryption Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NcrptnFrmt")]
    #endif
    [IsoXmlTag("NcrptnFrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EncryptionFormat1Code? EncryptionFormat { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EncryptionFormat1Code? EncryptionFormat { get; init; } 
    #else
    public EncryptionFormat1Code? EncryptionFormat { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the digest algorithm.
    /// </summary>
    [IsoId("_UDGckWi3EeS87LmvcA55sg")]
    [DisplayName("Digest Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgstAlgo")]
    #endif
    [IsoXmlTag("DgstAlgo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Algorithm11Code? DigestAlgorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Algorithm11Code? DigestAlgorithm { get; init; } 
    #else
    public Algorithm11Code? DigestAlgorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Mask generator function cryptographic algorithm and parameters.
    /// </summary>
    [IsoId("_UDGck2i3EeS87LmvcA55sg")]
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
    
    
    #nullable disable
    
}
