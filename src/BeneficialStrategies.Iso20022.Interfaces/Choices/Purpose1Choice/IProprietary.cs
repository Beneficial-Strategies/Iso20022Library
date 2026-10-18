// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.Purpose1Choice;

/// <summary>
/// User community specific purpose.||Usage: When available, codes provided by local communities should be used.
/// </summary>
[IsoId("_PrK9gtp-Ed-ak6NoX_4Aeg_-607853495")]
public interface IProprietary : IPurpose1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("Prtry")]
    IsoMax35Text Value { get; }
}
