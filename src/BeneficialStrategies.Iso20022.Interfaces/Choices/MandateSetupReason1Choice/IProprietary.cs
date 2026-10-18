// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.MandateSetupReason1Choice;

/// <summary>
/// Reason for the mandate setup, in a proprietary form.
/// </summary>
[IsoId("_iQq8Nz2OEeS6DKIV6SF6gw")]
public interface IProprietary : IMandateSetupReason1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 70characters.
    /// </summary>
    [IsoXmlTag("Prtry")]
    Max70Text Value { get; }
}
