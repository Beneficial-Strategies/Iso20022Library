// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.DocumentAmountType1Choice;

/// <summary>
/// Specifies the amount type, in a free-text form.
/// </summary>
public interface IProprietary : IDocumentAmountType1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the amount type, in a free-text form.
    /// </summary>
    [IsoXmlTag("Prtry")]
    Max35Text Value { get; }
}
