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
[IsoId("_xPxG_StIEeyOa655cLd-DQ")]
[DisplayName("Collateral Proposal Response")]
public record CollateralProposalResponse4
{
    /// <summary>
    /// Provides the collateral proposal response for the variation margin.
    /// </summary>
    [IsoId("_xophAStIEeyOa655cLd-DQ")]
    [DisplayName("Variation Margin")]
    [IsoXmlTag("VartnMrgn")]
    public required CollateralProposalResponseType4 VariationMargin { get; init; }

    /// <summary>
    /// Provides the collateral proposal response for the segregated independent amount.
    /// </summary>
    [IsoId("_xophAytIEeyOa655cLd-DQ")]
    [DisplayName("Segregated Independent Amount")]
    [IsoXmlTag("SgrtdIndpdntAmt")]
    public CollateralProposalResponseType4? SegregatedIndependentAmount { get; init; }
}
