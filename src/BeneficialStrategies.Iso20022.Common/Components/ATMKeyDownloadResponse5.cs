// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Key Download Response5.
/// </summary>
[IsoId("_j8hkEZ9mEe-nbM0aSPcoiQ")]
[DisplayName("ATM Key Download Response5")]
public partial record ATMKeyDownloadResponse5
{
    #nullable enable

    /// <summary>
    /// ATM Challenge.
    /// </summary>
    [DisplayName("ATM Challenge")]
    [IsoXmlTag("ATMChllng")]
    public IsoMax140Binary? ATMChallenge { get; init; } 

    /// <summary>
    /// ATM Security Context.
    /// </summary>
    [DisplayName("ATM Security Context")]
    [IsoXmlTag("ATMSctyCntxt")]
    public required ATMSecurityContext3 ATMSecurityContext { get; init; } 

    /// <summary>
    /// Command.
    /// </summary>
    [DisplayName("Command")]
    [IsoXmlTag("Cmd")]
    public ValueList<ATMCommand17> Command { get; init; } = [];

    /// <summary>
    /// Environment.
    /// </summary>
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment7 Environment { get; init; } 

    /// <summary>
    /// Host Security Parameters.
    /// </summary>
    [DisplayName("Host Security Parameters")]
    [IsoXmlTag("HstSctyParams")]
    public required SecurityParameters10 HostSecurityParameters { get; init; } 

    
    #nullable disable
    
}
