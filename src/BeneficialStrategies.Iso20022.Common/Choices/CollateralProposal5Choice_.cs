// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides details about the proposal for the variation margin and optionally the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(CollateralProposal5Choice.CollateralProposalDetails))]
    [KnownType(typeof(CollateralProposal5Choice.SegregatedIndependentAmount))]
    [JsonDerivedType(
        typeof(CollateralProposal5Choice.CollateralProposalDetails),
        nameof(CollateralProposal5Choice.CollateralProposalDetails)
    )]
    [JsonDerivedType(
        typeof(CollateralProposal5Choice.SegregatedIndependentAmount),
        nameof(CollateralProposal5Choice.SegregatedIndependentAmount)
    )]
    [IsoId("_ratsdYpIEeaNTaanBSMWmg")]
    [DisplayName("Collateral Proposal 5 Choice")]
    public abstract record CollateralProposal5Choice_ { }
}
