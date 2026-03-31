// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides details about the proposal for the variation margin and optionally the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(CollateralProposal6Choice.CollateralProposalDetails))]
    [KnownType(typeof(CollateralProposal6Choice.SegregatedIndependentAmount))]
    [JsonDerivedType(
        typeof(CollateralProposal6Choice.CollateralProposalDetails),
        nameof(CollateralProposal6Choice.CollateralProposalDetails)
    )]
    [JsonDerivedType(
        typeof(CollateralProposal6Choice.SegregatedIndependentAmount),
        nameof(CollateralProposal6Choice.SegregatedIndependentAmount)
    )]
    [IsoId("_5ZhwgSqREeyR9JrVGfaMKw")]
    [DisplayName("Collateral Proposal 6 Choice")]
    public abstract record CollateralProposal6Choice_ { }
}
