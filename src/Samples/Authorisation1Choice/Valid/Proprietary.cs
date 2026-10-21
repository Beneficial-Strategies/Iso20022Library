// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.Authorisation1Choice.Valid;

/// <summary>Valid samples of <c>Proprietary</c> of <c>Authorisation1Choice</c>.</summary>
public static class Proprietary
{
    /// <summary>A valid <c>Proprietary</c> of <c>Authorisation1Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static Choices.Authorisation1Choice.IProprietary Minimal =>
        IsoDataFactory.Make<Choices.Authorisation1Choice.IProprietary>(b => b
                    .Set(x => x.Value).To("LEVEL2"));
}
