// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.MandateSetupReason1Choice;

/// <summary>
/// Reason for the mandate setup, as published in an external reason code list.
/// </summary>
[IsoId("_iQq8NT2OEeS6DKIV6SF6gw")]
public interface ICode : IMandateSetupReason1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the external mandate setup reason code in the format of character string with a maximum length of 4 characters.
    /// External code sets can be downloaded from www.iso20022.org.
    /// </summary>
    [IsoXmlTag("Cd")]
    ExternalMandateSetupReason1Code Value { get; }
}
