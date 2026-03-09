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
/// Encrypted data with encryption key.
/// </summary>
[IsoId("_eO2UIQioEeKn9O5oyej_zw")]
[DisplayName("Enveloped Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EnvelopedData2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EnvelopedData2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EnvelopedData2( EncryptedContent2 reqEncryptedContent )
    {
        EncryptedContent = reqEncryptedContent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_ebDkIQioEeKn9O5oyej_zw")]
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
    /// Transport key or key encryption key (KEK) identification for the recipient.
    /// </summary>
    [IsoId("_ebDkJQioEeKn9O5oyej_zw")]
    [DisplayName("Recipient")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcpt")]
    #endif
    [IsoXmlTag("Rcpt")]
    public ValueList<Recipient2Choice_> Recipient { get; init; } = new ValueList<Recipient2Choice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _ebDkJQioEeKn9O5oyej_zw
    
    /// <summary>
    /// Encrypted data with an encryption key.
    /// </summary>
    [IsoId("_ebDkKQioEeKn9O5oyej_zw")]
    [DisplayName("Encrypted Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NcrptdCntt")]
    #endif
    [IsoXmlTag("NcrptdCntt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EncryptedContent2 EncryptedContent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EncryptedContent2 EncryptedContent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EncryptedContent2 EncryptedContent { get; init; } 
    #else
    public EncryptedContent2 EncryptedContent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
