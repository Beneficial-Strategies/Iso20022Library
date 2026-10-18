// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.MandateStatus1Choice;

/// <summary>
/// Name of the identification scheme, in a free text form.
/// </summary>
[IsoId("_ChH7ZZnAEeao_Z127E9uYg")]
public interface IProprietary : IMandateStatus1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("Prtry")]
    IsoMax35Text Value { get; }
}
