// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022.Samples.BranchData5.Valid;

/// <summary>Valid samples of <c>Standard</c> of <c>BranchData5</c>.</summary>
public static class Standard
{
    /// <summary>A valid <c>Standard</c> of <c>BranchData5</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Components.IBranchData5 Minimal =>
        IsoDataFactory.Make<IBranchData5>(b3 => b3
                        .Set(x3 => x3.PostalAddress).To(BeneficialStrategies.Iso20022.Samples.PostalAddress27.Valid.Standard.Minimal));
}
