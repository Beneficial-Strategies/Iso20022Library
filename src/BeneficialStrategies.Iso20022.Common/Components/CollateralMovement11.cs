// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the collateral movement direction that is a delivery and optionally a return.
/// </summary>
[IsoId("_sWEhdYpIEeaNTaanBSMWmg")]
[DisplayName("Collateral Movement")]
public record CollateralMovement11
{
    /// <summary>
    /// Provides the collateral movement direction that is a delivery only.
    /// </summary>
    [IsoId("_skpwAYpIEeaNTaanBSMWmg")]
    [DisplayName("Deliver")]
    [IsoXmlTag("Dlvr")]
    public required Collateral16 Deliver { get; init; }

    /// <summary>
    /// Provides the collateral movement direction that is a return only.
    /// </summary>
    [IsoId("_skpwA4pIEeaNTaanBSMWmg")]
    [DisplayName("Return")]
    [IsoXmlTag("Rtr")]
    public Collateral17? Return { get; init; }
}
