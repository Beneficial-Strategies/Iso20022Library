// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Hardware security module of the ATM.
/// </summary>
[IsoId("_6LYrIIr5EeSvuOJS0mmL0g")]
[DisplayName("ATM Security Device")]
public record ATMSecurityDevice1
{
    /// <summary>
    /// Hardware security module information, so called EPP for Encrypted PIN Pad.
    /// </summary>
    [IsoId("_S4L8EIr6EeSvuOJS0mmL0g")]
    [DisplayName("Device Property")]
    [IsoXmlTag("DvcPrprty")]
    public ATMEquipment2? DeviceProperty { get; init; }

    /// <summary>
    /// Configuration parameters in use by the security device.
    /// </summary>
    [IsoId("_-uw6QIr6EeSvuOJS0mmL0g")]
    [DisplayName("Current Configuration")]
    [IsoXmlTag("CurCfgtn")]
    public required ATMSecurityConfiguration1 CurrentConfiguration { get; init; }

    /// <summary>
    /// Configuration parameters supported by the security device.
    /// </summary>
    [IsoId("_UjhfsIr-EeSvuOJS0mmL0g")]
    [DisplayName("Supported Configuration")]
    [IsoXmlTag("SpprtdCfgtn")]
    public ATMSecurityConfiguration1? SupportedConfiguration { get; init; }

    /// <summary>
    /// Current status of the security device.
    /// </summary>
    [IsoId("_lPmbcIr-EeSvuOJS0mmL0g")]
    [DisplayName("Current Status")]
    [IsoXmlTag("CurSts")]
    public required ATMStatus2Code CurrentStatus { get; init; }

    /// <summary>
    /// Incident occurring on the device.
    /// </summary>
    [IsoId("_DlxvsIr_EeSvuOJS0mmL0g")]
    [DisplayName("Incident")]
    [IsoXmlTag("Incdnt")]
    public FailureReason5Code? Incident { get; init; }
}
