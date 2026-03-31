// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the type of proposal and if the proposal is for the variation margin and the segregated independent amount, or the segregated independent amount only.
/// </summary>
[IsoId("_O7jq0V9-EeSMgPeFpRHeJw")]
[DisplayName("Proposal")]
public record Proposal3
{
    /// <summary>
    /// Indicates whether this is an initial or counter proposal.
    /// </summary>
    [IsoId("_PYHrAV9-EeSMgPeFpRHeJw")]
    [DisplayName("Collateral Proposal Type")]
    [IsoXmlTag("CollPrpslTp")]
    public required ProposalType1Code CollateralProposalType { get; init; }

    /// <summary>
    /// Provides details about the proposal for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [IsoId("_PYHrA19-EeSMgPeFpRHeJw")]
    [DisplayName("Collateral Proposal")]
    [IsoXmlTag("CollPrpsl")]
    public required CollateralProposal3Choice_ CollateralProposal { get; init; }
}
