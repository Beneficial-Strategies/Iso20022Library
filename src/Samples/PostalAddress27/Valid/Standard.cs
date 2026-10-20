// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022.Samples.PostalAddress27.Valid;

/// <summary>Valid samples of <c>Standard</c> of <c>PostalAddress27</c>.</summary>
public static class Standard
{
    /// <summary>A valid <c>Standard</c> of <c>PostalAddress27</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Components.IPostalAddress27 Minimal =>
        IsoDataFactory.Make<IPostalAddress27>(b4 => b4
                            .Set(x4 => x4.AddressType).To(BeneficialStrategies.Iso20022.Samples.AddressType3Choice.Valid.Proprietary.Maximal));
}
