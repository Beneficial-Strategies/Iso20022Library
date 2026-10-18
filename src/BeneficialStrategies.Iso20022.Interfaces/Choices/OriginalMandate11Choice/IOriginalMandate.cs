// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.OriginalMandate11Choice;

/// <summary>
/// Original Mandate.
/// </summary>
public interface IOriginalMandate : IOriginalMandate11Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// </summary>
    [IsoXmlTag("OrgnlMndt")]
    IMandate22 Value { get; }
}
