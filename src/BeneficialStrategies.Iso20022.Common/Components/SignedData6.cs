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
/// Digital signatures of data from one or several signers.
/// </summary>
[IsoId("_pJWu0S80Eeu125Ip9zFcsQ")]
[DisplayName("Signed Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SignedData6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_pV6kIS80Eeu125Ip9zFcsQ")]
    [DisplayName("Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrsn")]
    #endif
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? Version { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Version { get; init; } 
    #else
    public System.UInt64? Version { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of digest algorithm applied before signature.
    /// </summary>
    [IsoId("_pV6kIy80Eeu125Ip9zFcsQ")]
    [DisplayName("Digest Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgstAlgo")]
    #endif
    [IsoXmlTag("DgstAlgo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AlgorithmIdentification21? DigestAlgorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AlgorithmIdentification21? DigestAlgorithm { get; init; } 
    #else
    public AlgorithmIdentification21? DigestAlgorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Data to sign.
    /// </summary>
    [IsoId("_pV6kJS80Eeu125Ip9zFcsQ")]
    [DisplayName("Encapsulated Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NcpsltdCntt")]
    #endif
    [IsoXmlTag("NcpsltdCntt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EncapsulatedContent3? EncapsulatedContent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EncapsulatedContent3? EncapsulatedContent { get; init; } 
    #else
    public EncapsulatedContent3? EncapsulatedContent { get; set; } 
    #endif
    
    /// <summary>
    /// Chain of X.509 certificates.
    /// </summary>
    [IsoId("_pV6kJy80Eeu125Ip9zFcsQ")]
    [DisplayName("Certificate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cert")]
    #endif
    [IsoXmlTag("Cert")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5000Binary? Certificate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? Certificate { get; init; } 
    #else
    public System.Byte[]? Certificate { get; set; } 
    #endif
    
    /// <summary>
    /// Digital signature and identification of a signer.
    /// </summary>
    [IsoId("_pV6kKS80Eeu125Ip9zFcsQ")]
    [DisplayName("Signer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sgnr")]
    #endif
    [IsoXmlTag("Sgnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Signer5? Signer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Signer5? Signer { get; init; } 
    #else
    public Signer5? Signer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
