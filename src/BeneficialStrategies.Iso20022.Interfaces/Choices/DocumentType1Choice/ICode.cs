// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.DocumentType1Choice;

/// <summary>
/// Document type, in a coded form.
/// </summary>
[IsoId("_iYH70HiJEeidzqjNEfehPg")]
public interface ICode : IDocumentType1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the document type as published in an external document type code list.
    /// External code sets can be downloaded from www.iso20022.org.
    /// </summary>
    [IsoXmlTag("Cd")]
    ExternalDocumentType1Code Value { get; }
}
