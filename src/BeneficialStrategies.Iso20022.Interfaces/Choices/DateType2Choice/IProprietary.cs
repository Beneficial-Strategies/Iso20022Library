// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.DateType2Choice;

/// <summary>
/// Proprietary.
/// </summary>
public interface IProprietary : IDateType2Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// </summary>
    [IsoXmlTag("Prtry")]
    Max35Text Value { get; }
}
