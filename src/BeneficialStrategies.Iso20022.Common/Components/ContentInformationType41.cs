// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content Information Type41.
/// </summary>
[IsoId("_4XBJoX5QEe6YlIMyoxWMJA")]
[DisplayName("Content Information Type41")]
public record ContentInformationType41
{
    /// <summary>
    /// MAC.
    /// </summary>
    [DisplayName("MAC")]
    [IsoXmlTag("MAC")]
    public required IsoMax8HexBinaryText MAC { get; init; }

    /// <summary>
    /// MAC Data.
    /// </summary>
    [DisplayName("MAC Data")]
    [IsoXmlTag("MACData")]
    public required MACData1 MACData { get; init; }
}
