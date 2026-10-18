// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.Purpose2Choice;

/// <summary>
/// Purpose, in a proprietary form.
/// </summary>
[IsoId("_P6qyINp-Ed-ak6NoX_4Aeg_-1283223318")]
public interface IProprietary : IPurpose2Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("Prtry")]
    Max35Text Value { get; }
}
