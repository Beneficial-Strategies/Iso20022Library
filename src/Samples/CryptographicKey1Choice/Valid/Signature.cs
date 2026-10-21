// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.CryptographicKey1Choice.Valid;

/// <summary>Valid samples of <c>Signature</c> of <c>CryptographicKey1Choice</c>.</summary>
public static class Signature
{
    /// <summary>A valid <c>Signature</c> of <c>CryptographicKey1Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static Choices.CryptographicKey1Choice.ISignature Minimal =>
        IsoDataFactory.Make<Choices.CryptographicKey1Choice.ISignature>(b => b
                .Set(x => x.Value).To(new string('A', 64)));
}
