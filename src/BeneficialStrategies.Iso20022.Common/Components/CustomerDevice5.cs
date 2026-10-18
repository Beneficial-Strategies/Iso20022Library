// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Customer Device5.
/// </summary>
[IsoId("_WHiKsW9sEe6DxcrvCrq6hQ")]
[DisplayName("Customer Device5")]
public record CustomerDevice5
{
    /// <summary>
    /// Manufacturer.
    /// </summary>
    [DisplayName("Manufacturer")]
    [IsoXmlTag("Manfctr")]
    public Max70Text? Manufacturer { get; init; }

    /// <summary>
    /// Manufacturer Model Identification.
    /// </summary>
    [DisplayName("Manufacturer Model Identification")]
    [IsoXmlTag("ManfctrMdlId")]
    public Max70Text? ManufacturerModelIdentification { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CustomerDeviceType2Code? Type { get; init; }

    /// <summary>
    /// Other Type.
    /// </summary>
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    public Max35Text? OtherType { get; init; }

    /// <summary>
    /// Language.
    /// </summary>
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public ISO2ALanguageCode? Language { get; init; }

    /// <summary>
    /// Phone.
    /// </summary>
    [DisplayName("Phone")]
    [IsoXmlTag("Phne")]
    public PhoneNumber? Phone { get; init; }

    /// <summary>
    /// Geographic Location.
    /// </summary>
    [DisplayName("Geographic Location")]
    [IsoXmlTag("GeogcLctn")]
    public GeographicPointInDecimalDegrees? GeographicLocation { get; init; }

    /// <summary>
    /// Location Country Code.
    /// </summary>
    [DisplayName("Location Country Code")]
    [IsoXmlTag("LctnCtryCd")]
    public ISO3NumericCountryCode? LocationCountryCode { get; init; }

    /// <summary>
    /// IP Address.
    /// </summary>
    [DisplayName("IP Address")]
    [IsoXmlTag("IPAdr")]
    public Max70Text? IPAddress { get; init; }

    /// <summary>
    /// Email.
    /// </summary>
    [DisplayName("Email")]
    [IsoXmlTag("Email")]
    public Max256Text? Email { get; init; }

    /// <summary>
    /// Device Name.
    /// </summary>
    [DisplayName("Device Name")]
    [IsoXmlTag("DvcNm")]
    public Max100Text? DeviceName { get; init; }

    /// <summary>
    /// Device Name Normalized.
    /// </summary>
    [DisplayName("Device Name Normalized")]
    [IsoXmlTag("DvcNmNrmlzd")]
    public Max100Text? DeviceNameNormalized { get; init; }

    /// <summary>
    /// Device Identification.
    /// </summary>
    [DisplayName("Device Identification")]
    [IsoXmlTag("DvcId")]
    public ValueList<DeviceIdentification1> DeviceIdentification { get; init; } = [];

    /// <summary>
    /// Operating System Identification.
    /// </summary>
    [DisplayName("Operating System Identification")]
    [IsoXmlTag("OprgSysId")]
    public Max70Text? OperatingSystemIdentification { get; init; }

    /// <summary>
    /// Operating System Type.
    /// </summary>
    [DisplayName("Operating System Type")]
    [IsoXmlTag("OprgSysTp")]
    public ExternalDeviceOperatingSystemType1Code? OperatingSystemType { get; init; }

    /// <summary>
    /// Other Operating System Type.
    /// </summary>
    [DisplayName("Other Operating System Type")]
    [IsoXmlTag("OthrOprgSysTp")]
    public Max35Text? OtherOperatingSystemType { get; init; }

    /// <summary>
    /// Operating System Version.
    /// </summary>
    [DisplayName("Operating System Version")]
    [IsoXmlTag("OprgSysVrsn")]
    public Max35Text? OperatingSystemVersion { get; init; }

    /// <summary>
    /// Operating System Build.
    /// </summary>
    [DisplayName("Operating System Build")]
    [IsoXmlTag("OprgSysBld")]
    public Max70Text? OperatingSystemBuild { get; init; }

    /// <summary>
    /// Provider.
    /// </summary>
    [DisplayName("Provider")]
    [IsoXmlTag("Prvdr")]
    public Max35Text? Provider { get; init; }

    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];
}
