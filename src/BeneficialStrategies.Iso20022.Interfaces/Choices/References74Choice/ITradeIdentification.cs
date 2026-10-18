// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References74Choice;

/// <summary>
/// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
/// </summary>
[IsoId("_SiFNqSgaEey2k_sfZmJz4g")]
public interface ITradeIdentification : IReferences74Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 52 characters.
    /// </summary>
    [IsoXmlTag("TradId")]
    Max52Text Value { get; }
}
