// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of reading of the card data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TWF24QEcEeCQm6a_G2yO_w_-992719908")]
[Description(@"Type of reading of the card data.")]
[Derivations(
    typeof(CardDataWriting1Code),
    typeof(CardDataReading2Code),
    typeof(CardDataReading6Code),
    typeof(CardDataReading4Code),
    typeof(CardDataReading9Code),
    typeof(CardDataReading3Code),
    typeof(CardDataReading5Code),
    typeof(CardDataReading10Code),
    typeof(CardDataReading1Code),
    typeof(CardDataReading8Code),
    typeof(CardDataReading7Code),
    typeof(CardDataReading11Code),
    typeof(CardDataReading12Code)
)]
public enum CardDataReadingCode
{
    /// <summary>
    /// Tag reading capabilities (RFID, etc.).
    /// Encoded/decoded by serializers as &quot;TAGC&quot;.
    /// </summary>
    [EnumMember(Value = "TAGC")]
    [IsoId("_TWF24gEcEeCQm6a_G2yO_w_-1811496600")]
    [Description(@"Tag reading capabilities (RFID, etc.).")]
    Tag,

    /// <summary>
    /// Keyboard entry or OCR reading of embossing or printed data, either at time of transaction or after the event.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_TWF24wEcEeCQm6a_G2yO_w_989234015")]
    [Description(
        @"Keyboard entry or OCR reading of embossing or printed data, either at time of transaction or after the event."
    )]
    Physical,

    /// <summary>
    /// Bar code.
    /// Encoded/decoded by serializers as &quot;BRCD&quot;.
    /// </summary>
    [EnumMember(Value = "BRCD")]
    [IsoId("_TWF25AEcEeCQm6a_G2yO_w_1206282710")]
    [Description(@"Bar code.")]
    BarCode,

    /// <summary>
    /// Magnetic stripe.
    /// Encoded/decoded by serializers as &quot;MGST&quot;.
    /// </summary>
    [EnumMember(Value = "MGST")]
    [IsoId("_TWF25QEcEeCQm6a_G2yO_w_-996765754")]
    [Description(@"Magnetic stripe.")]
    MagneticStripe,

    /// <summary>
    /// ICC (Integrated Circuit Card) with contact containing software applications conform to ISO 7816.
    /// Encoded/decoded by serializers as &quot;CICC&quot;.
    /// </summary>
    [EnumMember(Value = "CICC")]
    [IsoId("_TWF25gEcEeCQm6a_G2yO_w_-1007864531")]
    [Description(
        @"ICC (Integrated Circuit Card) with contact containing software applications conform to ISO 7816."
    )]
    ICC,

    /// <summary>
    /// Account data on file.
    /// Encoded/decoded by serializers as &quot;DFLE&quot;.
    /// </summary>
    [EnumMember(Value = "DFLE")]
    [IsoId("_TWF25wEcEeCQm6a_G2yO_w_1277145907")]
    [Description(@"Account data on file.")]
    AccountData,

    /// <summary>
    /// Contactless proximity reader.
    /// Encoded/decoded by serializers as &quot;CTLS&quot;.
    /// </summary>
    [EnumMember(Value = "CTLS")]
    [IsoId("_TWF26AEcEeCQm6a_G2yO_w_1731233176")]
    [Description(@"Contactless proximity reader.")]
    ProximityReader,

    /// <summary>
    /// Contactless proximity reader, with application conform to the standard EMV (standard initiated by Europay, Mastercard and Visa).
    /// Encoded/decoded by serializers as &quot;ECTL&quot;.
    /// </summary>
    [EnumMember(Value = "ECTL")]
    [IsoId("_TWF26QEcEeCQm6a_G2yO_w_-1911037779")]
    [Description(
        @"Contactless proximity reader, with application conform to the standard EMV (standard initiated by Europay, Mastercard and Visa)."
    )]
    EMVProximityReader,

    /// <summary>
    /// Card information are stored on a file.
    /// Encoded/decoded by serializers as &quot;CDFL&quot;.
    /// </summary>
    [EnumMember(Value = "CDFL")]
    [IsoId("_ojDi0HrwEeSz_of_1TY14A")]
    [Description(@"Card information are stored on a file.")]
    CardOnFile,

    /// <summary>
    /// Unknown card reading capability.
    /// Encoded/decoded by serializers as &quot;UNKW&quot;.
    /// </summary>
    [EnumMember(Value = "UNKW")]
    [IsoId("_s8wG8HrwEeSz_of_1TY14A")]
    [Description(@"Unknown card reading capability.")]
    Unknown,

    /// <summary>
    /// Synchronous ICC - (Integrated Circuit Card) with contact.
    /// Encoded/decoded by serializers as &quot;SICC&quot;.
    /// </summary>
    [EnumMember(Value = "SICC")]
    [IsoId("_TMi9cNkIEeiojJsa6FYyew")]
    [Description(@"Synchronous ICC - (Integrated Circuit Card) with contact.")]
    SynchronousIntegratedCircuitCard,

    /// <summary>
    /// ICC contact capability
    /// Encoded/decoded by serializers as &quot;ICCY&quot;.
    /// </summary>
    [EnumMember(Value = "ICCY")]
    [IsoId("_JxABK3x8EemHsOqJOzMVfg")]
    [Description(@"ICC contact capability")]
    ICCContact,

    /// <summary>
    /// ICC contactless proximity
    /// Encoded/decoded by serializers as &quot;ICPY&quot;.
    /// </summary>
    [EnumMember(Value = "ICPY")]
    [IsoId("_JxABLHx8EemHsOqJOzMVfg")]
    [Description(@"ICC contactless proximity")]
    ICCProximity,

    /// <summary>
    /// Recognition of magnetic ink characters
    /// Encoded/decoded by serializers as &quot;MICR&quot;.
    /// </summary>
    [EnumMember(Value = "MICR")]
    [IsoId("_JxABLXx8EemHsOqJOzMVfg")]
    [Description(@"Recognition of magnetic ink characters")]
    MagneticInkCharacterRecognition,

    /// <summary>
    /// Manual, no terminal used.
    /// Encoded/decoded by serializers as &quot;MLEY&quot;.
    /// </summary>
    [EnumMember(Value = "MLEY")]
    [IsoId("_JxABLnx8EemHsOqJOzMVfg")]
    [Description(@"Manual, no terminal used.")]
    ManualEntry,

    /// <summary>
    /// Magstripe image contactless proximity
    /// Encoded/decoded by serializers as &quot;MSIP&quot;.
    /// </summary>
    [EnumMember(Value = "MSIP")]
    [IsoId("_JxABL3x8EemHsOqJOzMVfg")]
    [Description(@"Magstripe image contactless proximity")]
    MSIProximity,

    /// <summary>
    /// OCR either at time of transaction or after the event.
    /// Encoded/decoded by serializers as &quot;OCRR&quot;.
    /// </summary>
    [EnumMember(Value = "OCRR")]
    [IsoId("_JxABMHx8EemHsOqJOzMVfg")]
    [Description(@"OCR either at time of transaction or after the event.")]
    OpticalCharacterRecognition,

    /// <summary>
    /// Optical coded reading capabilities (e.g. barcode, QR code, etc.)
    /// Encoded/decoded by serializers as &quot;OPTC&quot;.
    /// </summary>
    [EnumMember(Value = "OPTC")]
    [IsoId("_JxABMXx8EemHsOqJOzMVfg")]
    [Description(@"Optical coded reading capabilities (e.g. barcode, QR code, etc.)")]
    OpticalCode,

    /// <summary>
    /// Other national capability type assigned at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_JxABMnx8EemHsOqJOzMVfg")]
    [Description(@"Other national capability type assigned at national level.")]
    OtherNational,

    /// <summary>
    /// Other card reading capability assigned on a private basis.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_JxABM3x8EemHsOqJOzMVfg")]
    [Description(@"Other card reading capability assigned on a private basis.")]
    OtherPrivate,

    /// <summary>
    /// Radio Frequency Identification tag capabilities.
    /// Encoded/decoded by serializers as &quot;RFID&quot;.
    /// </summary>
    [EnumMember(Value = "RFID")]
    [IsoId("_JxABNHx8EemHsOqJOzMVfg")]
    [Description(@"Radio Frequency Identification tag capabilities.")]
    RFIDTag,

    /// <summary>
    /// Unspecified capability.
    /// Encoded/decoded by serializers as &quot;UNSP&quot;.
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("_JxABNXx8EemHsOqJOzMVfg")]
    [Description(@"Unspecified capability.")]
    Unspecified,

    /// <summary>
    /// Key entered.
    /// Encoded/decoded by serializers as &quot;KEEN&quot;.
    /// </summary>
    [EnumMember(Value = "KEEN")]
    [IsoId("_MeKSkOm3EemNVKPwszFC-A")]
    [Description(@"Key entered.")]
    KeyEntered,

    /// <summary>
    /// Quick response code.
    /// Encoded/decoded by serializers as &quot;QRCD&quot;.
    /// </summary>
    [EnumMember(Value = "QRCD")]
    [IsoId("_iG5MwAxtEeqdx6buGpCCQw")]
    [Description(@"Quick response code.")]
    QRCode,

    /// <summary>
    /// Card details captured via camera.
    /// Encoded/decoded by serializers as &quot;CAMR&quot;.
    /// </summary>
    [EnumMember(Value = "CAMR")]
    [IsoId("_rDxKYJleEeu76rs9yGlfEg")]
    [Description(@"Card details captured via camera.")]
    Camera,

    /// <summary>
    /// Card details were obtained via a mobile banking application.
    /// Encoded/decoded by serializers as &quot;MBNK&quot;.
    /// </summary>
    [EnumMember(Value = "MBNK")]
    [IsoId("_n9xOwMmuEeuF1f85xf6dbg")]
    [Description(@"Card details were obtained via a mobile banking application.")]
    MobileBankingApplication,

    /// <summary>
    /// Card details were obtained via a token.
    /// Encoded/decoded by serializers as &quot;TOKN&quot;.
    /// </summary>
    [EnumMember(Value = "TOKN")]
    [IsoId("_FyNH4MmvEeuF1f85xf6dbg")]
    [Description(@"Card details were obtained via a token.")]
    Token,

    /// <summary>
    /// Card information are stored on a server.
    /// Encoded/decoded by serializers as &quot;CDFS&quot;.
    /// </summary>
    [EnumMember(Value = "CDFS")]
    [IsoId("_uhlesBQcEfC1ZfCQz0xB3g")]
    [Description(@"Card information are stored on a server.")]
    CredentialOnServer,

    /// <summary>
    /// Domestic ICC Contactless.
    /// Encoded/decoded by serializers as &quot;DCPY&quot;.
    /// </summary>
    [EnumMember(Value = "DCPY")]
    [IsoId("_CwKgUHFxEfC68Y4jZPNEug")]
    [Description(@"Domestic ICC Contactless.")]
    ICCProximityPrivate,

    /// <summary>
    /// Integrated circuit card read; only partial data is available.
    /// Encoded/decoded by serializers as &quot;ICCP&quot;.
    /// </summary>
    [EnumMember(Value = "ICCP")]
    [IsoId("_IEmbYBQcEfC1ZfCQz0xB3g")]
    [Description(@"Integrated circuit card read; only partial data is available.")]
    ICCContactPartial,

    /// <summary>
    /// ICC contact with fallback to manual mode.
    /// Encoded/decoded by serializers as &quot;ICFM&quot;.
    /// </summary>
    [EnumMember(Value = "ICFM")]
    [IsoId("_HfBcIHFxEfC68Y4jZPNEug")]
    [Description(@"ICC contact with fallback to manual mode.")]
    ICCFallbackManual,

    /// <summary>
    /// ICC contact with fallback to magstripe mode.
    /// Encoded/decoded by serializers as &quot;ICMG&quot;.
    /// </summary>
    [EnumMember(Value = "ICMG")]
    [IsoId("_VIRgEHFxEfC68Y4jZPNEug")]
    [Description(@"ICC contact with fallback to magstripe mode.")]
    ICCFallbackMagstripe,

    /// <summary>
    /// Magnetic stripe is read, only partial data is available.
    /// Encoded/decoded by serializers as &quot;MGSP&quot;.
    /// </summary>
    [EnumMember(Value = "MGSP")]
    [IsoId("_zXLKEBQbEfC1ZfCQz0xB3g")]
    [Description(@"Magnetic stripe is read, only partial data is available.")]
    MagneticStripePartial,

    /// <summary>
    /// NFC Type-F frequency.
    /// Encoded/decoded by serializers as &quot;NFCF&quot;.
    /// </summary>
    [EnumMember(Value = "NFCF")]
    [IsoId("_ScDXYBQcEfC1ZfCQz0xB3g")]
    [Description(@"NFC Type-F frequency.")]
    TypeF,

    /// <summary>
    /// Other card data reading mode.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_eO3RIHFxEfC68Y4jZPNEug")]
    [Description(@"Other card data reading mode.")]
    Other,
}
