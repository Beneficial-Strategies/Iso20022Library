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
[IsoId("_gJuUMQ0XEeqUVL7sB4m7NA")]
[DisplayName("Enveloped Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EnvelopedData7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_gVNLcQ0XEeqUVL7sB4m7NA")]
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
    /// Provides certificates of the originator.
    /// </summary>
    [IsoId("_gVNLcw0XEeqUVL7sB4m7NA")]
    [DisplayName("Originator Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgtrInf")]
    #endif
    [IsoXmlTag("OrgtrInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginatorInformation1? OriginatorInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginatorInformation1? OriginatorInformation { get; init; } 
    #else
    public OriginatorInformation1? OriginatorInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Session key or identification of the protection key used by the recipient.
    /// </summary>
    [IsoId("_gVNLdQ0XEeqUVL7sB4m7NA")]
    [DisplayName("Recipient")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcpt")]
    #endif
    [IsoXmlTag("Rcpt")]
    public ValueList<Recipient8Choice_> Recipient { get; init; } = new ValueList<Recipient8Choice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _gVNLdQ0XEeqUVL7sB4m7NA
    
    /// <summary>
    /// Data protection by encryption (digital envelope), with an encryption key.
    /// </summary>
    [IsoId("_gVNLdw0XEeqUVL7sB4m7NA")]
    [DisplayName("Encrypted Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NcrptdCntt")]
    #endif
    [IsoXmlTag("NcrptdCntt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EncryptedContent6? EncryptedContent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EncryptedContent6? EncryptedContent { get; init; } 
    #else
    public EncryptedContent6? EncryptedContent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
