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
[IsoId("_mOcRQbTlEeeQy4o2AayYHg")]
[DisplayName("ATM Device Report")]
public record ATMDeviceReport3
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_mXKIYbTlEeeQy4o2AayYHg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment6 Environment { get; init; }

    /// <summary>
    /// Global status of the ATM.
    /// </summary>
    [IsoId("_mXKIY7TlEeeQy4o2AayYHg")]
    [DisplayName("ATM Global Status")]
    [IsoXmlTag("ATMGblSts")]
    public required ATMStatus1 ATMGlobalStatus { get; init; }

    /// <summary>
    /// Result of a maintenance command performed by the ATM.
    /// </summary>
    [IsoId("_mXKIZbTlEeeQy4o2AayYHg")]
    [DisplayName("Command Result")]
    [IsoXmlTag("CmdRslt")]
    public ATMCommand11? CommandResult { get; init; }

    /// <summary>
    /// Maintenance command which has requested the device report.
    /// </summary>
    [IsoId("_mXKIZ7TlEeeQy4o2AayYHg")]
    [DisplayName("Command Context")]
    [IsoXmlTag("CmdCntxt")]
    public ATMCommand12? CommandContext { get; init; }

    /// <summary>
    /// Information related to security commands.
    /// </summary>
    [IsoId("_mXKIabTlEeeQy4o2AayYHg")]
    [DisplayName("ATM Security Context")]
    [IsoXmlTag("ATMSctyCntxt")]
    public ATMSecurityContext5? ATMSecurityContext { get; init; }
}
