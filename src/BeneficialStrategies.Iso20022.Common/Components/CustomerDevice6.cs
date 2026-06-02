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
[IsoId("_sOvAsTJ4EfCLfeKcVPKw8g")]
[DisplayName("Customer Device6")]
public record CustomerDevice6
{
    /// <summary>
    /// Manufacturer of the device.
    /// </summary>
    [IsoId("_sR_wETJ4EfCLfeKcVPKw8g")]
    [DisplayName("Manufacturer")]
    [IsoXmlTag("Manfctr")]
    public IsoMax70Text? Manufacturer { get; init; }

    /// <summary>
    /// Manufacturer's identification of the model.
    /// </summary>
    [IsoId("_sR_wEzJ4EfCLfeKcVPKw8g")]
    [DisplayName("Manufacturer Model Identification")]
    [IsoXmlTag("ManfctrMdlId")]
    public IsoMax70Text? ManufacturerModelIdentification { get; init; }

    /// <summary>
    /// Type of customer device. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_sR_wFTJ4EfCLfeKcVPKw8g")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ExternalCustomerDeviceType1Code? Type { get; init; }

    /// <summary>
    /// Preferred language set on the device.
    /// </summary>
    [IsoId("_sR_wGTJ4EfCLfeKcVPKw8g")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public ISO2ALanguageCode? Language { get; init; }

    /// <summary>
    /// Phone number associated with the device.
    /// </summary>
    [IsoId("_sR_wGzJ4EfCLfeKcVPKw8g")]
    [DisplayName("Phone")]
    [IsoXmlTag("Phne")]
    public IsoPhoneNumber? Phone { get; init; }

    /// <summary>
    /// Geographical location of the device.
    /// </summary>
    [IsoId("_sR_wHTJ4EfCLfeKcVPKw8g")]
    [DisplayName("Geographic Location")]
    [IsoXmlTag("GeogcLctn")]
    public IsoGeographicPointInDecimalDegreesText? GeographicLocation { get; init; }

    /// <summary>
    /// Country of the location.
    /// </summary>
    [IsoId("_sR_wHzJ4EfCLfeKcVPKw8g")]
    [DisplayName("Location Country Code")]
    [IsoXmlTag("LctnCtryCd")]
    public ISO3NumericCountryCode? LocationCountryCode { get; init; }

    /// <summary>
    /// Internet Protocol address associated with the device.
    /// </summary>
    [IsoId("_sR_wITJ4EfCLfeKcVPKw8g")]
    [DisplayName("IP Address")]
    [IsoXmlTag("IPAdr")]
    public IsoMax70Text? IPAddress { get; init; }

    /// <summary>
    /// Electronic mail address associated with the device.
    /// </summary>
    [IsoId("_sR_wIzJ4EfCLfeKcVPKw8g")]
    [DisplayName("Email")]
    [IsoXmlTag("Email")]
    public IsoMax256Text? Email { get; init; }

    /// <summary>
    /// Customer's name of the device.
    /// </summary>
    [IsoId("_sR_wJTJ4EfCLfeKcVPKw8g")]
    [DisplayName("Device Name")]
    [IsoXmlTag("DvcNm")]
    public IsoMax100Text? DeviceName { get; init; }

    /// <summary>
    /// Customer assigned device name, normalized.
    /// </summary>
    [IsoId("_sR_wJzJ4EfCLfeKcVPKw8g")]
    [DisplayName("Device Name Normalized")]
    [IsoXmlTag("DvcNmNrmlzd")]
    public IsoMax100Text? DeviceNameNormalized { get; init; }

    /// <summary>
    /// Identification of the device.
    /// </summary>
    [IsoId("_sR_wKTJ4EfCLfeKcVPKw8g")]
    [DisplayName("Device Identification")]
    [IsoXmlTag("DvcId")]
    public ValueList<DeviceIdentification2> DeviceIdentification { get; init; } = [];

    /// <summary>
    /// Identification of the operating system.
    /// </summary>
    [IsoId("_sR_wKzJ4EfCLfeKcVPKw8g")]
    [DisplayName("Operating System Identification")]
    [IsoXmlTag("OprgSysId")]
    public IsoMax70Text? OperatingSystemIdentification { get; init; }

    /// <summary>
    /// Type of device operating system. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_sR_wLTJ4EfCLfeKcVPKw8g")]
    [DisplayName("Operating System Type")]
    [IsoXmlTag("OprgSysTp")]
    public ExternalDeviceOperatingSystemType1Code? OperatingSystemType { get; init; }

    /// <summary>
    /// Version of device operating system.
    /// </summary>
    [IsoId("_sR_wMTJ4EfCLfeKcVPKw8g")]
    [DisplayName("Operating System Version")]
    [IsoXmlTag("OprgSysVrsn")]
    public IsoMax35Text? OperatingSystemVersion { get; init; }

    /// <summary>
    /// Build of the device operating system.
    /// </summary>
    [IsoId("_sR_wMzJ4EfCLfeKcVPKw8g")]
    [DisplayName("Operating System Build")]
    [IsoXmlTag("OprgSysBld")]
    public IsoMax70Text? OperatingSystemBuild { get; init; }

    /// <summary>
    /// Provider of the customer device.
    /// </summary>
    [IsoId("_sR_wNTJ4EfCLfeKcVPKw8g")]
    [DisplayName("Provider")]
    [IsoXmlTag("Prvdr")]
    public IsoMax35Text? Provider { get; init; }

    /// <summary>
    /// The source of geographic location source.
    /// </summary>
    [IsoId("_PauF8DJ8EfCLfeKcVPKw8g")]
    [DisplayName("Geographic Location Source")]
    [IsoXmlTag("GeogcLctnSrc")]
    public IsoMax35Text? GeographicLocationSource { get; init; }

    /// <summary>
    /// Contain the time zone of the device.
    /// </summary>
    [IsoId("_VzkeYDJ8EfCLfeKcVPKw8g")]
    [DisplayName("Device Time Zone")]
    [IsoXmlTag("DvcTmZone")]
    public IsoMax70Text? DeviceTimeZone { get; init; }

    /// <summary>
    /// Contains the source of device time zone.
    /// </summary>
    [IsoId("_gAgzgDJ8EfCLfeKcVPKw8g")]
    [DisplayName("Device Time Zone Source")]
    [IsoXmlTag("DvcTmZoneSrc")]
    public IsoMax35Text? DeviceTimeZoneSource { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_Gyrv0kVZEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_Gyrv00VZEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
