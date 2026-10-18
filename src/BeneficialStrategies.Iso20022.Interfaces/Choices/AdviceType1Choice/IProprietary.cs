// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.AdviceType1Choice;

/// <summary>
/// Advice type, in a proprietary form.
/// </summary>
[IsoId("_u3TXxdomEembTrt_WixjyQ")]
public interface IProprietary : IAdviceType1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("Prtry")]
    IsoMax35Text Value { get; }
}
