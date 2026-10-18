// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RestrictedProprietaryChoice;

/// <summary>
/// Proprietary identification of a pre-agreed level of service between the parties.
/// </summary>
[IsoId("_QJkwwNp-Ed-ak6NoX_4Aeg_1495592134")]
public interface IProprietary : IRestrictedProprietaryChoice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("Prtry")]
    Max35Text Value { get; }
}
