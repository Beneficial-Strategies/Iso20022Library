// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References74Choice;

/// <summary>
/// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
/// </summary>
[IsoId("_SiFNkSgaEey2k_sfZmJz4g")]
public interface IMarketInfrastructureTransactionIdentification : IReferences74Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("MktInfrstrctrTxId")]
    Max35Text Value { get; }
}
