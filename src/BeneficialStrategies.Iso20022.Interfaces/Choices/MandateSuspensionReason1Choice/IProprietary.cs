// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.MandateSuspensionReason1Choice;

/// <summary>
/// Reason, in a proprietary form.
/// </summary>
[IsoId("_gW_7xIPDEeahmOIR_zFG6A")]
public interface IProprietary : IMandateSuspensionReason1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("Prtry")]
    IsoMax35Text Value { get; }
}
