// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References80Choice;

/// <summary>
/// Intra Position Movement Identification.
/// </summary>
public interface IIntraPositionMovementIdentification : IReferences80Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// </summary>
    [IsoXmlTag("IntraPosMvmntId")]
    IsoMax35Text Value { get; }
}
