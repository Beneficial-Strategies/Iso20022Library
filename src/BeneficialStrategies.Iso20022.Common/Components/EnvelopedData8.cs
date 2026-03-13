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
[IsoId("_3A8KsS8pEeu125Ip9zFcsQ")]
[DisplayName("Enveloped Data")]
public partial record EnvelopedData8
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_3Ns0US8pEeu125Ip9zFcsQ")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; } 
    
    /// <summary>
    /// Provides certificates of the originator.
    /// </summary>
    [IsoId("_3Ns0Uy8pEeu125Ip9zFcsQ")]
    [DisplayName("Originator Information")]
    [IsoXmlTag("OrgtrInf")]
    public OriginatorInformation1? OriginatorInformation { get; init; } 
    
    /// <summary>
    /// Session key or identification of the protection key used by the recipient.
    /// </summary>
    [IsoId("_3Ns0VS8pEeu125Ip9zFcsQ")]
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public ValueList<Recipient10Choice_> Recipient { get; init; } = [];
    // ID for the above is _3Ns0VS8pEeu125Ip9zFcsQ
    
    /// <summary>
    /// Data protection by encryption (digital envelope), with an encryption key.
    /// </summary>
    [IsoId("_3Ns0Vy8pEeu125Ip9zFcsQ")]
    [DisplayName("Encrypted Content")]
    [IsoXmlTag("NcrptdCntt")]
    public EncryptedContent6? EncryptedContent { get; init; } 
    
    
    #nullable disable
    
}
