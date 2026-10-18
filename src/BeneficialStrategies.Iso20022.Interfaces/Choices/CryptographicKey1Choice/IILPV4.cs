// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.CryptographicKey1Choice;

/// <summary>
/// ILPV4.
/// </summary>
public interface IILPV4 : ICryptographicKey1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// </summary>
    [IsoXmlTag("ILPV4")]
    HexBinaryText Value { get; }
}
