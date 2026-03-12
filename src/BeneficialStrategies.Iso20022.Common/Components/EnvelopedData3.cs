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
[IsoId("_sjSlAS9fEeOlZIh7PImd0A")]
[DisplayName("Enveloped Data")]
public partial record EnvelopedData3
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_sz83MS9fEeOlZIh7PImd0A")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; } 
    
    /// <summary>
    /// Transport key or key encryption key (KEK) identification for the recipient.
    /// </summary>
    [IsoId("_sz83My9fEeOlZIh7PImd0A")]
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public ValueList<Recipient3Choice_> Recipient { get; init; } = new ValueList<Recipient3Choice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _sz83My9fEeOlZIh7PImd0A
    
    /// <summary>
    /// Encrypted data with an encryption key.
    /// </summary>
    [IsoId("_sz83NS9fEeOlZIh7PImd0A")]
    [DisplayName("Encrypted Content")]
    [IsoXmlTag("NcrptdCntt")]
    public required EncryptedContent2 EncryptedContent { get; init; } 
    
    
    #nullable disable
    
}
