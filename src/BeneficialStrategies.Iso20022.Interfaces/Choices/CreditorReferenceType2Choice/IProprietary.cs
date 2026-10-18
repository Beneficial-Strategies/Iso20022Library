// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.CreditorReferenceType2Choice;

/// <summary>
/// Type of creditor reference, in a proprietary form.
/// </summary>
public interface IProprietary : ICreditorReferenceType2Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Type of creditor reference, in a proprietary form.
    /// </summary>
    [IsoXmlTag("Prtry")]
    IsoMax35Text Value { get; }
}
