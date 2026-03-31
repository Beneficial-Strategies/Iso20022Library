// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the customer device.
/// </summary>
[IsoId("_Uy_usYKvEeu4svNQ5N-l6w")]
[DisplayName("Customer Device")]
public record CustomerDevice4
{
    /// <summary>
    /// Information about the customer device.
    /// </summary>
    [IsoId("_U4M-0YKvEeu4svNQ5N-l6w")]
    [DisplayName("Device")]
    [IsoXmlTag("Dvc")]
    public Device2? Device { get; init; }

    /// <summary>
    /// Identification of the device.
    /// </summary>
    [IsoId("_Rs2CsJfPEeuqNYk2TG3bTg")]
    [DisplayName("Device Identification")]
    [IsoXmlTag("DvcId")]
    public DeviceIdentification1? DeviceIdentification { get; init; }

    /// <summary>
    /// Device operating system information.
    /// </summary>
    [IsoId("_mZABUJfSEeuqNYk2TG3bTg")]
    [DisplayName("Operating System")]
    [IsoXmlTag("OprgSys")]
    public DeviceOperatingSystem1? OperatingSystem { get; init; }

    /// <summary>
    /// Provider of the customer device.
    /// </summary>
    [IsoId("_U4M-1YKvEeu4svNQ5N-l6w")]
    [DisplayName("Provider")]
    [IsoXmlTag("Prvdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Provider { get; init; }

    /// <summary>
    /// Additional customer device data.
    /// </summary>
    [IsoId("_w89vUJfSEeuqNYk2TG3bTg")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];
}
