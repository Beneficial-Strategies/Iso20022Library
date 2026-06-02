// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the report from an ATM device.
/// </summary>
[IsoId("_DNLgUbZ5EfCUZfsQO4rYeA")]
[DisplayName("ATM Device Report5")]
public record ATMDeviceReport5
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_DOPQQbZ5EfCUZfsQO4rYeA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment6 Environment { get; init; }

    /// <summary>
    /// Global status of the ATM.
    /// </summary>
    [IsoId("_DOPQQ7Z5EfCUZfsQO4rYeA")]
    [DisplayName("ATM Global Status")]
    [IsoXmlTag("ATMGblSts")]
    public required ATMStatus2 ATMGlobalStatus { get; init; }

    /// <summary>
    /// Result of a maintenance command performed by the ATM.
    /// </summary>
    [IsoId("_DOPQRbZ5EfCUZfsQO4rYeA")]
    [DisplayName("Command Result")]
    [IsoXmlTag("CmdRslt")]
    public ValueList<ATMCommand15> CommandResult { get; init; } = [];

    /// <summary>
    /// Maintenance command which has requested the device report.
    /// </summary>
    [IsoId("_DOPQR7Z5EfCUZfsQO4rYeA")]
    [DisplayName("Command Context")]
    [IsoXmlTag("CmdCntxt")]
    public ATMCommand16? CommandContext { get; init; }

    /// <summary>
    /// Information related to security commands.
    /// </summary>
    [IsoId("_DOPQSbZ5EfCUZfsQO4rYeA")]
    [DisplayName("ATM Security Context")]
    [IsoXmlTag("ATMSctyCntxt")]
    public ATMSecurityContext6? ATMSecurityContext { get; init; }
}
