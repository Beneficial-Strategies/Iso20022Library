// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.Frequency21Choice;

/// <summary>
/// Frequency expressed as an ISO 20022 code.
/// </summary>
[IsoId("_6GkgAR7yEeSxevWRRWxNAg")]
public interface IType : IFrequency21Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the regularity of an event.
    /// </summary>
    [IsoXmlTag("Tp")]
    Frequency6Code Value { get; }
}
