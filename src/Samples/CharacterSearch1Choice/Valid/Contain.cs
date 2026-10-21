// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.CharacterSearch1Choice.Valid;

/// <summary>Valid samples of <c>Contain</c> of <c>CharacterSearch1Choice</c>.</summary>
public static class Contain
{
    /// <summary>A valid <c>Contain</c> of <c>CharacterSearch1Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static Choices.CharacterSearch1Choice.IContain Minimal =>
        IsoDataFactory.Make<Choices.CharacterSearch1Choice.IContain>(b => b
                .Set(x => x.Value).To("PART"));
}
