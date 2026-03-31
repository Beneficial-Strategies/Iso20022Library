// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Intra Position Details66.
/// </summary>
[IsoId("_nDDUWYybEe-PVZsedaAGaA")]
[DisplayName("Intra Position Details66")]
public record IntraPositionDetails66
{
    /// <summary>
    /// Balance From.
    /// </summary>
    [DisplayName("Balance From")]
    [IsoXmlTag("BalFr")]
    public required SecuritiesBalanceType6Choice_ BalanceFrom { get; init; }

    /// <summary>
    /// Intra Position Movement.
    /// </summary>
    [DisplayName("Intra Position Movement")]
    [IsoXmlTag("IntraPosMvmnt")]
    public ValueList<IntraPositionMovementDetails21> IntraPositionMovement { get; init; } = [];

    /// <summary>
    /// Safekeeping Place.
    /// </summary>
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat41Choice_? SafekeepingPlace { get; init; }
}
