// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides ownership details  of a person on an asset.
/// </summary>
[IsoId("_6_92AIzzEemXJvzC2Wyt1g")]
[DisplayName("Ownership")]
public record Ownership1
{
    /// <summary>
    /// Specifies the type of ownership.
    /// </summary>
    [IsoId("_ZauvUYz0EemXJvzC2Wyt1g")]
    [DisplayName("Ownership Type")]
    [IsoXmlTag("OwnrshTp")]
    public OwnershipType3Choice_? OwnershipType { get; init; }

    /// <summary>
    /// Percentage of ownership that a person has on an asset.
    /// </summary>
    [IsoId("_jeCnUIz0EemXJvzC2Wyt1g")]
    [DisplayName("Ownership Percentage")]
    [IsoXmlTag("OwnrshPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? OwnershipPercentage { get; init; }

    /// <summary>
    /// Percentage of usufruct that a person has on an asset.
    /// </summary>
    [IsoId("_8KqSEIz0EemXJvzC2Wyt1g")]
    [DisplayName("Usufruct Percentage")]
    [IsoXmlTag("UsfrctPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? UsufructPercentage { get; init; }
}
