// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.CryptographicKey1Choice.Valid;

/// <summary>Valid samples of <c>ILPV4</c> of <c>CryptographicKey1Choice</c>.</summary>
public static class ILPV4
{
    /// <summary>A valid <c>ILPV4</c> of <c>CryptographicKey1Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static Choices.CryptographicKey1Choice.IILPV4 Minimal =>
        IsoDataFactory.Make<Choices.CryptographicKey1Choice.IILPV4>(b => b
                .Set(x => x.Value).To("AB12"));
}
