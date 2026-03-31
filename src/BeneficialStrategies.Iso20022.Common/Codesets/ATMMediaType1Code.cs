// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of media inside an ATM cassette.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-L27wIqdEeS4a4abTJTSSw")]
[Description(@"Type of media inside an ATM cassette.")]
[DerivedFrom(typeof(ATMMediaTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ATMMediaType1Code>))]
#endif
public enum ATMMediaType1Code
{
    /// <summary>
    /// Card media.
    /// Encoded/decoded by serializers as &quot;CARD&quot;.
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_JV2vAYqeEeS4a4abTJTSSw")]
    [Description(@"Card media.")]
    Cards = ATMMediaTypeCode.Cards, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Coin media.
    /// Encoded/decoded by serializers as &quot;COIN&quot;.
    /// </summary>
    [EnumMember(Value = "COIN")]
    [IsoId("_Jcs94YqeEeS4a4abTJTSSw")]
    [Description(@"Coin media.")]
    Coins = ATMMediaTypeCode.Coins, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Non fixed value of the media, for instance gold, silver.
    /// Encoded/decoded by serializers as &quot;CMDT&quot;.
    /// </summary>
    [EnumMember(Value = "CMDT")]
    [IsoId("_Jiqb8YqeEeS4a4abTJTSSw")]
    [Description(@"Non fixed value of the media, for instance gold, silver.")]
    Commodity = ATMMediaTypeCode.Commodity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Coupon media.
    /// Encoded/decoded by serializers as &quot;CPNS&quot;.
    /// </summary>
    [EnumMember(Value = "CPNS")]
    [IsoId("_JnvJMYqeEeS4a4abTJTSSw")]
    [Description(@"Coupon media.")]
    Coupons = ATMMediaTypeCode.Coupons, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank note media.
    /// Encoded/decoded by serializers as &quot;NOTE&quot;.
    /// </summary>
    [EnumMember(Value = "NOTE")]
    [IsoId("_J9VlwYqeEeS4a4abTJTSSw")]
    [Description(@"Bank note media.")]
    Notes = ATMMediaTypeCode.Notes, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Stamp media.
    /// Encoded/decoded by serializers as &quot;STMP&quot;.
    /// </summary>
    [EnumMember(Value = "STMP")]
    [IsoId("_KFrpcYqeEeS4a4abTJTSSw")]
    [Description(@"Stamp media.")]
    Stamps = ATMMediaTypeCode.Stamps, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Undetermined medias.
    /// Encoded/decoded by serializers as &quot;UDTM&quot;.
    /// </summary>
    [EnumMember(Value = "UDTM")]
    [IsoId("_KMFzcYqeEeS4a4abTJTSSw")]
    [Description(@"Undetermined medias.")]
    Undetermined = ATMMediaTypeCode.Undetermined, // same ordinal as derivation source for type conversions
}
