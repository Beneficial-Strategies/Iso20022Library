// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides details about the proposal for the variation margin and optionaly the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(CollateralProposal4Choice.CollateralProposalDetails))]
    [KnownType(typeof(CollateralProposal4Choice.SegregatedIndependentAmount))]
    [JsonDerivedType(typeof(CollateralProposal4Choice.CollateralProposalDetails),nameof(CollateralProposal4Choice.CollateralProposalDetails))]
    [JsonDerivedType(typeof(CollateralProposal4Choice.SegregatedIndependentAmount),nameof(CollateralProposal4Choice.SegregatedIndependentAmount))]
    [IsoId("_xZ6mlYFvEeWtPe6Crjmeug")]
    [DisplayName("Collateral Proposal 4 Choice")]
    public abstract partial record CollateralProposal4Choice_
    {
    }
}
