// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022.Samples.AddressType3Choice.Valid;

/// <summary>Valid samples of <c>Proprietary</c> of <c>AddressType3Choice</c>.</summary>
public static class Proprietary
{
    /// <summary>A valid <c>Proprietary</c> of <c>AddressType3Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Choices.AddressType3Choice.IProprietary Minimal =>
        IsoDataFactory.Make<BeneficialStrategies.Iso20022.Choices.AddressType3Choice.IProprietary>(b => b
                    .Set(x => x.Identification).To("AB12")
                    .Set(x => x.Issuer).To("IssuerX"));

    /// <summary>A valid <c>Proprietary</c> of <c>AddressType3Choice</c> with more members set than Minimal. A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Choices.AddressType3Choice.IProprietary Maximal =>
        IsoDataFactory.Make<Choices.AddressType3Choice.IProprietary>(b5 => b5
                                .Set(x5 => x5.Identification).To("AB12")
                                .Set(x5 => x5.Issuer).To("IssuerX"));
}
