// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.CryptographicKey1Choice;

/// <summary>
/// Signature.
/// </summary>
public interface ISignature : ICryptographicKey1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// </summary>
    [IsoXmlTag("Sgntr")]
    SHA256SignatureText Value { get; }
}
