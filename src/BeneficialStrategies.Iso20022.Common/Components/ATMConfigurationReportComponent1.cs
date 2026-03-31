// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Configuration Report Component1.
/// </summary>
[IsoId("_eAI1MJ2lEe-4seDr3Li2Ew")]
[DisplayName("ATM Configuration Report Component1")]
public record ATMConfigurationReportComponent1
{
    /// <summary>
    /// Active Version.
    /// </summary>
    [DisplayName("Active Version")]
    [IsoXmlTag("ActvVrsn")]
    public IsoMax35Text? ActiveVersion { get; init; }

    /// <summary>
    /// Environment.
    /// </summary>
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment7 Environment { get; init; }

    /// <summary>
    /// Non Active Version.
    /// </summary>
    [DisplayName("Non Active Version")]
    [IsoXmlTag("NonActvVrsn")]
    public ValueList<ATMVersionReport1> NonActiveVersion { get; init; } = [];
}
