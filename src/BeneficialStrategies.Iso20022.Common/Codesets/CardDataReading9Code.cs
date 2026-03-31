// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Method used to obtain card payment information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ApKlgJlfEeu76rs9yGlfEg")]
[Description(@"Method used to obtain card payment information.")]
[DerivedFrom(typeof(CardDataReadingCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CardDataReading9Code>))]
#endif
public enum CardDataReading9Code
{
    /// <summary>
    /// Unknown card reading capability.
    /// Encoded/decoded by serializers as &quot;UNKW&quot;.
    /// </summary>
    [EnumMember(Value = "UNKW")]
    [IsoId("_JDP14ZlfEeu76rs9yGlfEg")]
    [Description(@"Unknown card reading capability.")]
    Unknown = CardDataReadingCode.Unknown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other national capability type assigned at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_JtshEZlfEeu76rs9yGlfEg")]
    [Description(@"Other national capability type assigned at national level.")]
    OtherNational = CardDataReadingCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other card reading capability assigned on a private basis.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_J0hh0ZlfEeu76rs9yGlfEg")]
    [Description(@"Other card reading capability assigned on a private basis.")]
    OtherPrivate = CardDataReadingCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card details captured via camera.
    /// Encoded/decoded by serializers as &quot;CAMR&quot;.
    /// </summary>
    [EnumMember(Value = "CAMR")]
    [IsoId("_N2p6gZlfEeu76rs9yGlfEg")]
    [Description(@"Card details captured via camera.")]
    Camera = CardDataReadingCode.Camera, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Key entered.
    /// Encoded/decoded by serializers as &quot;KEEN&quot;.
    /// </summary>
    [EnumMember(Value = "KEEN")]
    [IsoId("_ujzGIZlfEeu76rs9yGlfEg")]
    [Description(@"Key entered.")]
    KeyEntered = CardDataReadingCode.KeyEntered, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ICC contactless proximity
    /// Encoded/decoded by serializers as &quot;ICPY&quot;.
    /// </summary>
    [EnumMember(Value = "ICPY")]
    [IsoId("_05JGUazhEeurLutE1vUWxQ")]
    [Description(@"ICC contactless proximity")]
    ICCProximity = CardDataReadingCode.ICCProximity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Optical coded reading capabilities (e.g. barcode, QR code, etc.)
    /// Encoded/decoded by serializers as &quot;OPTC&quot;.
    /// </summary>
    [EnumMember(Value = "OPTC")]
    [IsoId("_iyilMa7BEeuhTp7lI6XAzA")]
    [Description(@"Optical coded reading capabilities (e.g. barcode, QR code, etc.)")]
    OpticalCode = CardDataReadingCode.OpticalCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card information are stored on a file.
    /// Encoded/decoded by serializers as &quot;CDFL&quot;.
    /// </summary>
    [EnumMember(Value = "CDFL")]
    [IsoId("_b9Nm8cmuEeuF1f85xf6dbg")]
    [Description(@"Card information are stored on a file.")]
    CardOnFile = CardDataReadingCode.CardOnFile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card details were obtained via a mobile banking application.
    /// Encoded/decoded by serializers as &quot;MBNK&quot;.
    /// </summary>
    [EnumMember(Value = "MBNK")]
    [IsoId("_4QIqAcmuEeuF1f85xf6dbg")]
    [Description(@"Card details were obtained via a mobile banking application.")]
    MobileBankingApplication = CardDataReadingCode.MobileBankingApplication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card details were obtained via a token.
    /// Encoded/decoded by serializers as &quot;TOKN&quot;.
    /// </summary>
    [EnumMember(Value = "TOKN")]
    [IsoId("_OuQc4cmvEeuF1f85xf6dbg")]
    [Description(@"Card details were obtained via a token.")]
    Token = CardDataReadingCode.Token, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ICC contact capability
    /// Encoded/decoded by serializers as &quot;ICCY&quot;.
    /// </summary>
    [EnumMember(Value = "ICCY")]
    [IsoId("_XJ0T8cmvEeuF1f85xf6dbg")]
    [Description(@"ICC contact capability")]
    ICCContact = CardDataReadingCode.ICCContact, // same ordinal as derivation source for type conversions
}
