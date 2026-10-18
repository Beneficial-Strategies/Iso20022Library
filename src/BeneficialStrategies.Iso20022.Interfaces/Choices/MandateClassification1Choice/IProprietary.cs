// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.MandateClassification1Choice;

/// <summary>
/// Category purpose, in a proprietary form.
/// </summary>
[IsoId("_JThthGoDEearR-CA7eRZXQ")]
public interface IProprietary : IMandateClassification1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("Prtry")]
    Max35Text Value { get; }
}
