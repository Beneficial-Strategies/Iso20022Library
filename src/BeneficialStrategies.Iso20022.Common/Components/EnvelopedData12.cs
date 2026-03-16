// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Enveloped Data12.
/// </summary>
[IsoId("_9rcDQXdCEe6YlIMyoxWMJA")]
[DisplayName("Enveloped Data12")]
public partial record EnvelopedData12
{
    #nullable enable

    /// <summary>
    /// Encrypted Content.
    /// </summary>
    [DisplayName("Encrypted Content")]
    [IsoXmlTag("NcrptdCntt")]
    public EncryptedContent8? EncryptedContent { get; init; } 

    /// <summary>
    /// Recipient.
    /// </summary>
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public ValueList<Recipient7Choice_> Recipient { get; init; } = [];

    /// <summary>
    /// Version.
    /// </summary>
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public IsoNumber? Version { get; init; } 

    
    #nullable disable
    
}
