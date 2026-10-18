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
[IsoId("_FWHXwI1xEfC7DL86GVtK-Q")]
[Description(
    @"Specified a type of customer device used for a card payment transaction.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalCustomerDeviceTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalCustomerDeviceType1Code>))]
public enum ExternalCustomerDeviceType1Code
{
    /// <summary>
    /// Payment-enabled component integrated into another device or appliance.
    /// Encoded/decoded by serializers as &quot;EMBD&quot;.
    /// </summary>
    [EnumMember(Value = "EMBD")]
    [IsoId("_gdQbEc7WEfCrxKcxW84MwQ")]
    [Description(@"Payment-enabled component integrated into another device or appliance.")]
    Embedded = ExternalCustomerDeviceTypeCode.Embedded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Console or gaming system that supports in-game or digital purchases.
    /// Encoded/decoded by serializers as &quot;GAMB&quot;.
    /// </summary>
    [EnumMember(Value = "GAMB")]
    [IsoId("_gdUFcc7WEfCrxKcxW84MwQ")]
    [Description(@"Console or gaming system that supports in-game or digital purchases.")]
    GamingDevice = ExternalCustomerDeviceTypeCode.GamingDevice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Voice-activated device without a screen (e.g., smart speaker) used for initiating transactions.
    /// Encoded/decoded by serializers as &quot;HDST&quot;.
    /// </summary>
    [EnumMember(Value = "HDST")]
    [IsoId("_gdXIwc7WEfCrxKcxW84MwQ")]
    [Description(@"Voice-activated device without a screen (e.g., smart speaker) used for initiating transactions.")]
    HeadlessVoice = ExternalCustomerDeviceTypeCode.HeadlessVoice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Any IoT-enabled device capable of initiating or receiving payments (e.g., smart fridge ordering groceries).
    /// Encoded/decoded by serializers as &quot;IOTS&quot;.
    /// </summary>
    [EnumMember(Value = "IOTS")]
    [IsoId("_gdXv0c7WEfCrxKcxW84MwQ")]
    [Description(@"Any IoT-enabled device capable of initiating or receiving payments (e.g., smart fridge ordering groceries).")]
    InternetOfThings = ExternalCustomerDeviceTypeCode.InternetOfThings, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment-enabled jewelry such as rings or bracelets with NFC or tokenization capabilities.
    /// Encoded/decoded by serializers as &quot;JEWL&quot;.
    /// </summary>
    [EnumMember(Value = "JEWL")]
    [IsoId("_gdS3Uc7WEfCrxKcxW84MwQ")]
    [Description(@"Payment-enabled jewelry such as rings or bracelets with NFC or tokenization capabilities.")]
    Jewellery = ExternalCustomerDeviceTypeCode.Jewellery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Small portable device, often used for contactless payments.
    /// Encoded/decoded by serializers as &quot;KFOB&quot;.
    /// </summary>
    [EnumMember(Value = "KFOB")]
    [IsoId("_gdRpMc7WEfCrxKcxW84MwQ")]
    [Description(@"Small portable device, often used for contactless payments.")]
    KeyFob = ExternalCustomerDeviceTypeCode.KeyFob, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Smartphone used for initiating or receiving transactions, often via apps or NFC.
    /// Encoded/decoded by serializers as &quot;MOBL&quot;.
    /// </summary>
    [EnumMember(Value = "MOBL")]
    [IsoId("_gdJtYc7WEfCrxKcxW84MwQ")]
    [Description(@"Smartphone used for initiating or receiving transactions, often via apps or NFC.")]
    Mobile = ExternalCustomerDeviceTypeCode.Mobile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card reader without advanced security features, typically used for low-risk or offline transactions.
    /// Encoded/decoded by serializers as &quot;NSCR&quot;.
    /// </summary>
    [EnumMember(Value = "NSCR")]
    [IsoId("_gdIfQc7WEfCrxKcxW84MwQ")]
    [Description(@"Card reader without advanced security features, typically used for low-risk or offline transactions.")]
    NonSecureCardReader = ExternalCustomerDeviceTypeCode.NonSecureCardReader, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Device type specific to a national payment scheme or infrastructure (such as proprietary POS terminals mandated by a country).
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_gdMJoc7WEfCrxKcxW84MwQ")]
    [Description(
        @"Device type specific to a national payment scheme or infrastructure (such as proprietary POS terminals mandated by a country)."
    )]
    OtherNational = ExternalCustomerDeviceTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Proprietary device type used within a private network or closed-loop payment system.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_gdMwsc7WEfCrxKcxW84MwQ")]
    [Description(@"Proprietary device type used within a private network or closed-loop payment system.")]
    OtherPrivate = ExternalCustomerDeviceTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Desktop or laptop computer used for online transactions through browsers or installed software.
    /// Encoded/decoded by serializers as &quot;PECR&quot;.
    /// </summary>
    [EnumMember(Value = "PECR")]
    [IsoId("_gdK7gc7WEfCrxKcxW84MwQ")]
    [Description(@"Desktop or laptop computer used for online transactions through browsers or installed software.")]
    PersonalComputer = ExternalCustomerDeviceTypeCode.PersonalComputer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card reader device that meets security standards for encrypted PIN entry and secure transaction processing.
    /// Encoded/decoded by serializers as &quot;SECR&quot;.
    /// </summary>
    [EnumMember(Value = "SECR")]
    [IsoId("_gdH4Mc7WEfCrxKcxW84MwQ")]
    [Description(
        @"Card reader device that meets security standards for encrypted PIN entry and secure transaction processing."
    )]
    SecureCardReader = ExternalCustomerDeviceTypeCode.SecureCardReader, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment sticker with embedded NFC or RFID, typically attached to a physical object for tap-and-pay.
    /// Encoded/decoded by serializers as &quot;STIC&quot;.
    /// </summary>
    [EnumMember(Value = "STIC")]
    [IsoId("_gdTeYc7WEfCrxKcxW84MwQ")]
    [Description(@"Payment sticker with embedded NFC or RFID, typically attached to a physical object for tap-and-pay.")]
    Sticker = ExternalCustomerDeviceTypeCode.Sticker, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Touchscreen tablet device functioning similarly to a mobile device for payments.
    /// Encoded/decoded by serializers as &quot;TBLT&quot;.
    /// </summary>
    [EnumMember(Value = "TBLT")]
    [IsoId("_gdKUcc7WEfCrxKcxW84MwQ")]
    [Description(@"Touchscreen tablet device functioning similarly to a mobile device for payments.")]
    Tablet = ExternalCustomerDeviceTypeCode.Tablet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Smart TV or connected device enabling payments for streaming or interactive services.
    /// Encoded/decoded by serializers as &quot;TLVN&quot;.
    /// </summary>
    [EnumMember(Value = "TLVN")]
    [IsoId("_gdWhsc7WEfCrxKcxW84MwQ")]
    [Description(@"Smart TV or connected device enabling payments for streaming or interactive services.")]
    Television = ExternalCustomerDeviceTypeCode.Television, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Device type cannot be determined or is not disclosed.
    /// Encoded/decoded by serializers as &quot;UNKW&quot;.
    /// </summary>
    [EnumMember(Value = "UNKW")]
    [IsoId("_gdV6oc7WEfCrxKcxW84MwQ")]
    [Description(@"Device type cannot be determined or is not disclosed.")]
    Unknown = ExternalCustomerDeviceTypeCode.Unknown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In-vehicle system enabling payments (such as tolls, fuel, parking) through embedded technology.
    /// Encoded/decoded by serializers as &quot;VHCL&quot;.
    /// </summary>
    [EnumMember(Value = "VHCL")]
    [IsoId("_gdOl4c7WEfCrxKcxW84MwQ")]
    [Description(@"In-vehicle system enabling payments (such as tolls, fuel, parking) through embedded technology.")]
    Vehicle = ExternalCustomerDeviceTypeCode.Vehicle, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Smartwatch with payment capabilities.
    /// Encoded/decoded by serializers as &quot;WATC&quot;.
    /// </summary>
    [EnumMember(Value = "WATC")]
    [IsoId("_gdUsgc7WEfCrxKcxW84MwQ")]
    [Description(@"Smartwatch with payment capabilities.")]
    Watch = ExternalCustomerDeviceTypeCode.Watch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Device worn on the body (such as fitness band, smart ring) that supports payment functionality.
    /// Encoded/decoded by serializers as &quot;WRBL&quot;.
    /// </summary>
    [EnumMember(Value = "WRBL")]
    [IsoId("_gdNXwc7WEfCrxKcxW84MwQ")]
    [Description(@"Device worn on the body (such as fitness band, smart ring) that supports payment functionality.")]
    Wearable = ExternalCustomerDeviceTypeCode.Wearable, // same ordinal as derivation source for type conversions
}
