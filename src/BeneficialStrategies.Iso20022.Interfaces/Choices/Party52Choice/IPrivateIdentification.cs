// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.Party52Choice;

/// <summary>
/// Private Identification.
/// </summary>
public interface IPrivateIdentification : IParty52Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// </summary>
    [IsoXmlTag("PrvtId")]
    IPersonIdentification18 Value { get; }
}
