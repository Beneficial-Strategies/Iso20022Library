// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of media inside an ATM cassette.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ATMMediaType4Code")]
[Description(@"Type of media inside an ATM cassette.")]
[DerivedFrom(typeof(ATMMediaTypeCode))]
public enum ATMMediaType4Code
{
    /// <summary>
    /// Card media.
    /// Encoded/decoded by serializers as &quot;CARD&quot;.
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_ATMMediaType4Code_Cards")]
    [Description(@"Card media.")]
    Cards = ATMMediaTypeCode.Cards,

    /// <summary>
    /// Check media.
    /// Encoded/decoded by serializers as &quot;CHCK&quot;.
    /// </summary>
    [EnumMember(Value = "CHCK")]
    [IsoId("_ATMMediaType4Code_Check")]
    [Description(@"Check media.")]
    Check = ATMMediaTypeCode.Check,

    /// <summary>
    /// Non fixed value of the media, for instance gold, silver.
    /// Encoded/decoded by serializers as &quot;CMDT&quot;.
    /// </summary>
    [EnumMember(Value = "CMDT")]
    [IsoId("_ATMMediaType4Code_Commodity")]
    [Description(@"Non fixed value of the media, for instance gold, silver.")]
    Commodity = ATMMediaTypeCode.Commodity,

    /// <summary>
    /// Coin media.
    /// Encoded/decoded by serializers as &quot;COIN&quot;.
    /// </summary>
    [EnumMember(Value = "COIN")]
    [IsoId("_ATMMediaType4Code_Coins")]
    [Description(@"Coin media.")]
    Coins = ATMMediaTypeCode.Coins,

    /// <summary>
    /// Coupon media.
    /// Encoded/decoded by serializers as &quot;CPNS&quot;.
    /// </summary>
    [EnumMember(Value = "CPNS")]
    [IsoId("_ATMMediaType4Code_Coupons")]
    [Description(@"Coupon media.")]
    Coupons = ATMMediaTypeCode.Coupons,

    /// <summary>
    /// One envelope containing unknown amounts of unknown items.
    /// Encoded/decoded by serializers as &quot;ENVP&quot;.
    /// </summary>
    [EnumMember(Value = "ENVP")]
    [IsoId("_ATMMediaType4Code_Envelope")]
    [Description(@"One envelope containing unknown amounts of unknown items.")]
    Envelope,

    /// <summary>
    /// Multiple items either outside of envelope or in multiple envelopes.
    /// Encoded/decoded by serializers as &quot;MLTP&quot;.
    /// </summary>
    [EnumMember(Value = "MLTP")]
    [IsoId("_ATMMediaType4Code_Multiple")]
    [Description(@"Multiple items either outside of envelope or in multiple envelopes.")]
    Multiple,

    /// <summary>
    /// Bank note media.
    /// Encoded/decoded by serializers as &quot;NOTE&quot;.
    /// </summary>
    [EnumMember(Value = "NOTE")]
    [IsoId("_ATMMediaType4Code_Notes")]
    [Description(@"Bank note media.")]
    Notes = ATMMediaTypeCode.Notes,

    /// <summary>
    /// Stamp media.
    /// Encoded/decoded by serializers as &quot;STMP&quot;.
    /// </summary>
    [EnumMember(Value = "STMP")]
    [IsoId("_ATMMediaType4Code_Stamps")]
    [Description(@"Stamp media.")]
    Stamps = ATMMediaTypeCode.Stamps,

    /// <summary>
    /// Undetermined medias.
    /// Encoded/decoded by serializers as &quot;UDTM&quot;.
    /// </summary>
    [EnumMember(Value = "UDTM")]
    [IsoId("_ATMMediaType4Code_Undetermined")]
    [Description(@"Undetermined medias.")]
    Undetermined = ATMMediaTypeCode.Undetermined,

}
