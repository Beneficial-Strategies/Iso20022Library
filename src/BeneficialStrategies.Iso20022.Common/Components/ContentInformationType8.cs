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
/// General cryptographic message syntax (CMS) containing authenticated data.
/// </summary>
[IsoId("_KpedcTF5EeO118ZQJgaQSQ")]
[DisplayName("Content Information Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ContentInformationType8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ContentInformationType8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ContentInformationType8( ContentType1Code reqContentType )
    {
        ContentType = reqContentType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of data protection.
    /// </summary>
    [IsoId("_K5_lsTF5EeO118ZQJgaQSQ")]
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
    /// Data protection by a message authentication code (MAC).
    /// </summary>
    [IsoId("_K5_lszF5EeO118ZQJgaQSQ")]
    [DisplayName("Authenticated Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthntcdData")]
    #endif
    [IsoXmlTag("AuthntcdData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AuthenticatedData3? AuthenticatedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthenticatedData3? AuthenticatedData { get; init; } 
    #else
    public AuthenticatedData3? AuthenticatedData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
