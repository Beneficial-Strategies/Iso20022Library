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
[IsoId("_xDwJX4FvEeWtPe6Crjmeug")]
[DisplayName("Proposal")]
public record Proposal4
{
    /// <summary>
    /// Indicates whether this is an initial or counter proposal.
    /// </summary>
    [IsoId("_xZ6mkYFvEeWtPe6Crjmeug")]
    [DisplayName("Collateral Proposal Type")]
    [IsoXmlTag("CollPrpslTp")]
    public required ProposalType1Code CollateralProposalType { get; init; }

    /// <summary>
    /// Provides details about the proposal for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [IsoId("_xZ6mk4FvEeWtPe6Crjmeug")]
    [DisplayName("Collateral Proposal")]
    [IsoXmlTag("CollPrpsl")]
    public required CollateralProposal4Choice_ CollateralProposal { get; init; }
}
