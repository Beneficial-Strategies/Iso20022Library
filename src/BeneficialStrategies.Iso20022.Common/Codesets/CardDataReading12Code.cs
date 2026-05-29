// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Method used to obtain card payment information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_u1jyURQWEfC1ZfCQz0xB3g")]
[Description(@"Method used to obtain card payment information.")]
[DerivedFrom(typeof(CardDataReadingCode))]
public enum CardDataReading12Code
{
    /// <summary>
    /// Card details captured via camera.
    /// Encoded/decoded by serializers as &quot;CAMR&quot;.
    /// </summary>
    [EnumMember(Value = "CAMR")]
    [IsoId("_u8xNlxQWEfC1ZfCQz0xB3g")]
    [Description(@"Card details captured via camera.")]
    Camera = CardDataReadingCode.Camera,

    /// <summary>
    /// Card information are stored on a file.
    /// Encoded/decoded by serializers as &quot;CDFL&quot;.
    /// </summary>
    [EnumMember(Value = "CDFL")]
    [IsoId("_u8xNnxQWEfC1ZfCQz0xB3g")]
    [Description(@"Card information are stored on a file.")]
    CardOnFile = CardDataReadingCode.CardOnFile,

    /// <summary>
    /// Integrated circuit card read; only partial data is available.
    /// Encoded/decoded by serializers as &quot;ICCP&quot;.
    /// </summary>
    [EnumMember(Value = "ICCP")]
    [IsoId("_u8xNpRQWEfC1ZfCQz0xB3g")]
    [Description(@"Integrated circuit card read; only partial data is available.")]
    ICCContactPartial = CardDataReadingCode.ICCContactPartial,

    /// <summary>
    /// ICC contactless proximity.
    /// Encoded/decoded by serializers as &quot;ICPY&quot;.
    /// </summary>
    [EnumMember(Value = "ICPY")]
    [IsoId("_u8xNmxQWEfC1ZfCQz0xB3g")]
    [Description(@"ICC contactless proximity.")]
    ICCProximity = CardDataReadingCode.ICCProximity,

    /// <summary>
    /// Key entered.
    /// Encoded/decoded by serializers as &quot;KEEN&quot;.
    /// </summary>
    [EnumMember(Value = "KEEN")]
    [IsoId("_u8xNmRQWEfC1ZfCQz0xB3g")]
    [Description(@"Key entered.")]
    KeyEntered = CardDataReadingCode.KeyEntered,

    /// <summary>
    /// Card details were obtained via a mobile banking application.
    /// Encoded/decoded by serializers as &quot;MBNK&quot;.
    /// </summary>
    [EnumMember(Value = "MBNK")]
    [IsoId("_u8xNoRQWEfC1ZfCQz0xB3g")]
    [Description(@"Card details were obtained via a mobile banking application.")]
    MobileBankingApplication = CardDataReadingCode.MobileBankingApplication,

    /// <summary>
    /// Optical coded reading capabilities (e.g. barcode, QR code, etc.).
    /// Encoded/decoded by serializers as &quot;OPTC&quot;.
    /// </summary>
    [EnumMember(Value = "OPTC")]
    [IsoId("_u8xNnRQWEfC1ZfCQz0xB3g")]
    [Description(@"Optical coded reading capabilities (e.g. barcode, QR code, etc.).")]
    OpticalCode = CardDataReadingCode.OpticalCode,

    /// <summary>
    /// Card details were obtained via a token.
    /// Encoded/decoded by serializers as &quot;TOKN&quot;.
    /// </summary>
    [EnumMember(Value = "TOKN")]
    [IsoId("_u8xNoxQWEfC1ZfCQz0xB3g")]
    [Description(@"Card details were obtained via a token.")]
    Token = CardDataReadingCode.Token,

    /// <summary>
    /// Unknown card reading capability.
    /// Encoded/decoded by serializers as &quot;UNKW&quot;.
    /// </summary>
    [EnumMember(Value = "UNKW")]
    [IsoId("_u8xNkRQWEfC1ZfCQz0xB3g")]
    [Description(@"Unknown card reading capability.")]
    Unknown = CardDataReadingCode.Unknown,
}
