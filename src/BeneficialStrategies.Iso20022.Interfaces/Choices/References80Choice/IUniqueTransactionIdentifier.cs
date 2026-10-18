// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References80Choice;

/// <summary>
/// Unique Transaction Identifier.
/// </summary>
public interface IUniqueTransactionIdentifier : IReferences80Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// </summary>
    [IsoXmlTag("UnqTxIdr")]
    UTIIdentifier Value { get; }
}
