// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the proposal for the variation margin and optionaly the segregated independent amount.
/// </summary>
[IsoId("_zeoQX4FvEeWtPe6Crjmeug")]
[DisplayName("Collateral Proposal")]
public record CollateralProposal5
{
    /// <summary>
    /// Provides details about the proposal for the variation margin.
    /// </summary>
    [IsoId("_z0NewYFvEeWtPe6Crjmeug")]
    [DisplayName("Variation Margin")]
    [IsoXmlTag("VartnMrgn")]
    public required CollateralMovement7 VariationMargin { get; init; }

    /// <summary>
    /// Provides details about the proposal for the segregated independent amount.
    /// </summary>
    [IsoId("_z0New4FvEeWtPe6Crjmeug")]
    [DisplayName("Segregated Independent Amount")]
    [IsoXmlTag("SgrtdIndpdntAmt")]
    public CollateralMovement7? SegregatedIndependentAmount { get; init; }
}
