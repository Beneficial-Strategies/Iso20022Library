// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022.Samples.Party50Choice.Valid;

/// <summary>Valid samples of <c>Agent</c> of <c>Party50Choice</c>.</summary>
public static class Agent
{
    /// <summary>A valid <c>Agent</c> of <c>Party50Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Choices.Party50Choice.IAgent Minimal =>
        IsoDataFactory.Make<Choices.Party50Choice.IAgent>(b => b
                .Set(x => x.Value).To(BeneficialStrategies.Iso20022.Samples.BranchAndFinancialInstitutionIdentification8.Valid.Standard.Minimal));

    /// <summary>A valid <c>Agent</c> of <c>Party50Choice</c> with more members set than Minimal. A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Choices.Party50Choice.IAgent Maximal =>
        IsoDataFactory.Make<Choices.Party50Choice.IAgent>(b => b
                .Set(x => x.Value).To(BeneficialStrategies.Iso20022.Samples.BranchAndFinancialInstitutionIdentification8.Valid.Standard.Maximal));
}
