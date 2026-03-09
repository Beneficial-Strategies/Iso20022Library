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
/// General cryptographic message syntax (CMS) containing encrypted data.
/// </summary>
[IsoId("_rr2X8S9lEeOlZIh7PImd0A")]
[DisplayName("Content Information Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ContentInformationType7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ContentInformationType7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ContentInformationType7( ContentType1Code reqContentType,EnvelopedData3 reqEnvelopedData )
    {
        ContentType = reqContentType;
        EnvelopedData = reqEnvelopedData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of data protection.
    /// </summary>
    [IsoId("_r8gqIS9lEeOlZIh7PImd0A")]
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
    [IsoId("_r8gqIy9lEeOlZIh7PImd0A")]
    [DisplayName("Enveloped Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EnvlpdData")]
    #endif
    [IsoXmlTag("EnvlpdData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EnvelopedData3 EnvelopedData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EnvelopedData3 EnvelopedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EnvelopedData3 EnvelopedData { get; init; } 
    #else
    public EnvelopedData3 EnvelopedData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
