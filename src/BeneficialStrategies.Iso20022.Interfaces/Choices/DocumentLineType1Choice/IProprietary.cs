// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.DocumentLineType1Choice;

/// <summary>
/// Proprietary identification of the type of the remittance document.
/// </summary>
[IsoId("__rM9XabkEeKvUvwX_r3tzA")]
public interface IProprietary : IDocumentLineType1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("Prtry")]
    IsoMax35Text Value { get; }
}
