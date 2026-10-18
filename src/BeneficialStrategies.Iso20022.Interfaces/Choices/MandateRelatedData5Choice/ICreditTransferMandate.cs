// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.MandateRelatedData5Choice;

/// <summary>Specific credit transfer mandate data.</summary>
[IsoId("_RH9Ek7vIEfCYYbmqNrQFSg")]
public interface ICreditTransferMandate : IMandateRelatedData5Choice, IIsoChoiceVariant
{
    /// <summary>Contains the main value for the container.</summary>
    [IsoXmlTag("CdtTrfMndt")]
    ICreditTransferMandateData1 Value { get; }
}
