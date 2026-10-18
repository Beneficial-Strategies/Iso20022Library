// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.CreditorReferenceType1Choice;

/// <summary>
/// Type of creditor reference, in a coded form.
/// </summary>
[IsoId("_T4ItMNp-Ed-ak6NoX_4Aeg_651436918")]
public interface ICode : ICreditorReferenceType1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a type of financial or commercial document.
    /// </summary>
    [IsoXmlTag("Cd")]
    DocumentType3Code Value { get; }
}
