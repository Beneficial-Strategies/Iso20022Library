// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.CategoryPurpose1Choice;

/// <summary>
/// Category purpose, in a proprietary form.
/// </summary>
[IsoId("_THaa5tp-Ed-ak6NoX_4Aeg_1621974146")]
public interface IProprietary : ICategoryPurpose1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("Prtry")]
    Max35Text Value { get; }
}
