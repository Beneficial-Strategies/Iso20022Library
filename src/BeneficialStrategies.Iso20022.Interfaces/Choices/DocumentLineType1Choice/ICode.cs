// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.DocumentLineType1Choice;

/// <summary>
/// Line identification type in a coded form.
/// </summary>
[IsoId("__rM9WabkEeKvUvwX_r3tzA")]
public interface ICode : IDocumentLineType1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the document line type as published in an external document type code list.
    /// </summary>
    [IsoXmlTag("Cd")]
    ExternalDocumentLineType1Code Value { get; }
}
