// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the expected collateral type and direction.
/// </summary>
[IsoId("_UmVP9dp-Ed-ak6NoX_4Aeg_571972876")]
[DisplayName("Expected Collateral Movement")]
public record ExpectedCollateralMovement1
{
    /// <summary>
    /// Type of collateral that will be delivered.
    /// </summary>
    [IsoId("_UmVP9tp-Ed-ak6NoX_4Aeg_759302404")]
    [DisplayName("Delivery")]
    [IsoXmlTag("Dlvry")]
    public CollateralType1Code? Delivery { get; init; }

    /// <summary>
    /// Type of collateral that will be returned.
    /// </summary>
    [IsoId("_UmVP99p-Ed-ak6NoX_4Aeg_1623020220")]
    [DisplayName("Return")]
    [IsoXmlTag("Rtr")]
    public CollateralType1Code? Return { get; init; }
}
