// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.AccountSchemeName1Choice.Valid;

/// <summary>Valid samples of <c>Proprietary</c> of <c>AccountSchemeName1Choice</c>.</summary>
public static class Proprietary
{
    /// <summary>A valid <c>Proprietary</c> of <c>AccountSchemeName1Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static Choices.AccountSchemeName1Choice.IProprietary Minimal =>
        IsoDataFactory.Make<Choices.AccountSchemeName1Choice.IProprietary>(b2 => b2
                        .Set(x2 => x2.Value).To("MYACCTSCHEME"));
}
