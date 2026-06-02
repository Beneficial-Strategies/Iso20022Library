// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response of an ATM key download from an ATM manager.
/// </summary>
[IsoId("_KOvpIbZ6EfCUZfsQO4rYeA")]
[DisplayName("ATM Key Download Response6")]
public record ATMKeyDownloadResponse6
{
    /// <summary>
    /// Environment of the key download.
    /// </summary>
    [IsoId("_KPqPIbZ6EfCUZfsQO4rYeA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment7 Environment { get; init; }

    /// <summary>
    /// Context of the ATM for the key download.
    /// </summary>
    [IsoId("_KPqPI7Z6EfCUZfsQO4rYeA")]
    [DisplayName("ATM Security Context")]
    [IsoXmlTag("ATMSctyCntxt")]
    public required ATMSecurityContext3 ATMSecurityContext { get; init; }

    /// <summary>
    /// Random value from the ATM provided during a previous exchange.
    /// </summary>
    [IsoId("_KPqPJbZ6EfCUZfsQO4rYeA")]
    [DisplayName("ATM Challenge")]
    [IsoXmlTag("ATMChllng")]
    public IsoMax140Binary? ATMChallenge { get; init; }

    /// <summary>
    /// Security parameters of the host downloading the key.
    /// </summary>
    [IsoId("_KPqPJ7Z6EfCUZfsQO4rYeA")]
    [DisplayName("Host Security Parameters")]
    [IsoXmlTag("HstSctyParams")]
    public required SecurityParameters19 HostSecurityParameters { get; init; }

    /// <summary>
    /// Maintenance command to perform on the ATM.
    /// </summary>
    [IsoId("_KPqPKbZ6EfCUZfsQO4rYeA")]
    [DisplayName("Command")]
    [IsoXmlTag("Cmd")]
    public ValueList<ATMCommand17> Command { get; init; } = [];
}
