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
[IsoId("_wKYgQXDOEe2MCaKO5AtGsA")]
[DisplayName("Enveloped Data")]
public partial record EnvelopedData10
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_wSCAYXDOEe2MCaKO5AtGsA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; } 
    
    /// <summary>
    /// Provides certificates of the originator.
    /// </summary>
    [IsoId("_wSCAY3DOEe2MCaKO5AtGsA")]
    [DisplayName("Originator Information")]
    [IsoXmlTag("OrgtrInf")]
    public OriginatorInformation1? OriginatorInformation { get; init; } 
    
    /// <summary>
    /// Session key or identification of the protection key used by the recipient.
    /// </summary>
    [IsoId("_wSCAZXDOEe2MCaKO5AtGsA")]
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public ValueList<Recipient14Choice_> Recipient { get; init; } = new ValueList<Recipient14Choice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _wSCAZXDOEe2MCaKO5AtGsA
    
    /// <summary>
    /// Data protection by encryption (digital envelope), with an encryption key.
    /// </summary>
    [IsoId("_wSCAZ3DOEe2MCaKO5AtGsA")]
    [DisplayName("Encrypted Content")]
    [IsoXmlTag("NcrptdCntt")]
    public EncryptedContent6? EncryptedContent { get; init; } 
    
    
    #nullable disable
    
}
