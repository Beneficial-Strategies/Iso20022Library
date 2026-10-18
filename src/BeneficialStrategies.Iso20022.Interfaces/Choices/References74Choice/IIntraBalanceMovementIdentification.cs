// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References74Choice;

/// <summary>
/// Unambiguous identification of the intra balance movement transaction as known by the account owner.
/// </summary>
[IsoId("_SiFNhygaEey2k_sfZmJz4g")]
public interface IIntraBalanceMovementIdentification : IReferences74Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("IntraBalMvmntId")]
    Max35Text Value { get; }
}
