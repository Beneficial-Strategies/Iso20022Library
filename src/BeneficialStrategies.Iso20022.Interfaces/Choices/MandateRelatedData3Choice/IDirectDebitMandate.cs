// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.MandateRelatedData3Choice;

/// <summary>
/// Direct Debit Mandate.
/// </summary>
public interface IDirectDebitMandate : IMandateRelatedData3Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// </summary>
    [IsoXmlTag("DrctDbtMndt")]
    IMandateRelatedInformation16 Value { get; }
}
