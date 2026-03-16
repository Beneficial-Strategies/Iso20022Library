// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Hardware security module information, so called EPP for Encrypted PIN Pad.
/// </summary>
[IsoId("_JjYv4Yr6EeSvuOJS0mmL0g")]
[DisplayName("ATM Equipment")]
public record ATMEquipment2
{
    /// <summary>
    /// ATM Manufacturer.
    /// </summary>
    [IsoId("_J4WTQYr6EeSvuOJS0mmL0g")]
    [DisplayName("Manufacturer")]
    [IsoXmlTag("Manfctr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Manufacturer { get; init; }

    /// <summary>
    /// Model of ATM.
    /// </summary>
    [IsoId("_J4WTQ4r6EeSvuOJS0mmL0g")]
    [DisplayName("Model")]
    [IsoXmlTag("Mdl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Model { get; init; }

    /// <summary>
    /// Version of the device model.
    /// </summary>
    [IsoId("_a_RX8Ir6EeSvuOJS0mmL0g")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Version { get; init; }

    /// <summary>
    /// Serial number of the ATM.
    /// </summary>
    [IsoId("_J4WTRYr6EeSvuOJS0mmL0g")]
    [DisplayName("Serial Number")]
    [IsoXmlTag("SrlNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SerialNumber { get; init; }

    /// <summary>
    /// Provider of the firmware.
    /// </summary>
    [IsoId("_J4WTR4r6EeSvuOJS0mmL0g")]
    [DisplayName("Firmware Provider")]
    [IsoXmlTag("FrmwrPrvdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? FirmwareProvider { get; init; }

    /// <summary>
    /// Identification of the firmware.
    /// </summary>
    [IsoId("_J4WTS4r6EeSvuOJS0mmL0g")]
    [DisplayName("Firmware Identification")]
    [IsoXmlTag("FrmwrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? FirmwareIdentification { get; init; }

    /// <summary>
    /// Version of the firmware.
    /// </summary>
    [IsoId("_J4WTTYr6EeSvuOJS0mmL0g")]
    [DisplayName("Firmware Version")]
    [IsoXmlTag("FrmwrVrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? FirmwareVersion { get; init; }
}
