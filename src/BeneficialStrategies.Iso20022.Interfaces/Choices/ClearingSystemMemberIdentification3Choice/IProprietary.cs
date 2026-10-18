// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification3Choice;

/// <summary>
/// Identification Code for a clearing system, that has not yet been identified in the list of clearing systems.
/// </summary>
[IsoId("_TMehG9p-Ed-ak6NoX_4Aeg_-1563638498")]
public interface IProprietary : IClearingSystemMemberIdentification3Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("Prtry")]
    IsoMax35Text Value { get; }
}
