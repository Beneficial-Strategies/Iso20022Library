// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.ReferredDocumentType3Choice;

/// <summary>
/// Document type in a coded form.
/// </summary>
[IsoId("_YCiq4x77EeSxevWRRWxNAg")]
public interface ICode : IReferredDocumentType3Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a type of financial or commercial document.
    /// </summary>
    [IsoXmlTag("Cd")]
    DocumentType6Code Value { get; }
}
