// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content Information Type40.
/// </summary>
[IsoId("_DA2OQY-YEe6oobnCtR50kw")]
[DisplayName("Content Information Type40")]
public record ContentInformationType40
{
    /// <summary>
    /// Content Type.
    /// </summary>
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType2Code ContentType { get; init; }

    /// <summary>
    /// Enveloped Data.
    /// </summary>
    [DisplayName("Enveloped Data")]
    [IsoXmlTag("EnvlpdData")]
    public required EnvelopedData11 EnvelopedData { get; init; }
}
