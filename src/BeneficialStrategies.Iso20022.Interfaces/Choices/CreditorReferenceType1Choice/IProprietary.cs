// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.CreditorReferenceType1Choice;

/// <summary>
/// Creditor reference type, in a proprietary form.
/// </summary>
[IsoId("_T4ItMdp-Ed-ak6NoX_4Aeg_651436979")]
public interface IProprietary : ICreditorReferenceType1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("Prtry")]
    IsoMax35Text Value { get; }
}
