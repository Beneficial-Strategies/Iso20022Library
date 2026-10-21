// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.AccountIdentification4Choice.Valid;

/// <summary>Valid samples of <c>Other</c> of <c>AccountIdentification4Choice</c>.</summary>
public static class Other
{
    /// <summary>A valid <c>Other</c> of <c>AccountIdentification4Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static Choices.AccountIdentification4Choice.IOther Minimal =>
        IsoDataFactory.Make<Choices.AccountIdentification4Choice.IOther>(b => b
                    .Set(x => x.Identification).To("ACCT-001"));

    /// <summary>A valid <c>Other</c> of <c>AccountIdentification4Choice</c> with more members set than Minimal. A new object on every access.</summary>
    public static Choices.AccountIdentification4Choice.IOther Maximal =>
        IsoDataFactory.Make<Choices.AccountIdentification4Choice.IOther>(b => b
                    .Set(x => x.Identification).To("ACCT-001")
                    .Set(x => x.SchemeName).To(Samples.AccountSchemeName1Choice.Valid.Proprietary.Minimal));
}
