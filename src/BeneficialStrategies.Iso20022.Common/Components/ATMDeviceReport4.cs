// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Device Report4.
/// </summary>
[IsoId("_eXtNgaEPEe-MRKYsaX6JDg")]
[DisplayName("ATM Device Report4")]
public partial record ATMDeviceReport4
{
    #nullable enable

    /// <summary>
    /// ATM Global Status.
    /// </summary>
    [DisplayName("ATM Global Status")]
    [IsoXmlTag("ATMGblSts")]
    public required ATMStatus2 ATMGlobalStatus { get; init; } 

    /// <summary>
    /// ATM Security Context.
    /// </summary>
    [DisplayName("ATM Security Context")]
    [IsoXmlTag("ATMSctyCntxt")]
    public ATMSecurityContext5? ATMSecurityContext { get; init; } 

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
    public required ATMEnvironment6 Environment { get; init; } 

    
    #nullable disable
    
}
