// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.ServiceLevel3Choice;

/// <summary>
/// Proprietary identification of a pre-agreed level of service between the parties.
/// </summary>
[IsoId("_QJkwxtp-Ed-ak6NoX_4Aeg_1187501430")]
public interface IProprietary : IServiceLevel3Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("Prtry")]
    IsoMax35Text Value { get; }
}
