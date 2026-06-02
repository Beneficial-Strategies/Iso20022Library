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
[IsoId("_m7QtYbZ5EfCUZfsQO4rYeA")]
[DisplayName("ATM Key Download Request6")]
public record ATMKeyDownloadRequest6
{
    /// <summary>
    /// Environment of the key download.
    /// </summary>
    [IsoId("_m8T2QbZ5EfCUZfsQO4rYeA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment15 Environment { get; init; }

    /// <summary>
    /// Result of a maintenance command performed by the ATM.
    /// </summary>
    [IsoId("_m8T2Q7Z5EfCUZfsQO4rYeA")]
    [DisplayName("Command Result")]
    [IsoXmlTag("CmdRslt")]
    public ValueList<ATMCommand15> CommandResult { get; init; } = [];

    /// <summary>
    /// Security command in progress inside which the key download is requested.
    /// </summary>
    [IsoId("_m8T2RbZ5EfCUZfsQO4rYeA")]
    [DisplayName("Command Context")]
    [IsoXmlTag("CmdCntxt")]
    public ATMCommand16? CommandContext { get; init; }

    /// <summary>
    /// Context of the ATM for the key download.
    /// </summary>
    [IsoId("_m8T2R7Z5EfCUZfsQO4rYeA")]
    [DisplayName("ATM Security Context")]
    [IsoXmlTag("ATMSctyCntxt")]
    public required ATMSecurityContext3 ATMSecurityContext { get; init; }

    /// <summary>
    /// Security parameters of the ATM for the initiated key download.
    /// </summary>
    [IsoId("_m8T2SbZ5EfCUZfsQO4rYeA")]
    [DisplayName("ATM Security Parameters")]
    [IsoXmlTag("ATMSctyParams")]
    public required SecurityParameters18 ATMSecurityParameters { get; init; }

    /// <summary>
    /// Random value from the host provided during a previous exchange.
    /// </summary>
    [IsoId("_m8T2S7Z5EfCUZfsQO4rYeA")]
    [DisplayName("Host Challenge")]
    [IsoXmlTag("HstChllng")]
    public IsoMax140Binary? HostChallenge { get; init; }
}
