// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Protected Data2.
/// </summary>
[IsoId("_YXruUXdBEe6YlIMyoxWMJA")]
[DisplayName("Protected Data2")]
public partial record ProtectedData2
{
    #nullable enable

    /// <summary>
    /// Content Type.
    /// </summary>
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType3Code ContentType { get; init; } 

    /// <summary>
    /// Encrypted Data.
    /// </summary>
    [DisplayName("Encrypted Data")]
    [IsoXmlTag("NcrptdData")]
    public EncryptedData2? EncryptedData { get; init; } 

    /// <summary>
    /// Enveloped Data.
    /// </summary>
    [DisplayName("Enveloped Data")]
    [IsoXmlTag("EnvlpdData")]
    public EnvelopedData12? EnvelopedData { get; init; } 

    
    #nullable disable
    
}
