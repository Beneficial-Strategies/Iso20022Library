// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.Frequency36Choice;

/// <summary>
/// Specifies a frequency in terms of a specified period type.
/// </summary>
[IsoId("_seR6MWk2Eeanu6HLe77Rkg")]
public interface IType : IFrequency36Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the regularity of an event.
    /// </summary>
    [IsoXmlTag("Tp")]
    Frequency6Code Value { get; }
}
