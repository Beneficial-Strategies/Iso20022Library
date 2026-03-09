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
/// Entity who has signed the data and its digital signature.
/// </summary>
[IsoId("_vVub0VFKEeyApZmLzm74zA")]
[DisplayName("Signer")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Signer6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Signer6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Signer6( AlgorithmIdentification21 reqDigestAlgorithm,AlgorithmIdentification30 reqSignatureAlgorithm,System.Byte[] reqSignature )
    {
        DigestAlgorithm = reqDigestAlgorithm;
        SignatureAlgorithm = reqSignatureAlgorithm;
        Signature = reqSignature;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Version of the Cryptographic Message Syntax (CMS) data structure.
    /// </summary>
    [IsoId("_vb7xgVFKEeyApZmLzm74zA")]
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
    /// Identification of the entity who has signed the data.
    /// </summary>
    [IsoId("_vb7xg1FKEeyApZmLzm74zA")]
    [DisplayName("Signer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SgnrId")]
    #endif
    [IsoXmlTag("SgnrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Recipient12Choice_? SignerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Recipient12Choice_? SignerIdentification { get; init; } 
    #else
    public Recipient12Choice_? SignerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a digest algorithm to apply before signature.
    /// </summary>
    [IsoId("_vb7xhVFKEeyApZmLzm74zA")]
    [DisplayName("Digest Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgstAlgo")]
    #endif
    [IsoXmlTag("DgstAlgo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AlgorithmIdentification21 DigestAlgorithm { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AlgorithmIdentification21 DigestAlgorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AlgorithmIdentification21 DigestAlgorithm { get; init; } 
    #else
    public AlgorithmIdentification21 DigestAlgorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Collection of attributes that are signed.
    /// </summary>
    [IsoId("_vb7xh1FKEeyApZmLzm74zA")]
    [DisplayName("Signed Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SgndAttrbts")]
    #endif
    [IsoXmlTag("SgndAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericInformation1? SignedAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericInformation1? SignedAttributes { get; init; } 
    #else
    public GenericInformation1? SignedAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// Cryptographic digital signature algorithm.
    /// </summary>
    [IsoId("_vb7xiVFKEeyApZmLzm74zA")]
    [DisplayName("Signature Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SgntrAlgo")]
    #endif
    [IsoXmlTag("SgntrAlgo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AlgorithmIdentification30 SignatureAlgorithm { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AlgorithmIdentification30 SignatureAlgorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AlgorithmIdentification30 SignatureAlgorithm { get; init; } 
    #else
    public AlgorithmIdentification30 SignatureAlgorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Digital signature.
    /// </summary>
    [IsoId("_vb7xi1FKEeyApZmLzm74zA")]
    [DisplayName("Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sgntr")]
    #endif
    [IsoXmlTag("Sgntr")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax3000Binary Signature { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] Signature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] Signature { get; init; } 
    #else
    public System.Byte[] Signature { get; set; } 
    #endif
    
    
    #nullable disable
    
}
