// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.DocumentType2Choice;

/// <summary>
/// Code.
/// </summary>
public interface ICode : IDocumentType2Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// </summary>
    [IsoXmlTag("Cd")]
    ExternalDocumentType1Code Value { get; }
}
