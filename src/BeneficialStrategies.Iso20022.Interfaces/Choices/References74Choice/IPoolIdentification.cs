// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References74Choice;

/// <summary>
/// Collective reference identifying a set of messages.
/// </summary>
[IsoId("_SiFNmSgaEey2k_sfZmJz4g")]
public interface IPoolIdentification : IReferences74Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("PoolId")]
    IsoMax35Text Value { get; }
}
