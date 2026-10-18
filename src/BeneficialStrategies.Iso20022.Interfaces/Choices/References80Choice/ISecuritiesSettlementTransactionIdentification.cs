// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References80Choice;

/// <summary>
/// Securities Settlement Transaction Identification.
/// </summary>
public interface ISecuritiesSettlementTransactionIdentification : IReferences80Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// </summary>
    [IsoXmlTag("SctiesSttlmTxId")]
    Max35Text Value { get; }
}
