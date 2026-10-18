// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.CashAccountType2Choice;

/// <summary>
/// Nature or use of the account in a proprietary form.
/// </summary>
[IsoId("_scEHgFkyEeGeoaLUQk__nA_1436723705")]
public interface IProprietary : ICashAccountType2Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("Prtry")]
    Max35Text Value { get; }
}
