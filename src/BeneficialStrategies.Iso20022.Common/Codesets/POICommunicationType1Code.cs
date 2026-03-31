// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Low level communication of the hardware or software component toward another component or an external entity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__rixQAx1EeKa_56Jbsi1RQ")]
[Description(
    @"Low level communication of the hardware or software component toward another component or an external entity."
)]
[DerivedFrom(typeof(POICommunicationTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<POICommunicationType1Code>))]
#endif
public enum POICommunicationType1Code
{
    /// <summary>
    /// Communication with a host using Bluetooth.
    /// Encoded/decoded by serializers as &quot;BLTH&quot;.
    /// </summary>
    [EnumMember(Value = "BLTH")]
    [IsoId("_EUWIYQx2EeKa_56Jbsi1RQ")]
    [Description(@"Communication with a host using Bluetooth.")]
    Bluetooth = POICommunicationTypeCode.Bluetooth, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ethernet port to communicate.
    /// Encoded/decoded by serializers as &quot;ETHR&quot;.
    /// </summary>
    [EnumMember(Value = "ETHR")]
    [IsoId("_EaJOYQx2EeKa_56Jbsi1RQ")]
    [Description(@"Ethernet port to communicate.")]
    Ethernet = POICommunicationTypeCode.Ethernet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Communication with a host using GPRS.
    /// Encoded/decoded by serializers as &quot;GPRS&quot;.
    /// </summary>
    [EnumMember(Value = "GPRS")]
    [IsoId("_Eixl8Qx2EeKa_56Jbsi1RQ")]
    [Description(@"Communication with a host using GPRS.")]
    GPRS = POICommunicationTypeCode.GPRS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Communication with a host using GSM.
    /// Encoded/decoded by serializers as &quot;GSMF&quot;.
    /// </summary>
    [EnumMember(Value = "GSMF")]
    [IsoId("_En1FEQx2EeKa_56Jbsi1RQ")]
    [Description(@"Communication with a host using GSM.")]
    GSM = POICommunicationTypeCode.GSM, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Communication with a host using Public Switching Telephone Network.
    /// Encoded/decoded by serializers as &quot;PSTN&quot;.
    /// </summary>
    [EnumMember(Value = "PSTN")]
    [IsoId("_Et7tEQx2EeKa_56Jbsi1RQ")]
    [Description(@"Communication with a host using Public Switching Telephone Network.")]
    PSTN = POICommunicationTypeCode.PSTN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Serial port to communicate.
    /// Encoded/decoded by serializers as &quot;RS23&quot;.
    /// </summary>
    [EnumMember(Value = "RS23")]
    [IsoId("_EzSuMwx2EeKa_56Jbsi1RQ")]
    [Description(@"Serial port to communicate.")]
    RS232 = POICommunicationTypeCode.RS232, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Communication with a USB stick or any USB device.
    /// Encoded/decoded by serializers as &quot;USBD&quot;.
    /// </summary>
    [EnumMember(Value = "USBD")]
    [IsoId("_E76esQx2EeKa_56Jbsi1RQ")]
    [Description(@"Communication with a USB stick or any USB device.")]
    USBDevice = POICommunicationTypeCode.USBDevice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Communication with a host from an USB port.
    /// Encoded/decoded by serializers as &quot;USBH&quot;.
    /// </summary>
    [EnumMember(Value = "USBH")]
    [IsoId("_FDWjcQx2EeKa_56Jbsi1RQ")]
    [Description(@"Communication with a host from an USB port.")]
    USBHost = POICommunicationTypeCode.USBHost, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Wifi communication with another component.
    /// Encoded/decoded by serializers as &quot;WIFI&quot;.
    /// </summary>
    [EnumMember(Value = "WIFI")]
    [IsoId("_FJdLcQx2EeKa_56Jbsi1RQ")]
    [Description(@"Wifi communication with another component.")]
    Wifi = POICommunicationTypeCode.Wifi, // same ordinal as derivation source for type conversions
}
