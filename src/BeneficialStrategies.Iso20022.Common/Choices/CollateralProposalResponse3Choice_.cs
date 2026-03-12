// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the collateral proposal response for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(CollateralProposalResponse3Choice.CollateralProposal))]
    [KnownType(typeof(CollateralProposalResponse3Choice.SegregatedIndependentAmount))]
    [JsonDerivedType(typeof(CollateralProposalResponse3Choice.CollateralProposal),nameof(CollateralProposalResponse3Choice.CollateralProposal))]
    [JsonDerivedType(typeof(CollateralProposalResponse3Choice.SegregatedIndependentAmount),nameof(CollateralProposalResponse3Choice.SegregatedIndependentAmount))]
    [IsoId("_sO0cMYpDEeaNTaanBSMWmg")]
    [DisplayName("Collateral Proposal Response 3 Choice")]
    public abstract partial record CollateralProposalResponse3Choice_
    {
    }
}
