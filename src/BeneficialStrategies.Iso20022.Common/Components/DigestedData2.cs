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
/// Digest computed on the identified data.
/// </summary>
[IsoId("_QrKd8QiuEeKn9O5oyej_zw")]
[DisplayName("Digested Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DigestedData2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DigestedData2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DigestedData2( EncapsulatedContent1 reqEncapsulatedContent,System.String reqDigest )
    {
        EncapsulatedContent = reqEncapsulatedContent;
        Digest = reqDigest;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_Q3NV4QiuEeKn9O5oyej_zw")]
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
    /// Identification of a digest algorithm.
    /// </summary>
    [IsoId("_Q3NV5QiuEeKn9O5oyej_zw")]
    [DisplayName("Digest Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgstAlgo")]
    #endif
    [IsoXmlTag("DgstAlgo")]
    public ValueList<AlgorithmIdentification5> DigestAlgorithm { get; init; } = new ValueList<AlgorithmIdentification5>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Q3NV5QiuEeKn9O5oyej_zw
    
    /// <summary>
    /// Data on which the digest is computed.
    /// </summary>
    [IsoId("_Q3NV6QiuEeKn9O5oyej_zw")]
    [DisplayName("Encapsulated Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NcpsltdCntt")]
    #endif
    [IsoXmlTag("NcpsltdCntt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EncapsulatedContent1 EncapsulatedContent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EncapsulatedContent1 EncapsulatedContent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EncapsulatedContent1 EncapsulatedContent { get; init; } 
    #else
    public EncapsulatedContent1 EncapsulatedContent { get; set; } 
    #endif
    
    /// <summary>
    /// Result of data-digesting process.
    /// </summary>
    [IsoId("_Q3NV7QiuEeKn9O5oyej_zw")]
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
