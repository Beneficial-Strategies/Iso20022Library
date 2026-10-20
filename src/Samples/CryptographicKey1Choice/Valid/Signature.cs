// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022.Samples.CryptographicKey1Choice.Valid;

/// <summary>Valid samples of the <c>Signature</c> variant of <c>CryptographicKey1Choice</c>.</summary>
public static class Signature
{
    /// <summary>The Signature variant of <c>CryptographicKey1Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Choices.CryptographicKey1Choice.ISignature Minimal =>
        IsoDataFactory.Make<BeneficialStrategies.Iso20022.Choices.CryptographicKey1Choice.ISignature>(b => b
                .Set(x => x.Value).To(new string('A', 64)));
}
