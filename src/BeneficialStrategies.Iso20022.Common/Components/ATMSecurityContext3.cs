// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context of the ATM for the key download.
/// </summary>
[IsoId("_9Bek8V2VEeekzJIz1JxYSQ")]
[DisplayName("ATM Security Context")]
public record ATMSecurityContext3
{
    /// <summary>
    /// Key exchange security scheme in activation on the ATM for the host manager.
    /// </summary>
    [IsoId("_9Kv1sV2VEeekzJIz1JxYSQ")]
    [DisplayName("Current Security Scheme")]
    [IsoXmlTag("CurSctySchme")]
    public required ATMSecurityScheme3Code CurrentSecurityScheme { get; init; }

    /// <summary>
    /// Hardware security module information, so called EPP for Encrypted PIN Pad.
    /// </summary>
    [IsoId("_9Kv1s12VEeekzJIz1JxYSQ")]
    [DisplayName("Device Property")]
    [IsoXmlTag("DvcPrprty")]
    public ATMEquipment3? DeviceProperty { get; init; }

    /// <summary>
    /// Configuration parameters in use by the security device.
    /// </summary>
    [IsoId("_9Kv1tV2VEeekzJIz1JxYSQ")]
    [DisplayName("Current Configuration")]
    [IsoXmlTag("CurCfgtn")]
    public ATMSecurityConfiguration1? CurrentConfiguration { get; init; }
}
