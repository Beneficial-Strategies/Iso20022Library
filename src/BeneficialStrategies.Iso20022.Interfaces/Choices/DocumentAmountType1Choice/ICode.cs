// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.DocumentAmountType1Choice;

/// <summary>
/// Specifies the amount type, as published in an external referred amount code set.
/// </summary>
public interface ICode : IDocumentAmountType1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the amount type, as published in an external referred amount code set.
    /// </summary>
    [IsoXmlTag("Cd")]
    ExternalDocumentAmountType1Code Value { get; }
}
