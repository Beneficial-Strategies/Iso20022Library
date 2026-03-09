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
[IsoId("_v-VR0aQtEeeWXKXf3KjtmQ")]
[DisplayName("Encrypted Content")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EncryptedContent5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EncryptedContent5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EncryptedContent5( ContentType2Code reqContentType,AlgorithmIdentification25 reqContentEncryptionAlgorithm )
    {
        ContentType = reqContentType;
        ContentEncryptionAlgorithm = reqContentEncryptionAlgorithm;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of data which have been encrypted.
    /// </summary>
    [IsoId("_wJoi4aQtEeeWXKXf3KjtmQ")]
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
    [IsoId("_wJoi46QtEeeWXKXf3KjtmQ")]
    [DisplayName("Content Encryption Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CnttNcrptnAlgo")]
    #endif
    [IsoXmlTag("CnttNcrptnAlgo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AlgorithmIdentification25 ContentEncryptionAlgorithm { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AlgorithmIdentification25 ContentEncryptionAlgorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AlgorithmIdentification25 ContentEncryptionAlgorithm { get; init; } 
    #else
    public AlgorithmIdentification25 ContentEncryptionAlgorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Encrypted data, result of the content encryption.
    /// </summary>
    [IsoId("_wJoi5aQtEeeWXKXf3KjtmQ")]
    [DisplayName("Encrypted Data Element")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NcrptdDataElmt")]
    #endif
    [IsoXmlTag("NcrptdDataElmt")]
    public ValueList<EncryptedDataElement1> EncryptedDataElement { get; init; } = new ValueList<EncryptedDataElement1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _wJoi5aQtEeeWXKXf3KjtmQ
    
    
    #nullable disable
    
}
