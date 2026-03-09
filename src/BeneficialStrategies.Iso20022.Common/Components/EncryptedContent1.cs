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
/// Encrypted data with an encryption key.
/// </summary>
[IsoId("_Sw1NtwEcEeCQm6a_G2yO_w_594420368")]
[DisplayName("Encrypted Content")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EncryptedContent1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EncryptedContent1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EncryptedContent1( ContentType1Code reqContentType,AlgorithmIdentification1 reqContentEncryptionAlgorithm,System.Byte[] reqEncryptedData )
    {
        ContentType = reqContentType;
        ContentEncryptionAlgorithm = reqContentEncryptionAlgorithm;
        EncryptedData = reqEncryptedData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of data which have been encrypted.
    /// </summary>
    [IsoId("_Sw1NuAEcEeCQm6a_G2yO_w_942205633")]
    [DisplayName("Content Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CnttTp")]
    #endif
    [IsoXmlTag("CnttTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContentType1Code ContentType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ContentType1Code ContentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentType1Code ContentType { get; init; } 
    #else
    public ContentType1Code ContentType { get; set; } 
    #endif
    
    /// <summary>
    /// Algorithm used to encrypt the data.
    /// </summary>
    [IsoId("_Sw1NuQEcEeCQm6a_G2yO_w_-961449221")]
    [DisplayName("Content Encryption Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CnttNcrptnAlgo")]
    #endif
    [IsoXmlTag("CnttNcrptnAlgo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AlgorithmIdentification1 ContentEncryptionAlgorithm { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AlgorithmIdentification1 ContentEncryptionAlgorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AlgorithmIdentification1 ContentEncryptionAlgorithm { get; init; } 
    #else
    public AlgorithmIdentification1 ContentEncryptionAlgorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Encrypted data, result of the content encryption.
    /// </summary>
    [IsoId("_Sw1NugEcEeCQm6a_G2yO_w_2006694830")]
    [DisplayName("Encrypted Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NcrptdData")]
    #endif
    [IsoXmlTag("NcrptdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax10000Binary EncryptedData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] EncryptedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] EncryptedData { get; init; } 
    #else
    public System.Byte[] EncryptedData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
