// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Key Download Request5.
/// </summary>
[IsoId("_w1DLIZ9lEe-nbM0aSPcoiQ")]
[DisplayName("ATM Key Download Request5")]
public partial record ATMKeyDownloadRequest5
{
    #nullable enable

    /// <summary>
    /// ATM Security Context.
    /// </summary>
    [DisplayName("ATM Security Context")]
    [IsoXmlTag("ATMSctyCntxt")]
    public required ATMSecurityContext3 ATMSecurityContext { get; init; } 

    /// <summary>
    /// ATM Security Parameters.
    /// </summary>
    [DisplayName("ATM Security Parameters")]
    [IsoXmlTag("ATMSctyParams")]
    public required SecurityParameters9 ATMSecurityParameters { get; init; } 

    /// <summary>
    /// Command Context.
    /// </summary>
    [DisplayName("Command Context")]
    [IsoXmlTag("CmdCntxt")]
    public ATMCommand16? CommandContext { get; init; } 

    /// <summary>
    /// Command Result.
    /// </summary>
    [DisplayName("Command Result")]
    [IsoXmlTag("CmdRslt")]
    public ValueList<ATMCommand15> CommandResult { get; init; } = [];

    /// <summary>
    /// Environment.
    /// </summary>
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment15 Environment { get; init; } 

    /// <summary>
    /// Host Challenge.
    /// </summary>
    [DisplayName("Host Challenge")]
    [IsoXmlTag("HstChllng")]
    public IsoMax140Binary? HostChallenge { get; init; } 

    
    #nullable disable
    
}
