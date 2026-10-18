// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PersonIdentificationSchemeName1Choice;

/// <summary>
/// Name of the identification scheme, in a free text form.
/// </summary>
[IsoId("_P_4pRdp-Ed-ak6NoX_4Aeg_2056543469")]
public interface IProprietary : IPersonIdentificationSchemeName1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("Prtry")]
    Max35Text Value { get; }
}
