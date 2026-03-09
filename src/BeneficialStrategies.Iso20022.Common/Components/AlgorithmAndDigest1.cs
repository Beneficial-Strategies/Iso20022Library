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
/// Defines a cryptographic digest algorithm and value.
/// </summary>
[IsoId("_OTgzMjQw-AOSNFX-8224494")]
[DisplayName("Algorithm And Digest")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AlgorithmAndDigest1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AlgorithmAndDigest1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AlgorithmAndDigest1( Algorithm5Code reqDigestAlgorithm,System.String reqDigest )
    {
        DigestAlgorithm = reqDigestAlgorithm;
        Digest = reqDigest;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Digest algorithm used to create the digest.
    /// </summary>
    [IsoId("_OTgzMjcy-AOSNFX-8224496")]
    [DisplayName("Digest Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgstAlgo")]
    #endif
    [IsoXmlTag("DgstAlgo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Algorithm5Code DigestAlgorithm { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Algorithm5Code DigestAlgorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Algorithm5Code DigestAlgorithm { get; init; } 
    #else
    public Algorithm5Code DigestAlgorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Result of data-digesting process.
    /// </summary>
    [IsoId("_OTgzMjcz-AOSNFX-8224496")]
    [DisplayName("Digest")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dgst")]
    #endif
    [IsoXmlTag("Dgst")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax140Text Digest { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Digest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Digest { get; init; } 
    #else
    public System.String Digest { get; set; } 
    #endif
    
    
    #nullable disable
    
}
