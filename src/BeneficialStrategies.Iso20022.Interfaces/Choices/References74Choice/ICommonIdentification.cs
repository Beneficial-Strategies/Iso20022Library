// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References74Choice;

/// <summary>
/// Unique reference agreed upon by the two trade counterparties to identify the trade.
/// </summary>
[IsoId("_SiFNoSgaEey2k_sfZmJz4g")]
public interface ICommonIdentification : IReferences74Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("CmonId")]
    Max35Text Value { get; }
}
