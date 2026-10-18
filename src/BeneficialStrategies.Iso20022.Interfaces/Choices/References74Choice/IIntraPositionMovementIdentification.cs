// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References74Choice;

/// <summary>
/// Unambiguous identification of the intra-position movement transaction as known by the account owner (or instructing party acting on its behalf).
/// </summary>
[IsoId("_SiFNhSgaEey2k_sfZmJz4g")]
public interface IIntraPositionMovementIdentification : IReferences74Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("IntraPosMvmntId")]
    IsoMax35Text Value { get; }
}
