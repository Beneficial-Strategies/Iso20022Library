// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.DateType2Choice;

/// <summary>
/// Code.
/// </summary>
public interface ICode : IDateType2Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// </summary>
    [IsoXmlTag("Cd")]
    ExternalDateType1Code Value { get; }
}
