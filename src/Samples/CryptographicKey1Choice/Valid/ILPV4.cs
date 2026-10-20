// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022.Samples.CryptographicKey1Choice.Valid;

/// <summary>Valid samples of <c>ILPV4</c> of <c>CryptographicKey1Choice</c>.</summary>
public static class ILPV4
{
    /// <summary>A valid <c>ILPV4</c> of <c>CryptographicKey1Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Choices.CryptographicKey1Choice.IILPV4 Minimal =>
        IsoDataFactory.Make<BeneficialStrategies.Iso20022.Choices.CryptographicKey1Choice.IILPV4>(b => b
                .Set(x => x.Value).To("AB12"));
}
