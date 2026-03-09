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
[IsoId("_q8DG0VE_EeyApZmLzm74zA")]
[DisplayName("Content Information Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ContentInformationType30
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ContentInformationType30 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ContentInformationType30( ContentType2Code reqContentType )
    {
        ContentType = reqContentType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of data protection.
    /// </summary>
    [IsoId("_rCTf0VE_EeyApZmLzm74zA")]
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
    /// Data protection by encryption, with a session key.
    /// </summary>
    [IsoId("_rCTf01E_EeyApZmLzm74zA")]
    [DisplayName("Enveloped Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EnvlpdData")]
    #endif
    [IsoXmlTag("EnvlpdData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EnvelopedData9? EnvelopedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EnvelopedData9? EnvelopedData { get; init; } 
    #else
    public EnvelopedData9? EnvelopedData { get; set; } 
    #endif
    
    /// <summary>
    /// Data protection by a message authentication code (MAC).
    /// </summary>
    [IsoId("_rCTf1VE_EeyApZmLzm74zA")]
    [DisplayName("Authenticated Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthntcdData")]
    #endif
    [IsoXmlTag("AuthntcdData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AuthenticatedData8? AuthenticatedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthenticatedData8? AuthenticatedData { get; init; } 
    #else
    public AuthenticatedData8? AuthenticatedData { get; set; } 
    #endif
    
    /// <summary>
    /// Data protected by a digital signatures.
    /// </summary>
    [IsoId("_rCTf11E_EeyApZmLzm74zA")]
    [DisplayName("Signed Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SgndData")]
    #endif
    [IsoXmlTag("SgndData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedData7? SignedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedData7? SignedData { get; init; } 
    #else
    public SignedData7? SignedData { get; set; } 
    #endif
    
    /// <summary>
    /// Data protected by a digest.
    /// </summary>
    [IsoId("_rCTf2VE_EeyApZmLzm74zA")]
    [DisplayName("Digested Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgstdData")]
    #endif
    [IsoXmlTag("DgstdData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DigestedData5? DigestedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DigestedData5? DigestedData { get; init; } 
    #else
    public DigestedData5? DigestedData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
