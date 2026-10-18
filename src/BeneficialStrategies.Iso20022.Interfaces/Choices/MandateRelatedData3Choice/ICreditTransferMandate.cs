// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.MandateRelatedData3Choice;

/// <summary>
/// Credit Transfer Mandate.
/// </summary>
public interface ICreditTransferMandate : IMandateRelatedData3Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// </summary>
    [IsoXmlTag("CdtTrfMndt")]
    ICreditTransferMandateData1 Value { get; }
}
