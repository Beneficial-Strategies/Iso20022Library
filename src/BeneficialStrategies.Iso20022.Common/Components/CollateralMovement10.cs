// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the agreed amount and the collateral movement direction.
/// </summary>
[IsoId("_r4UOdYpIEeaNTaanBSMWmg")]
[DisplayName("Collateral Movement")]
public record CollateralMovement10
{
    /// <summary>
    /// Provides the call amount that is agreed and that will result in a collateral movement.
    /// </summary>
    [IsoId("_sHMX8YpIEeaNTaanBSMWmg")]
    [DisplayName("Agreed Amount")]
    [IsoXmlTag("AgrdAmt")]
    public required ActiveCurrencyAndAmount AgreedAmount { get; init; }

    /// <summary>
    /// Provides the collateral movement direction that is a delivery and optionally a return, or a return only.
    /// </summary>
    [IsoId("_sHMX84pIEeaNTaanBSMWmg")]
    [DisplayName("Movement Direction")]
    [IsoXmlTag("MvmntDrctn")]
    public ValueList<CollateralMovement5Choice_> MovementDirection { get; init; } = [];
}
