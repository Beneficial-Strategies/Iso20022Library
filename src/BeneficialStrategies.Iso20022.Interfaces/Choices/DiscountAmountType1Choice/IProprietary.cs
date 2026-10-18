// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.DiscountAmountType1Choice;

/// <summary>
/// Specifies the amount type, in a free-text form.
/// </summary>
[IsoId("_tlra8VkyEeGeoaLUQk__nA_-32058975")]
public interface IProprietary : IDiscountAmountType1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("Prtry")]
    Max35Text Value { get; }
}
