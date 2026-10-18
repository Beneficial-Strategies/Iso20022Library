// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.OriginalMandate11Choice;

/// <summary>
/// Original Mandate Identification.
/// </summary>
public interface IOriginalMandateIdentification : IOriginalMandate11Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// </summary>
    [IsoXmlTag("OrgnlMndtId")]
    IsoMax35Text Value { get; }
}
