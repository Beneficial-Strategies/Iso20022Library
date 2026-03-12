// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the collateral proposal response for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(CollateralProposalResponse1Choice.CollateralProposalDetails))]
    [KnownType(typeof(CollateralProposalResponse1Choice.SegregatedIndependentAmount))]
    [JsonDerivedType(typeof(CollateralProposalResponse1Choice.CollateralProposalDetails),nameof(CollateralProposalResponse1Choice.CollateralProposalDetails))]
    [JsonDerivedType(typeof(CollateralProposalResponse1Choice.SegregatedIndependentAmount),nameof(CollateralProposalResponse1Choice.SegregatedIndependentAmount))]
    [IsoId("_QmU-Ndp-Ed-ak6NoX_4Aeg_651195634")]
    [DisplayName("Collateral Proposal Response 1 Choice")]
    public abstract partial record CollateralProposalResponse1Choice_
    {
    }
}
