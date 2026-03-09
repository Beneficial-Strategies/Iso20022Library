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
[IsoId("_tsmQMWjAEeSP8Z8nx8HTuQ")]
[DisplayName("Encrypted Content")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EncryptedContent3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EncryptedContent3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EncryptedContent3( ContentType2Code reqContentType,AlgorithmIdentification14 reqContentEncryptionAlgorithm,System.Byte[] reqEncryptedData )
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
    [IsoId("_t6HHwWjAEeSP8Z8nx8HTuQ")]
    [DisplayName("Content Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CnttTp")]
    #endif
    [IsoXmlTag("CnttTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContentType2Code ContentType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ContentType2Code ContentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentType2Code ContentType { get; init; } 
    #else
    public ContentType2Code ContentType { get; set; } 
    #endif
    
    /// <summary>
    /// Algorithm used to encrypt the data.
    /// </summary>
    [IsoId("_t6HHw2jAEeSP8Z8nx8HTuQ")]
    [DisplayName("Content Encryption Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CnttNcrptnAlgo")]
    #endif
    [IsoXmlTag("CnttNcrptnAlgo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AlgorithmIdentification14 ContentEncryptionAlgorithm { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AlgorithmIdentification14 ContentEncryptionAlgorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AlgorithmIdentification14 ContentEncryptionAlgorithm { get; init; } 
    #else
    public AlgorithmIdentification14 ContentEncryptionAlgorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Encrypted data, result of the content encryption.
    /// </summary>
    [IsoId("_t6HHxWjAEeSP8Z8nx8HTuQ")]
    [DisplayName("Encrypted Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NcrptdData")]
    #endif
    [IsoXmlTag("NcrptdData")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax100KBinary EncryptedData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] EncryptedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] EncryptedData { get; init; } 
    #else
    public System.Byte[] EncryptedData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
