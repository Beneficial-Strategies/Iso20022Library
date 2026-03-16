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
[IsoId("_vxSi0ItREeST3ocKVc8_qA")]
[DisplayName("ATM Key Download Response")]
public record ATMKeyDownloadResponse1
{
    /// <summary>
    /// Environment of the key download.
    /// </summary>
    [IsoId("_FjRocItSEeST3ocKVc8_qA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment7 Environment { get; init; }

    /// <summary>
    /// Context of the ATM for the key download.
    /// </summary>
    [IsoId("_JsqfsItSEeST3ocKVc8_qA")]
    [DisplayName("ATM Security Context")]
    [IsoXmlTag("ATMSctyCntxt")]
    public required ATMSecurityContext2 ATMSecurityContext { get; init; }

    /// <summary>
    /// Random value from the ATM provided during a previous exchange.
    /// </summary>
    [IsoId("_Ppse0ItSEeST3ocKVc8_qA")]
    [DisplayName("ATM Challenge")]
    [IsoXmlTag("ATMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? ATMChallenge { get; init; }

    /// <summary>
    /// Security parameters of the host downloading the key.
    /// </summary>
    [IsoId("_pE7XgItcEeST3ocKVc8_qA")]
    [DisplayName("Host Security Parameters")]
    [IsoXmlTag("HstSctyParams")]
    public required SecurityParameters5 HostSecurityParameters { get; init; }

    /// <summary>
    /// Maintenance command to perform on the ATM.
    /// </summary>
    [IsoId("_s6PKQIteEeST3ocKVc8_qA")]
    [DisplayName("Command")]
    [IsoXmlTag("Cmd")]
    public ATMCommand1? Command { get; init; }
}
