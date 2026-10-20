// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specified a type of customer device used for a card payment transaction.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_w8ArJI1wEfC7DL86GVtK-Q")]
[Description(
    @"Specified a type of customer device used for a card payment transaction.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalCustomerDeviceType1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalCustomerDeviceTypeCode>))]
public enum ExternalCustomerDeviceTypeCode
{
    /// <summary>
    /// Payment-enabled component integrated into another device or appliance.
    /// Encoded/decoded by serializers as &quot;EMBD&quot;.
    /// </summary>
    [EnumMember(Value = "EMBD")]
    [IsoId("_w8ArL41wEfC7DL86GVtK-Q")]
    [Description(@"Payment-enabled component integrated into another device or appliance.")]
    Embedded,

    /// <summary>
    /// Console or gaming system that supports in-game or digital purchases.
    /// Encoded/decoded by serializers as &quot;GAMB&quot;.
    /// </summary>
    [EnumMember(Value = "GAMB")]
    [IsoId("_w8BSIY1wEfC7DL86GVtK-Q")]
    [Description(@"Console or gaming system that supports in-game or digital purchases.")]
    GamingDevice,

    /// <summary>
    /// Voice-activated device without a screen (e.g., smart speaker) used for initiating transactions.
    /// Encoded/decoded by serializers as &quot;HDST&quot;.
    /// </summary>
    [EnumMember(Value = "HDST")]
    [IsoId("_w8ArM41wEfC7DL86GVtK-Q")]
    [Description(@"Voice-activated device without a screen (e.g., smart speaker) used for initiating transactions.")]
    HeadlessVoice,

    /// <summary>
    /// Any IoT-enabled device capable of initiating or receiving payments (e.g., smart fridge ordering groceries).
    /// Encoded/decoded by serializers as &quot;IOTS&quot;.
    /// </summary>
    [EnumMember(Value = "IOTS")]
    [IsoId("_w8ArLY1wEfC7DL86GVtK-Q")]
    [Description(@"Any IoT-enabled device capable of initiating or receiving payments (e.g., smart fridge ordering groceries).")]
    InternetOfThings,

    /// <summary>
    /// Payment-enabled jewelry such as rings or bracelets with NFC or tokenization capabilities.
    /// Encoded/decoded by serializers as &quot;JEWL&quot;.
    /// </summary>
    [EnumMember(Value = "JEWL")]
    [IsoId("_w8ArJo1wEfC7DL86GVtK-Q")]
    [Description(@"Payment-enabled jewelry such as rings or bracelets with NFC or tokenization capabilities.")]
    Jewellery,

    /// <summary>
    /// Small portable device, often used for contactless payments.
    /// Encoded/decoded by serializers as &quot;KFOB&quot;.
    /// </summary>
    [EnumMember(Value = "KFOB")]
    [IsoId("_w8ArLo1wEfC7DL86GVtK-Q")]
    [Description(@"Small portable device, often used for contactless payments.")]
    KeyFob,

    /// <summary>
    /// Smartphone used for initiating or receiving transactions, often via apps or NFC.
    /// Encoded/decoded by serializers as &quot;MOBL&quot;.
    /// </summary>
    [EnumMember(Value = "MOBL")]
    [IsoId("_w8ArKI1wEfC7DL86GVtK-Q")]
    [Description(@"Smartphone used for initiating or receiving transactions, often via apps or NFC.")]
    Mobile,

    /// <summary>
    /// Card reader without advanced security features, typically used for low-risk or offline transactions.
    /// Encoded/decoded by serializers as &quot;NSCR&quot;.
    /// </summary>
    [EnumMember(Value = "NSCR")]
    [IsoId("_w8ArKo1wEfC7DL86GVtK-Q")]
    [Description(@"Card reader without advanced security features, typically used for low-risk or offline transactions.")]
    NonSecureCardReader,

    /// <summary>
    /// Device type specific to a national payment scheme or infrastructure (such as proprietary POS terminals mandated by a country).
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_w8ArK41wEfC7DL86GVtK-Q")]
    [Description(
        @"Device type specific to a national payment scheme or infrastructure (such as proprietary POS terminals mandated by a country)."
    )]
    OtherNational,

    /// <summary>
    /// Proprietary device type used within a private network or closed-loop payment system.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_w8BSIo1wEfC7DL86GVtK-Q")]
    [Description(@"Proprietary device type used within a private network or closed-loop payment system.")]
    OtherPrivate,

    /// <summary>
    /// Desktop or laptop computer used for online transactions through browsers or installed software.
    /// Encoded/decoded by serializers as &quot;PECR&quot;.
    /// </summary>
    [EnumMember(Value = "PECR")]
    [IsoId("_w8ArMo1wEfC7DL86GVtK-Q")]
    [Description(@"Desktop or laptop computer used for online transactions through browsers or installed software.")]
    PersonalComputer,

    /// <summary>
    /// Card reader device that meets security standards for encrypted PIN entry and secure transaction processing.
    /// Encoded/decoded by serializers as &quot;SECR&quot;.
    /// </summary>
    [EnumMember(Value = "SECR")]
    [IsoId("_w8ArJY1wEfC7DL86GVtK-Q")]
    [Description(
        @"Card reader device that meets security standards for encrypted PIN entry and secure transaction processing."
    )]
    SecureCardReader,

    /// <summary>
    /// Payment sticker with embedded NFC or RFID, typically attached to a physical object for tap-and-pay.
    /// Encoded/decoded by serializers as &quot;STIC&quot;.
    /// </summary>
    [EnumMember(Value = "STIC")]
    [IsoId("_w8BSII1wEfC7DL86GVtK-Q")]
    [Description(@"Payment sticker with embedded NFC or RFID, typically attached to a physical object for tap-and-pay.")]
    Sticker,

    /// <summary>
    /// Touchscreen tablet device functioning similarly to a mobile device for payments.
    /// Encoded/decoded by serializers as &quot;TBLT&quot;.
    /// </summary>
    [EnumMember(Value = "TBLT")]
    [IsoId("_w8ArLI1wEfC7DL86GVtK-Q")]
    [Description(@"Touchscreen tablet device functioning similarly to a mobile device for payments.")]
    Tablet,

    /// <summary>
    /// Smart TV or connected device enabling payments for streaming or interactive services.
    /// Encoded/decoded by serializers as &quot;TLVN&quot;.
    /// </summary>
    [EnumMember(Value = "TLVN")]
    [IsoId("_w8ArNI1wEfC7DL86GVtK-Q")]
    [Description(@"Smart TV or connected device enabling payments for streaming or interactive services.")]
    Television,

    /// <summary>
    /// Device type cannot be determined or is not disclosed.
    /// Encoded/decoded by serializers as &quot;UNKW&quot;.
    /// </summary>
    [EnumMember(Value = "UNKW")]
    [IsoId("_w8ArMI1wEfC7DL86GVtK-Q")]
    [Description(@"Device type cannot be determined or is not disclosed.")]
    Unknown,

    /// <summary>
    /// In-vehicle system enabling payments (such as tolls, fuel, parking) through embedded technology.
    /// Encoded/decoded by serializers as &quot;VHCL&quot;.
    /// </summary>
    [EnumMember(Value = "VHCL")]
    [IsoId("_w8ArKY1wEfC7DL86GVtK-Q")]
    [Description(@"In-vehicle system enabling payments (such as tolls, fuel, parking) through embedded technology.")]
    Vehicle,

    /// <summary>
    /// Smartwatch with payment capabilities.
    /// Encoded/decoded by serializers as &quot;WATC&quot;.
    /// </summary>
    [EnumMember(Value = "WATC")]
    [IsoId("_w8ArMY1wEfC7DL86GVtK-Q")]
    [Description(@"Smartwatch with payment capabilities.")]
    Watch,

    /// <summary>
    /// Device worn on the body (such as fitness band, smart ring) that supports payment functionality.
    /// Encoded/decoded by serializers as &quot;WRBL&quot;.
    /// </summary>
    [EnumMember(Value = "WRBL")]
    [IsoId("_w8ArJ41wEfC7DL86GVtK-Q")]
    [Description(@"Device worn on the body (such as fitness band, smart ring) that supports payment functionality.")]
    Wearable,
}
