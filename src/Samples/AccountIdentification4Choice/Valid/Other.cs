// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022.Samples.AccountIdentification4Choice.Valid;

/// <summary>Valid samples of the <c>Other</c> variant of <c>AccountIdentification4Choice</c>.</summary>
public static class Other
{
    /// <summary>The Other variant of <c>AccountIdentification4Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IOther Minimal =>
        IsoDataFactory.Make<BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IOther>(b => b
                    .Set(x => x.Identification).To("ACCT-001"));

    /// <summary>The Other variant of <c>AccountIdentification4Choice</c> with more members set than Minimal. A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IOther Maximal =>
        IsoDataFactory.Make<BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IOther>(b => b
                    .Set(x => x.Identification).To("ACCT-001")
                    .Set(x => x.SchemeName).To(BeneficialStrategies.Iso20022.Samples.AccountSchemeName1Choice.Valid.Proprietary.Minimal));
}
