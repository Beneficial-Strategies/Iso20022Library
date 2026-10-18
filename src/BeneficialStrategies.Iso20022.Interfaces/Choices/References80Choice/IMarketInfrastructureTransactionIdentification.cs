// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References80Choice;

/// <summary>
/// Market Infrastructure Transaction Identification.
/// </summary>
public interface IMarketInfrastructureTransactionIdentification : IReferences80Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// </summary>
    [IsoXmlTag("MktInfrstrctrTxId")]
    IsoMax35Text Value { get; }
}
