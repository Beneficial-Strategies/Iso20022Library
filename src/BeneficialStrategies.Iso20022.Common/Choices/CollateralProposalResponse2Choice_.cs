// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the collateral proposal response for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(CollateralProposalResponse2Choice.CollateralProposal))]
    [KnownType(typeof(CollateralProposalResponse2Choice.SegregatedIndependentAmount))]
    [JsonDerivedType(
        typeof(CollateralProposalResponse2Choice.CollateralProposal),
        nameof(CollateralProposalResponse2Choice.CollateralProposal)
    )]
    [JsonDerivedType(
        typeof(CollateralProposalResponse2Choice.SegregatedIndependentAmount),
        nameof(CollateralProposalResponse2Choice.SegregatedIndependentAmount)
    )]
    [IsoId("_vOOvQWTUEeSSTJlMfOKFsA")]
    [DisplayName("Collateral Proposal Response 2 Choice")]
    public abstract record CollateralProposalResponse2Choice_ { }
}
