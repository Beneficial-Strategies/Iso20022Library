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
[IsoId("_RJe69V9-EeSMgPeFpRHeJw")]
[DisplayName("Collateral Proposal")]
public record CollateralProposal4
{
    /// <summary>
    /// Provides details about the proposal for the variation margin.
    /// </summary>
    [IsoId("_RmfnEV9-EeSMgPeFpRHeJw")]
    [DisplayName("Variation Margin")]
    [IsoXmlTag("VartnMrgn")]
    public required CollateralMovement5 VariationMargin { get; init; }

    /// <summary>
    /// Provides details about the proposal for the segregated independent amount.
    /// </summary>
    [IsoId("_RmfnE19-EeSMgPeFpRHeJw")]
    [DisplayName("Segregated Independent Amount")]
    [IsoXmlTag("SgrtdIndpdntAmt")]
    public CollateralMovement5? SegregatedIndependentAmount { get; init; }
}
