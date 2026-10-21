// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.BranchData5.Valid;

/// <summary>Valid samples of <c>Standard</c> of <c>BranchData5</c>.</summary>
public static class Standard
{
    /// <summary>A valid <c>Standard</c> of <c>BranchData5</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static IBranchData5 Minimal =>
        IsoDataFactory.Make<IBranchData5>(b3 => b3
                        .Set(x3 => x3.PostalAddress).To(Samples.PostalAddress27.Valid.Standard.Minimal));
}
