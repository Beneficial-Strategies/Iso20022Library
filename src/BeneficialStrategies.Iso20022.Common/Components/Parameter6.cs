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
/// Parameters associated to a cryptographic encryption algorithm.
/// </summary>
[IsoId("_jKs7kWi8EeS87LmvcA55sg")]
[DisplayName("Parameter")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Parameter6
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
    [IsoId("_1Fd4AGi8EeS87LmvcA55sg")]
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
    /// Initialisation vector of a cipher block chaining (CBC) mode encryption.
    /// </summary>
    [IsoId("_jXzjcWi8EeS87LmvcA55sg")]
    [DisplayName("Initialisation Vector")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlstnVctr")]
    #endif
    [IsoXmlTag("InitlstnVctr")]
    [IsoSimpleType(IsoSimpleType.Max500Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax500Binary? InitialisationVector { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? InitialisationVector { get; init; } 
    #else
    public System.Byte[]? InitialisationVector { get; set; } 
    #endif
    
    /// <summary>
    /// Byte padding for a cypher block chaining mode encryption, if the padding is not implicit.
    /// </summary>
    [IsoId("_67hP8Gi9EeS87LmvcA55sg")]
    [DisplayName("Byte Padding")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BPddg")]
    #endif
    [IsoXmlTag("BPddg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BytePadding1Code? BytePadding { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BytePadding1Code? BytePadding { get; init; } 
    #else
    public BytePadding1Code? BytePadding { get; set; } 
    #endif
    
    
    #nullable disable
    
}
