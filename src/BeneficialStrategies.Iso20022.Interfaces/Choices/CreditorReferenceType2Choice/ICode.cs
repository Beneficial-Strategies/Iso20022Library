// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.CreditorReferenceType2Choice;

/// <summary>
/// Type of creditor reference, as published in an external creditor reference type code set.
/// </summary>
public interface ICode : ICreditorReferenceType2Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Type of creditor reference, as published in an external creditor reference type code set.
    /// </summary>
    [IsoXmlTag("Cd")]
    ExternalCreditorReferenceType1Code Value { get; }
}
