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
[IsoId("_F5BX4a46EeWRfYPBaeOY8w")]
[DisplayName("ATM Key Download Response")]
public record ATMKeyDownloadResponse2
{
    /// <summary>
    /// Environment of the key download.
    /// </summary>
    [IsoId("_GF1r4a46EeWRfYPBaeOY8w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment7 Environment { get; init; }

    /// <summary>
    /// Context of the ATM for the key download.
    /// </summary>
    [IsoId("_GF1r4646EeWRfYPBaeOY8w")]
    [DisplayName("ATM Security Context")]
    [IsoXmlTag("ATMSctyCntxt")]
    public required ATMSecurityContext2 ATMSecurityContext { get; init; }

    /// <summary>
    /// Random value from the ATM provided during a previous exchange.
    /// </summary>
    [IsoId("_GF1r5a46EeWRfYPBaeOY8w")]
    [DisplayName("ATM Challenge")]
    [IsoXmlTag("ATMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? ATMChallenge { get; init; }

    /// <summary>
    /// Security parameters of the host downloading the key.
    /// </summary>
    [IsoId("_GF1r5646EeWRfYPBaeOY8w")]
    [DisplayName("Host Security Parameters")]
    [IsoXmlTag("HstSctyParams")]
    public required SecurityParameters5 HostSecurityParameters { get; init; }

    /// <summary>
    /// Maintenance command to perform on the ATM.
    /// </summary>
    [IsoId("_GF1r6a46EeWRfYPBaeOY8w")]
    [DisplayName("Command")]
    [IsoXmlTag("Cmd")]
    public ValueList<ATMCommand7> Command { get; init; } = [];
}
