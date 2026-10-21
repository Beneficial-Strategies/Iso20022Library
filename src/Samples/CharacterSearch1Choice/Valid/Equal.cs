// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.CharacterSearch1Choice.Valid;

/// <summary>Valid samples of <c>Equal</c> of <c>CharacterSearch1Choice</c>.</summary>
public static class Equal
{
    /// <summary>A valid <c>Equal</c> of <c>CharacterSearch1Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static Choices.CharacterSearch1Choice.IEqual Minimal =>
        IsoDataFactory.Make<Choices.CharacterSearch1Choice.IEqual>(b => b
                .Set(x => x.Value).To("SUBJECT"));
}
