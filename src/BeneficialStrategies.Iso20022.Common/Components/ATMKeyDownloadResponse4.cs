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
[IsoId("_Zt_VgbTyEeeQy4o2AayYHg")]
[DisplayName("ATM Key Download Response")]
public record ATMKeyDownloadResponse4
{
    /// <summary>
    /// Environment of the key download.
    /// </summary>
    [IsoId("_Z3LtwbTyEeeQy4o2AayYHg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment7 Environment { get; init; }

    /// <summary>
    /// Context of the ATM for the key download.
    /// </summary>
    [IsoId("_Z3Ltw7TyEeeQy4o2AayYHg")]
    [DisplayName("ATM Security Context")]
    [IsoXmlTag("ATMSctyCntxt")]
    public required ATMSecurityContext3 ATMSecurityContext { get; init; }

    /// <summary>
    /// Random value from the ATM provided during a previous exchange.
    /// </summary>
    [IsoId("_Z3LtxbTyEeeQy4o2AayYHg")]
    [DisplayName("ATM Challenge")]
    [IsoXmlTag("ATMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? ATMChallenge { get; init; }

    /// <summary>
    /// Security parameters of the host downloading the key.
    /// </summary>
    [IsoId("_Z3Ltx7TyEeeQy4o2AayYHg")]
    [DisplayName("Host Security Parameters")]
    [IsoXmlTag("HstSctyParams")]
    public required SecurityParameters10 HostSecurityParameters { get; init; }

    /// <summary>
    /// Maintenance command to perform on the ATM.
    /// </summary>
    [IsoId("_Z3LtybTyEeeQy4o2AayYHg")]
    [DisplayName("Command")]
    [IsoXmlTag("Cmd")]
    public ValueList<ATMCommand13> Command { get; init; } = [];
}
