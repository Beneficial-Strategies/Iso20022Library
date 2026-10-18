// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.Authorisation1Choice;

/// <summary>
/// Specifies the authorisation, in a free text form.
/// </summary>
[IsoId("_RD_KkNp-Ed-ak6NoX_4Aeg_-955120080")]
public interface IProprietary : IAuthorisation1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 128 characters.
    /// </summary>
    [IsoXmlTag("Prtry")]
    IsoMax128Text Value { get; }
}
