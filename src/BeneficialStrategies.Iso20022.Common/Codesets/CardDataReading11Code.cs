// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Card reading capabilities of the terminal performing the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hrr8kRQXEfC1ZfCQz0xB3g")]
[Description(@"Card reading capabilities of the terminal performing the transaction.")]
[DerivedFrom(typeof(CardDataReadingCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<CardDataReading11Code>))]
public enum CardDataReading11Code
{
    /// <summary>
    /// Card information are stored on a file.
    /// Encoded/decoded by serializers as &quot;CDFL&quot;.
    /// </summary>
    [EnumMember(Value = "CDFL")]
    [IsoId("_GZDDERQdEfC1ZfCQz0xB3g")]
    [Description(@"Card information are stored on a file.")]
    CardOnFile = CardDataReadingCode.CardOnFile,

    /// <summary>
    /// Card information are stored on a server.
    /// Encoded/decoded by serializers as &quot;CDFS&quot;.
    /// </summary>
    [EnumMember(Value = "CDFS")]
    [IsoId("_FsAW4RQdEfC1ZfCQz0xB3g")]
    [Description(@"Card information are stored on a server.")]
    CredentialOnServer = CardDataReadingCode.CredentialOnServer,

    /// <summary>
    /// Domestic ICC Contactless.
    /// Encoded/decoded by serializers as &quot;DCPY&quot;.
    /// </summary>
    [EnumMember(Value = "DCPY")]
    [IsoId("_dATzUXFxEfC68Y4jZPNEug")]
    [Description(@"Domestic ICC Contactless.")]
    ICCProximityPrivate = CardDataReadingCode.ICCProximityPrivate,

    /// <summary>
    /// Integrated circuit card read; only partial data is available.
    /// Encoded/decoded by serializers as &quot;ICCP&quot;.
    /// </summary>
    [EnumMember(Value = "ICCP")]
    [IsoId("_P8onQRQfEfC_aaedwHHlmw")]
    [Description(@"Integrated circuit card read; only partial data is available.")]
    ICCContactPartial = CardDataReadingCode.ICCContactPartial,

    /// <summary>
    /// ICC contact capability.
    /// Encoded/decoded by serializers as &quot;ICCY&quot;.
    /// </summary>
    [EnumMember(Value = "ICCY")]
    [IsoId("_KgSv0RQeEfC1ZfCQz0xB3g")]
    [Description(@"ICC contact capability.")]
    ICCContact = CardDataReadingCode.ICCContact,

    /// <summary>
    /// ICC contact with fallback to manual mode.
    /// Encoded/decoded by serializers as &quot;ICFM&quot;.
    /// </summary>
    [EnumMember(Value = "ICFM")]
    [IsoId("_c3AGUXFxEfC68Y4jZPNEug")]
    [Description(@"ICC contact with fallback to manual mode.")]
    ICCFallbackManual = CardDataReadingCode.ICCFallbackManual,

    /// <summary>
    /// ICC contact with fallback to magstripe mode.
    /// Encoded/decoded by serializers as &quot;ICMG&quot;.
    /// </summary>
    [EnumMember(Value = "ICMG")]
    [IsoId("_ci8h4XFxEfC68Y4jZPNEug")]
    [Description(@"ICC contact with fallback to magstripe mode.")]
    ICCFallbackMagstripe = CardDataReadingCode.ICCFallbackMagstripe,

    /// <summary>
    /// ICC contactless proximity.
    /// Encoded/decoded by serializers as &quot;ICPY&quot;.
    /// </summary>
    [EnumMember(Value = "ICPY")]
    [IsoId("_hzAFgRQXEfC1ZfCQz0xB3g")]
    [Description(@"ICC contactless proximity.")]
    ICCProximity = CardDataReadingCode.ICCProximity,

    /// <summary>
    /// Key entered.
    /// Encoded/decoded by serializers as &quot;KEEN&quot;.
    /// </summary>
    [EnumMember(Value = "KEEN")]
    [IsoId("_hzAFmRQXEfC1ZfCQz0xB3g")]
    [Description(@"Key entered.")]
    KeyEntered = CardDataReadingCode.KeyEntered,

    /// <summary>
    /// Magnetic stripe is read, only partial data is available.
    /// Encoded/decoded by serializers as &quot;MGSP&quot;.
    /// </summary>
    [EnumMember(Value = "MGSP")]
    [IsoId("_hzAFgxQXEfC1ZfCQz0xB3g")]
    [Description(@"Magnetic stripe is read, only partial data is available.")]
    MagneticStripePartial = CardDataReadingCode.MagneticStripePartial,

    /// <summary>
    /// Magnetic stripe.
    /// Encoded/decoded by serializers as &quot;MGST&quot;.
    /// </summary>
    [EnumMember(Value = "MGST")]
    [IsoId("_Hk-qsRQdEfC1ZfCQz0xB3g")]
    [Description(@"Magnetic stripe.")]
    MagneticStripe = CardDataReadingCode.MagneticStripe,

    /// <summary>
    /// Recognition of magnetic ink characters.
    /// Encoded/decoded by serializers as &quot;MICR&quot;.
    /// </summary>
    [EnumMember(Value = "MICR")]
    [IsoId("_hzAFhxQXEfC1ZfCQz0xB3g")]
    [Description(@"Recognition of magnetic ink characters.")]
    MagneticInkCharacterRecognition = CardDataReadingCode.MagneticInkCharacterRecognition,

    /// <summary>
    /// Manual, no terminal used.
    /// Encoded/decoded by serializers as &quot;MLEY&quot;.
    /// </summary>
    [EnumMember(Value = "MLEY")]
    [IsoId("_hzAFiRQXEfC1ZfCQz0xB3g")]
    [Description(@"Manual, no terminal used.")]
    ManualEntry = CardDataReadingCode.ManualEntry,

    /// <summary>
    /// Magstripe image contactless proximity.
    /// Encoded/decoded by serializers as &quot;MSIP&quot;.
    /// </summary>
    [EnumMember(Value = "MSIP")]
    [IsoId("_hzAFjRQXEfC1ZfCQz0xB3g")]
    [Description(@"Magstripe image contactless proximity.")]
    MSIProximity = CardDataReadingCode.MSIProximity,

    /// <summary>
    /// NFC Type-F frequency.
    /// Encoded/decoded by serializers as &quot;NFCF&quot;.
    /// </summary>
    [EnumMember(Value = "NFCF")]
    [IsoId("_Jqx5kRQdEfC1ZfCQz0xB3g")]
    [Description(@"NFC Type-F frequency.")]
    TypeF = CardDataReadingCode.TypeF,

    /// <summary>
    /// OCR either at time of transaction or after the event.
    /// Encoded/decoded by serializers as &quot;OCRR&quot;.
    /// </summary>
    [EnumMember(Value = "OCRR")]
    [IsoId("_hzAFixQXEfC1ZfCQz0xB3g")]
    [Description(@"OCR either at time of transaction or after the event.")]
    OpticalCharacterRecognition = CardDataReadingCode.OpticalCharacterRecognition,

    /// <summary>
    /// Optical coded reading capabilities (e.g. barcode, QR code, etc.).
    /// Encoded/decoded by serializers as &quot;OPTC&quot;.
    /// </summary>
    [EnumMember(Value = "OPTC")]
    [IsoId("_hzAFjxQXEfC1ZfCQz0xB3g")]
    [Description(@"Optical coded reading capabilities (e.g. barcode, QR code, etc.).")]
    OpticalCode = CardDataReadingCode.OpticalCode,

    /// <summary>
    /// Other card data reading mode.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZaewwX3VEfCmC4yYaU27Kg")]
    [Description(@"Other card data reading mode.")]
    Other = CardDataReadingCode.Other,

    /// <summary>
    /// Radio Frequency Identification tag capabilities.
    /// Encoded/decoded by serializers as &quot;RFID&quot;.
    /// </summary>
    [EnumMember(Value = "RFID")]
    [IsoId("_hzAFkxQXEfC1ZfCQz0xB3g")]
    [Description(@"Radio Frequency Identification tag capabilities.")]
    RFIDTag = CardDataReadingCode.RFIDTag,

    /// <summary>
    /// Unspecified capability.
    /// Encoded/decoded by serializers as &quot;UNSP&quot;.
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("_hzAFlRQXEfC1ZfCQz0xB3g")]
    [Description(@"Unspecified capability.")]
    Unspecified = CardDataReadingCode.Unspecified,
}
