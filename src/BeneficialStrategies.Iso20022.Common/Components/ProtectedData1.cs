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
/// Contains protected data and the attributes used to protect the data.
/// </summary>
[IsoId("_SmzOEEYdEeegp_DADCe7HQ")]
[DisplayName("Protected Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProtectedData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ProtectedData1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ProtectedData1( ContentType3Code reqContentType )
    {
        ContentType = reqContentType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of data protection.
    /// </summary>
    [IsoId("_fj-2MEYdEeegp_DADCe7HQ")]
    [DisplayName("Content Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CnttTp")]
    #endif
    [IsoXmlTag("CnttTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContentType3Code ContentType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ContentType3Code ContentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentType3Code ContentType { get; init; } 
    #else
    public ContentType3Code ContentType { get; set; } 
    #endif
    
    /// <summary>
    /// Consists of an encrypted content of any type and encrypted content-encryption keys for one or more recipients.  The combination of the encrypted content and one encrypted content-encryption key for a recipient is a &quot;digital   envelope&quot; for that recipient.
    /// </summary>
    [IsoId("_sSSU0EYdEeegp_DADCe7HQ")]
    [DisplayName("Enveloped Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EnvlpdData")]
    #endif
    [IsoXmlTag("EnvlpdData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EnvelopedData6? EnvelopedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EnvelopedData6? EnvelopedData { get; init; } 
    #else
    public EnvelopedData6? EnvelopedData { get; set; } 
    #endif
    
    /// <summary>
    /// Contains encrypted data and the attributes used to encrypt the data using the ISO 13492 methods for data encryption.  The encryption key is not included in the message with this method.
    /// </summary>
    [IsoId("_pF-HID6TEeq_lLaSkIVjTQ")]
    [DisplayName("Encrypted Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NcrptdData")]
    #endif
    [IsoXmlTag("NcrptdData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EncryptedData1? EncryptedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EncryptedData1? EncryptedData { get; init; } 
    #else
    public EncryptedData1? EncryptedData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
