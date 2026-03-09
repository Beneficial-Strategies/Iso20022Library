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
/// General cryptographic message syntax (CMS) containing protected data.
/// </summary>
[IsoId("_SwFm2gEcEeCQm6a_G2yO_w_1341928510")]
[DisplayName("Content Information Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ContentInformationType1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ContentInformationType1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ContentInformationType1( ContentType1Code reqContentType )
    {
        ContentType = reqContentType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of data protection.
    /// </summary>
    [IsoId("_SwFm2wEcEeCQm6a_G2yO_w_1608351913")]
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
    /// Data protection by encryption, with a session key.
    /// </summary>
    [IsoId("_SwFm3AEcEeCQm6a_G2yO_w_935621797")]
    [DisplayName("Enveloped Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EnvlpdData")]
    #endif
    [IsoXmlTag("EnvlpdData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EnvelopedData1? EnvelopedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EnvelopedData1? EnvelopedData { get; init; } 
    #else
    public EnvelopedData1? EnvelopedData { get; set; } 
    #endif
    
    /// <summary>
    /// Data protection by a message authentication code (MAC).
    /// </summary>
    [IsoId("_SwFm3QEcEeCQm6a_G2yO_w_-1683586438")]
    [DisplayName("Authenticated Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthntcdData")]
    #endif
    [IsoXmlTag("AuthntcdData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AuthenticatedData1? AuthenticatedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthenticatedData1? AuthenticatedData { get; init; } 
    #else
    public AuthenticatedData1? AuthenticatedData { get; set; } 
    #endif
    
    /// <summary>
    /// Data protected by digital signatures.
    /// </summary>
    [IsoId("_SwPX0AEcEeCQm6a_G2yO_w_51665286")]
    [DisplayName("Signed Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SgndData")]
    #endif
    [IsoXmlTag("SgndData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedData1? SignedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedData1? SignedData { get; init; } 
    #else
    public SignedData1? SignedData { get; set; } 
    #endif
    
    /// <summary>
    /// Data protected by a digest.
    /// </summary>
    [IsoId("_SwPX0QEcEeCQm6a_G2yO_w_454252135")]
    [DisplayName("Digested Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgstdData")]
    #endif
    [IsoXmlTag("DgstdData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DigestedData1? DigestedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DigestedData1? DigestedData { get; init; } 
    #else
    public DigestedData1? DigestedData { get; set; } 
    #endif
    
    /// <summary>
    /// Data protection by encryption with a previously exchanged key identified by a name.
    /// </summary>
    [IsoId("_SwPX0gEcEeCQm6a_G2yO_w_-1708037626")]
    [DisplayName("Named Key Encrypted Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmdKeyNcrptdData")]
    #endif
    [IsoXmlTag("NmdKeyNcrptdData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NamedKeyEncryptedData1? NamedKeyEncryptedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NamedKeyEncryptedData1? NamedKeyEncryptedData { get; init; } 
    #else
    public NamedKeyEncryptedData1? NamedKeyEncryptedData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
