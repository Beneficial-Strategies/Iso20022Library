// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the request of a key download from an ATM.
/// </summary>
[IsoId("_42YVYbToEeeQy4o2AayYHg")]
[DisplayName("ATM Key Download Request")]
public record ATMKeyDownloadRequest4
{
    /// <summary>
    /// Environment of the key download.
    /// </summary>
    [IsoId("_4_OvYbToEeeQy4o2AayYHg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment15 Environment { get; init; }

    /// <summary>
    /// Result of a maintenance command performed by the ATM.
    /// </summary>
    [IsoId("_4_OvY7ToEeeQy4o2AayYHg")]
    [DisplayName("Command Result")]
    [IsoXmlTag("CmdRslt")]
    public ValueList<ATMCommand11> CommandResult { get; init; } = [];

    /// <summary>
    /// Security command in progress inside which the key download is requested.
    /// </summary>
    [IsoId("_4_OvZbToEeeQy4o2AayYHg")]
    [DisplayName("Command Context")]
    [IsoXmlTag("CmdCntxt")]
    public ATMCommand12? CommandContext { get; init; }

    /// <summary>
    /// Context of the ATM for the key download.
    /// </summary>
    [IsoId("_4_OvZ7ToEeeQy4o2AayYHg")]
    [DisplayName("ATM Security Context")]
    [IsoXmlTag("ATMSctyCntxt")]
    public required ATMSecurityContext3 ATMSecurityContext { get; init; }

    /// <summary>
    /// Security parameters of the ATM for the initiated key download.
    /// </summary>
    [IsoId("_4_OvabToEeeQy4o2AayYHg")]
    [DisplayName("ATM Security Parameters")]
    [IsoXmlTag("ATMSctyParams")]
    public required SecurityParameters9 ATMSecurityParameters { get; init; }

    /// <summary>
    /// Random value from the host provided during a previous exchange.
    /// </summary>
    [IsoId("_4_Ova7ToEeeQy4o2AayYHg")]
    [DisplayName("Host Challenge")]
    [IsoXmlTag("HstChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? HostChallenge { get; init; }
}
