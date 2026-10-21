// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.AccountIdentification4Choice.Valid;

/// <summary>Valid samples of <c>IBAN</c> of <c>AccountIdentification4Choice</c>.</summary>
public static class IBAN
{
    /// <summary>A valid <c>IBAN</c> of <c>AccountIdentification4Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static Choices.AccountIdentification4Choice.IIBAN Minimal =>
        IsoDataFactory.Make<Choices.AccountIdentification4Choice.IIBAN>(b => b
                    .Set(x => x.Value).To("DE89370400440532013000"));

    /// <summary>A valid <c>IBAN</c> of <c>AccountIdentification4Choice</c> with more members set than Minimal. A new object on every access.</summary>
    public static Choices.AccountIdentification4Choice.IIBAN Maximal =>
        IsoDataFactory.Make<Choices.AccountIdentification4Choice.IIBAN>(b4 => b4
                        .Set(x4 => x4.Value).To("DE89370400440532013000"));
}
