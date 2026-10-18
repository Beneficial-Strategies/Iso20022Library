// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.ServiceLevel8Choice;

/// <summary>
/// Specifies a pre-agreed service or level of service between the parties, as a proprietary code.
/// </summary>
[IsoId("_QJa_ztp-Ed-ak6NoX_4Aeg_1912716994")]
public interface IProprietary : IServiceLevel8Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("Prtry")]
    IsoMax35Text Value { get; }
}
