// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the collateral proposal response for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(CollateralProposalResponse4Choice.CollateralProposal))]
    [KnownType(typeof(CollateralProposalResponse4Choice.SegregatedIndependentAmount))]
    [JsonDerivedType(typeof(CollateralProposalResponse4Choice.CollateralProposal),nameof(CollateralProposalResponse4Choice.CollateralProposal))]
    [JsonDerivedType(typeof(CollateralProposalResponse4Choice.SegregatedIndependentAmount),nameof(CollateralProposalResponse4Choice.SegregatedIndependentAmount))]
    [IsoId("_vsq8gStIEeyOa655cLd-DQ")]
    [DisplayName("Collateral Proposal Response 4 Choice")]
    public abstract partial record CollateralProposalResponse4Choice_
    {
    }
}
