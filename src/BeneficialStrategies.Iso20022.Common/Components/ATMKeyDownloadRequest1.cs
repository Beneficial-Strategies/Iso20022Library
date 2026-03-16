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
[IsoId("_5pWRQItKEeSxlKlAGYErFg")]
[DisplayName("ATM Key Download Request")]
public record ATMKeyDownloadRequest1
{
    /// <summary>
    /// Environment of the key download.
    /// </summary>
    [IsoId("_VenH8ItLEeSxlKlAGYErFg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment8 Environment { get; init; }

    /// <summary>
    /// Result of a maintenance command performed by the ATM.
    /// </summary>
    [IsoId("_2oXXEItLEeSxlKlAGYErFg")]
    [DisplayName("Command Result")]
    [IsoXmlTag("CmdRslt")]
    public ATMCommand2? CommandResult { get; init; }

    /// <summary>
    /// Security command in progress inside which the key download is requested.
    /// </summary>
    [IsoId("_6qdTgItLEeSxlKlAGYErFg")]
    [DisplayName("Command Context")]
    [IsoXmlTag("CmdCntxt")]
    public ATMCommand3? CommandContext { get; init; }

    /// <summary>
    /// Context of the ATM for the key download.
    /// </summary>
    [IsoId("_HaiTwItMEeSxlKlAGYErFg")]
    [DisplayName("ATM Security Context")]
    [IsoXmlTag("ATMSctyCntxt")]
    public required ATMSecurityContext2 ATMSecurityContext { get; init; }

    /// <summary>
    /// Security parameters of the ATM for the initiated key download.
    /// </summary>
    [IsoId("_Y0pIQItOEeSxlKlAGYErFg")]
    [DisplayName("ATM Security Parameters")]
    [IsoXmlTag("ATMSctyParams")]
    public required SecurityParameters4 ATMSecurityParameters { get; init; }

    /// <summary>
    /// Random value from the host provided during a previous exchange.
    /// </summary>
    [IsoId("_bRViQItQEeSxlKlAGYErFg")]
    [DisplayName("Host Challenge")]
    [IsoXmlTag("HstChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? HostChallenge { get; init; }
}
