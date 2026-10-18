// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.Frequency37Choice;

/// <summary>
/// Frequency expressed as an ISO 20022 code.
/// </summary>
[IsoId("_GlS6xWoFEearR-CA7eRZXQ")]
public interface ICode : IFrequency37Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the regularity of an event.
    /// </summary>
    [IsoXmlTag("Cd")]
    Frequency10Code Value { get; }
}
