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
[IsoId("_FGk3EIreEeSvuOJS0mmL0g")]
[DisplayName("ATM Device Report")]
public record ATMDeviceReport1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_Aq3EQIrfEeSvuOJS0mmL0g")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment6 Environment { get; init; }

    /// <summary>
    /// Global status of the ATM.
    /// </summary>
    [IsoId("_FtzfEIryEeSvuOJS0mmL0g")]
    [DisplayName("ATM Global Status")]
    [IsoXmlTag("ATMGblSts")]
    public required ATMStatus1 ATMGlobalStatus { get; init; }

    /// <summary>
    /// Result of a maintenance command performed by the ATM.
    /// </summary>
    [IsoId("_2agesIryEeSvuOJS0mmL0g")]
    [DisplayName("Command Result")]
    [IsoXmlTag("CmdRslt")]
    public ATMCommand2? CommandResult { get; init; }

    /// <summary>
    /// Maintenance command which has requested the device report.
    /// </summary>
    [IsoId("_WAO9AIr4EeSvuOJS0mmL0g")]
    [DisplayName("Command Context")]
    [IsoXmlTag("CmdCntxt")]
    public ATMCommand3? CommandContext { get; init; }

    /// <summary>
    /// Information related to security commands.
    /// </summary>
    [IsoId("_tOsAoIr4EeSvuOJS0mmL0g")]
    [DisplayName("ATM Security Context")]
    [IsoXmlTag("ATMSctyCntxt")]
    public ATMSecurityContext1? ATMSecurityContext { get; init; }
}
