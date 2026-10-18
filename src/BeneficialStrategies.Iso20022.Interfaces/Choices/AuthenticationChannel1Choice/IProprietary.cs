// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.AuthenticationChannel1Choice;

/// <summary>
/// Authentication channel expressed as a proprietary code.
/// </summary>
[IsoId("_U4Y95JdgEea1K6JAcAwoVg")]
public interface IProprietary : IAuthenticationChannel1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("Prtry")]
    IsoMax35Text Value { get; }
}
