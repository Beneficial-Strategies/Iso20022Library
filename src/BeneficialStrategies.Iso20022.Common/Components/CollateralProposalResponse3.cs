// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the collateral proposal response for the variation margin and optionally the segregated independent amount.
/// </summary>
[IsoId("_sc8-1YpDEeaNTaanBSMWmg")]
[DisplayName("Collateral Proposal Response")]
public record CollateralProposalResponse3
{
    /// <summary>
    /// Provides the collateral proposal response for the variation margin.
    /// </summary>
    [IsoId("_ssRNMYpDEeaNTaanBSMWmg")]
    [DisplayName("Variation Margin")]
    [IsoXmlTag("VartnMrgn")]
    public required CollateralProposalResponseType3 VariationMargin { get; init; }

    /// <summary>
    /// Provides the collateral proposal response for the segregated independent amount.
    /// </summary>
    [IsoId("_ssRNM4pDEeaNTaanBSMWmg")]
    [DisplayName("Segregated Independent Amount")]
    [IsoXmlTag("SgrtdIndpdntAmt")]
    public CollateralProposalResponseType3? SegregatedIndependentAmount { get; init; }
}
