// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.ReturnReason1Choice;

/// <summary>
/// Reason for the return not catered for by the available codes.
/// </summary>
[IsoId("_TOt8wNp-Ed-ak6NoX_4Aeg_191375064")]
public interface IProprietary : IReturnReason1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("Prtry")]
    Max35Text Value { get; }
}
