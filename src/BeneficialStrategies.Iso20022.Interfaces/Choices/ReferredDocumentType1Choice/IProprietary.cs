// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.ReferredDocumentType1Choice;

/// <summary>
/// Proprietary identification of the type of the remittance document.
/// </summary>
[IsoId("_T3sBR9p-Ed-ak6NoX_4Aeg_174928207")]
public interface IProprietary : IReferredDocumentType1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("Prtry")]
    Max35Text Value { get; }
}
