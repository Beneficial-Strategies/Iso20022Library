// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the proposal for the variation margin and optionally the segregated independent amount.
/// </summary>
[IsoId("_rpS7BYpIEeaNTaanBSMWmg")]
[DisplayName("Collateral Proposal")]
public record CollateralProposal6
{
    /// <summary>
    /// Provides details about the proposal for the variation margin.
    /// </summary>
    [IsoId("_r4UOcYpIEeaNTaanBSMWmg")]
    [DisplayName("Variation Margin")]
    [IsoXmlTag("VartnMrgn")]
    public required CollateralMovement10 VariationMargin { get; init; }

    /// <summary>
    /// Provides details about the proposal for the segregated independent amount.
    /// </summary>
    [IsoId("_r4UOc4pIEeaNTaanBSMWmg")]
    [DisplayName("Segregated Independent Amount")]
    [IsoXmlTag("SgrtdIndpdntAmt")]
    public CollateralMovement10? SegregatedIndependentAmount { get; init; }
}
