// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the expected collateral type and direction for the variation margin and optionaly the segregated independent amount.
/// </summary>
[IsoId("_UllpF9p-Ed-ak6NoX_4Aeg_217990249")]
[DisplayName("Expected Collateral")]
public record ExpectedCollateral1
{
    /// <summary>
    /// Provides the expected collateral type and direction for the variation margin.
    /// </summary>
    [IsoId("_UlvaENp-Ed-ak6NoX_4Aeg_259803372")]
    [DisplayName("Variation Margin")]
    [IsoXmlTag("VartnMrgn")]
    public required ExpectedCollateralMovement1 VariationMargin { get; init; }

    /// <summary>
    /// Provides the expected collateral type and direction for the segregated independent amount.
    /// </summary>
    [IsoId("_UlvaEdp-Ed-ak6NoX_4Aeg_-964605282")]
    [DisplayName("Segregated Independent Amount")]
    [IsoXmlTag("SgrtdIndpdntAmt")]
    public ExpectedCollateralMovement1? SegregatedIndependentAmount { get; init; }
}
