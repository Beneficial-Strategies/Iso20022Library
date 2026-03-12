// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides details about the proposal for the variation margin and optionaly the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(CollateralProposal3Choice.CollateralProposalDetails))]
    [KnownType(typeof(CollateralProposal3Choice.SegregatedIndependentAmount))]
    [JsonDerivedType(typeof(CollateralProposal3Choice.CollateralProposalDetails),nameof(CollateralProposal3Choice.CollateralProposalDetails))]
    [JsonDerivedType(typeof(CollateralProposal3Choice.SegregatedIndependentAmount),nameof(CollateralProposal3Choice.SegregatedIndependentAmount))]
    [IsoId("_PYHrBV9-EeSMgPeFpRHeJw")]
    [DisplayName("Collateral Proposal 3 Choice")]
    public abstract partial record CollateralProposal3Choice_
    {
    }
}
