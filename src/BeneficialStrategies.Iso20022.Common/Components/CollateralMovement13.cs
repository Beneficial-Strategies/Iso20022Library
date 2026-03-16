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
[IsoId("_7PZGCyqREeyR9JrVGfaMKw")]
[DisplayName("Collateral Movement")]
public record CollateralMovement13
{
    /// <summary>
    /// Provides the collateral movement direction that is a delivery only.
    /// </summary>
    [IsoId("_7nrqISqREeyR9JrVGfaMKw")]
    [DisplayName("Deliver")]
    [IsoXmlTag("Dlvr")]
    public required Collateral55 Deliver { get; init; }

    /// <summary>
    /// Provides the collateral movement direction that is a return only.
    /// </summary>
    [IsoId("_7nrqIyqREeyR9JrVGfaMKw")]
    [DisplayName("Return")]
    [IsoXmlTag("Rtr")]
    public Collateral54? Return { get; init; }
}
