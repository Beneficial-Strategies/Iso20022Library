// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the collateral movement direction that is a delivery and optionaly a return.
/// </summary>
[IsoId("_QtN1tV9-EeSMgPeFpRHeJw")]
[DisplayName("Collateral Movement")]
public record CollateralMovement6
{
    /// <summary>
    /// Provides the collateral movement direction that is a delivery only.
    /// </summary>
    [IsoId("_RJe68V9-EeSMgPeFpRHeJw")]
    [DisplayName("Deliver")]
    [IsoXmlTag("Dlvr")]
    public required Collateral8 Deliver { get; init; }

    /// <summary>
    /// Provides the collateral movement direction that is a return only.
    /// </summary>
    [IsoId("_RJe6819-EeSMgPeFpRHeJw")]
    [DisplayName("Return")]
    [IsoXmlTag("Rtr")]
    public Collateral7? Return { get; init; }
}
