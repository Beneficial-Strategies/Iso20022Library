// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Encrypted data with encryption key.
/// </summary>
[IsoId("_gJuUMQ0XEeqUVL7sB4m7NA")]
[DisplayName("Enveloped Data")]
public partial record EnvelopedData7
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_gVNLcQ0XEeqUVL7sB4m7NA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; } 
    
    /// <summary>
    /// Provides certificates of the originator.
    /// </summary>
    [IsoId("_gVNLcw0XEeqUVL7sB4m7NA")]
    [DisplayName("Originator Information")]
    [IsoXmlTag("OrgtrInf")]
    public OriginatorInformation1? OriginatorInformation { get; init; } 
    
    /// <summary>
    /// Session key or identification of the protection key used by the recipient.
    /// </summary>
    [IsoId("_gVNLdQ0XEeqUVL7sB4m7NA")]
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public ValueList<Recipient8Choice_> Recipient { get; init; } = [];
    // ID for the above is _gVNLdQ0XEeqUVL7sB4m7NA
    
    /// <summary>
    /// Data protection by encryption (digital envelope), with an encryption key.
    /// </summary>
    [IsoId("_gVNLdw0XEeqUVL7sB4m7NA")]
    [DisplayName("Encrypted Content")]
    [IsoXmlTag("NcrptdCntt")]
    public EncryptedContent6? EncryptedContent { get; init; } 
    
    
    #nullable disable
    
}
