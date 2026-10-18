// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.ServiceLevel3Choice;

/// <summary>
/// Identification of a pre-agreed level of service between the parties in a coded form.
/// </summary>
[IsoId("_QJkwxdp-Ed-ak6NoX_4Aeg_1187501371")]
public interface ICode : IServiceLevel3Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the pre-agreed level of service between the parties.
    /// </summary>
    [IsoXmlTag("Cd")]
    ServiceLevel2Code Value { get; }
}
