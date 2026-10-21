// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.CategoryPurpose1Choice.Valid;

/// <summary>Valid samples of <c>Code</c> of <c>CategoryPurpose1Choice</c>.</summary>
public static class Code
{
    /// <summary>A valid <c>Code</c> of <c>CategoryPurpose1Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static Choices.CategoryPurpose1Choice.ICode Minimal =>
        IsoDataFactory.Make<Choices.CategoryPurpose1Choice.ICode>(b => b
                    .Set(x => x.Value).To(ExternalCategoryPurpose1Code.BonusPayment));
}
