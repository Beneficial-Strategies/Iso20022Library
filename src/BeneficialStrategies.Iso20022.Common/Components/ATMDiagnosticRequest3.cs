// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Diagnostic Request3.
/// </summary>
[IsoId("_UftQ0aETEe-MRKYsaX6JDg")]
[DisplayName("ATM Diagnostic Request3")]
public record ATMDiagnosticRequest3
{
    /// <summary>
    /// ATM Global Status.
    /// </summary>
    [DisplayName("ATM Global Status")]
    [IsoXmlTag("ATMGblSts")]
    public required ATMStatus2 ATMGlobalStatus { get; init; }

    /// <summary>
    /// Environment.
    /// </summary>
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment9 Environment { get; init; }
}
