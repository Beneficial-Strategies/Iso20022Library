// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Low level communication of the hardware or software component toward another component or an external entity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WVvGsAx1EeKa_56Jbsi1RQ")]
[Description(
    @"Low level communication of the hardware or software component toward another component or an external entity."
)]
[Derivations(typeof(POICommunicationType1Code), typeof(POICommunicationType2Code))]
public enum POICommunicationTypeCode
{
    /// <summary>
    /// Communication with a host from an USB port.
    /// Encoded/decoded by serializers as &quot;USBH&quot;.
    /// </summary>
    [EnumMember(Value = "USBH")]
    [IsoId("_a0S8sAx1EeKa_56Jbsi1RQ")]
    [Description(@"Communication with a host from an USB port.")]
    USBHost,

    /// <summary>
    /// Communication with a USB stick or any USB device.
    /// Encoded/decoded by serializers as &quot;USBD&quot;.
    /// </summary>
    [EnumMember(Value = "USBD")]
    [IsoId("_e8XlUAx1EeKa_56Jbsi1RQ")]
    [Description(@"Communication with a USB stick or any USB device.")]
    USBDevice,

    /// <summary>
    /// Ethernet port to communicate.
    /// Encoded/decoded by serializers as &quot;ETHR&quot;.
    /// </summary>
    [EnumMember(Value = "ETHR")]
    [IsoId("_kXApEAx1EeKa_56Jbsi1RQ")]
    [Description(@"Ethernet port to communicate.")]
    Ethernet,

    /// <summary>
    /// Wifi communication with another component.
    /// Encoded/decoded by serializers as &quot;WIFI&quot;.
    /// </summary>
    [EnumMember(Value = "WIFI")]
    [IsoId("_outCEAx1EeKa_56Jbsi1RQ")]
    [Description(@"Wifi communication with another component.")]
    Wifi,

    /// <summary>
    /// Communication with a host using Public Switching Telephone Network.
    /// Encoded/decoded by serializers as &quot;PSTN&quot;.
    /// </summary>
    [EnumMember(Value = "PSTN")]
    [IsoId("_swFM0Ax1EeKa_56Jbsi1RQ")]
    [Description(@"Communication with a host using Public Switching Telephone Network.")]
    PSTN,

    /// <summary>
    /// Communication with a host using Bluetooth.
    /// Encoded/decoded by serializers as &quot;BLTH&quot;.
    /// </summary>
    [EnumMember(Value = "BLTH")]
    [IsoId("_wfdBkAx1EeKa_56Jbsi1RQ")]
    [Description(@"Communication with a host using Bluetooth.")]
    Bluetooth,

    /// <summary>
    /// Communication with a host using GSM.
    /// Encoded/decoded by serializers as &quot;GSMF&quot;.
    /// </summary>
    [EnumMember(Value = "GSMF")]
    [IsoId("_0HsTkAx1EeKa_56Jbsi1RQ")]
    [Description(@"Communication with a host using GSM.")]
    GSM,

    /// <summary>
    /// Communication with a host using GPRS.
    /// Encoded/decoded by serializers as &quot;GPRS&quot;.
    /// </summary>
    [EnumMember(Value = "GPRS")]
    [IsoId("_4W6GAAx1EeKa_56Jbsi1RQ")]
    [Description(@"Communication with a host using GPRS.")]
    GPRS,

    /// <summary>
    /// Serial port to communicate.
    /// Encoded/decoded by serializers as &quot;RS23&quot;.
    /// </summary>
    [EnumMember(Value = "RS23")]
    [IsoId("_8DAkUAx1EeKa_56Jbsi1RQ")]
    [Description(@"Serial port to communicate.")]
    RS232,

    /// <summary>
    /// Includes all communication technologies which can be qualified as being part of the 2G technology (e.g EDGE or PDC).
    /// Encoded/decoded by serializers as &quot;WT2G&quot;.
    /// </summary>
    [EnumMember(Value = "WT2G")]
    [IsoId("_Z0jxULCYEeapjPTKZHuM2w")]
    [Description(
        @"Includes all communication technologies which can be qualified as being part of the 2G technology (e.g EDGE or PDC)."
    )]
    WirelessTechnology2G,

    /// <summary>
    /// Includes all communication technologies which can be qualified as being part of the 3G technology.
    /// Encoded/decoded by serializers as &quot;WT3G&quot;.
    /// </summary>
    [EnumMember(Value = "WT3G")]
    [IsoId("_pQgh8LCYEeapjPTKZHuM2w")]
    [Description(
        @"Includes all communication technologies which can be qualified as being part of the 3G technology."
    )]
    WirelessTechnology3G,

    /// <summary>
    /// Includes all communication technologies which can be qualified as being part of the 4G technology.
    /// Encoded/decoded by serializers as &quot;WT4G&quot;.
    /// </summary>
    [EnumMember(Value = "WT4G")]
    [IsoId("_t2jgALCYEeapjPTKZHuM2w")]
    [Description(
        @"Includes all communication technologies which can be qualified as being part of the 4G technology."
    )]
    WirelessTechnology4G,

    /// <summary>
    /// Includes all communication technologies which can be qualified as being part of the 5G technology.
    /// Encoded/decoded by serializers as &quot;WT5G&quot;.
    /// </summary>
    [EnumMember(Value = "WT5G")]
    [IsoId("_wwPp8LCYEeapjPTKZHuM2w")]
    [Description(
        @"Includes all communication technologies which can be qualified as being part of the 5G technology."
    )]
    WirelessTechnology5G,
}
