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
[IsoId("_jisRQYtMEeSxlKlAGYErFg")]
[DisplayName("ATM Equipment")]
public record ATMEquipment3
{
    /// <summary>
    /// ATM Manufacturer.
    /// </summary>
    [IsoId("_jvD5UYtMEeSxlKlAGYErFg")]
    [DisplayName("Manufacturer")]
    [IsoXmlTag("Manfctr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Manufacturer { get; init; }

    /// <summary>
    /// Model of ATM.
    /// </summary>
    [IsoId("_jvD5U4tMEeSxlKlAGYErFg")]
    [DisplayName("Model")]
    [IsoXmlTag("Mdl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Model { get; init; }

    /// <summary>
    /// Version of the device model.
    /// </summary>
    [IsoId("_jvD5VYtMEeSxlKlAGYErFg")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Version { get; init; }

    /// <summary>
    /// Serial number of the ATM.
    /// </summary>
    [IsoId("_jvD5V4tMEeSxlKlAGYErFg")]
    [DisplayName("Serial Number")]
    [IsoXmlTag("SrlNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SerialNumber { get; init; }

    /// <summary>
    /// Signature of the serial number of the device. The signature may contain the serial number with the signature.
    /// </summary>
    [IsoId("_XcPAUItNEeSxlKlAGYErFg")]
    [DisplayName("Signed Serial Number")]
    [IsoXmlTag("SgndSrlNb")]
    public ContentInformationType14? SignedSerialNumber { get; init; }

    /// <summary>
    /// Provider of the firmware.
    /// </summary>
    [IsoId("_jvD5WYtMEeSxlKlAGYErFg")]
    [DisplayName("Firmware Provider")]
    [IsoXmlTag("FrmwrPrvdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? FirmwareProvider { get; init; }

    /// <summary>
    /// Identification of the firmware.
    /// </summary>
    [IsoId("_jvD5XYtMEeSxlKlAGYErFg")]
    [DisplayName("Firmware Identification")]
    [IsoXmlTag("FrmwrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? FirmwareIdentification { get; init; }

    /// <summary>
    /// Version of the firmware.
    /// </summary>
    [IsoId("_jvD5X4tMEeSxlKlAGYErFg")]
    [DisplayName("Firmware Version")]
    [IsoXmlTag("FrmwrVrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? FirmwareVersion { get; init; }
}
