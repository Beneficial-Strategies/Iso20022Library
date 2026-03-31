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
[IsoId("_-sdWNYLZEeWrrO9HojbPQA")]
[DisplayName("Expected Collateral")]
public record ExpectedCollateral2
{
    /// <summary>
    /// Provides the expected collateral type and direction for the variation margin.
    /// </summary>
    [IsoId("__DOQYYLZEeWrrO9HojbPQA")]
    [DisplayName("Variation Margin")]
    [IsoXmlTag("VartnMrgn")]
    public required ExpectedCollateralMovement2 VariationMargin { get; init; }

    /// <summary>
    /// Provides the expected collateral type and direction for the segregated independent amount.
    /// </summary>
    [IsoId("__DOQY4LZEeWrrO9HojbPQA")]
    [DisplayName("Segregated Independent Amount")]
    [IsoXmlTag("SgrtdIndpdntAmt")]
    public ExpectedCollateralMovement2? SegregatedIndependentAmount { get; init; }
}
