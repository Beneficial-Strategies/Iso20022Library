// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.GarnishmentType1Choice;

/// <summary>
/// Proprietary identification of the type of garnishment.
/// </summary>
[IsoId("_lG0rRYnnEeOORMXOfBk1Bw")]
public interface IProprietary : IGarnishmentType1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("Prtry")]
    IsoMax35Text Value { get; }
}
