// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the collateral proposal response for the variation margin and optionaly the segregated independent amount.
/// </summary>
[IsoId("_wJv8XWTUEeSSTJlMfOKFsA")]
[DisplayName("Collateral Proposal Response")]
public record CollateralProposalResponse2
{
    /// <summary>
    /// Provides the collateral proposal response for the variation margin.
    /// </summary>
    [IsoId("_wmm3cWTUEeSSTJlMfOKFsA")]
    [DisplayName("Variation Margin")]
    [IsoXmlTag("VartnMrgn")]
    public required CollateralProposalResponseType2 VariationMargin { get; init; }

    /// <summary>
    /// Provides the collateral proposal response for the segregated independent amount.
    /// </summary>
    [IsoId("_wmm3c2TUEeSSTJlMfOKFsA")]
    [DisplayName("Segregated Independent Amount")]
    [IsoXmlTag("SgrtdIndpdntAmt")]
    public CollateralProposalResponseType2? SegregatedIndependentAmount { get; init; }
}
