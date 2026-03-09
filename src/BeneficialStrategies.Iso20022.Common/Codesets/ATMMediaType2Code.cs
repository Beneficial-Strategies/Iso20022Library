// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of media inside an ATM cassette.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_prJ48a4CEeWL1uap3dNhCQ")]
[Description(@"Type of media inside an ATM cassette.")]
[DerivedFrom(typeof(ATMMediaTypeCode))]
public enum ATMMediaType2Code
{
    /// <summary>
    /// Card media.
    /// Encoded/decoded by serializers as &quot;CARD&quot;.
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_p3YXEa4CEeWL1uap3dNhCQ")]
    [Description(@"Card media.")]
    Cards = ATMMediaTypeCode.Cards, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Coin media.
    /// Encoded/decoded by serializers as &quot;COIN&quot;.
    /// </summary>
    [EnumMember(Value = "COIN")]
    [IsoId("_p3YXE64CEeWL1uap3dNhCQ")]
    [Description(@"Coin media.")]
    Coins = ATMMediaTypeCode.Coins, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Non fixed value of the media, for instance gold, silver.
    /// Encoded/decoded by serializers as &quot;CMDT&quot;.
    /// </summary>
    [EnumMember(Value = "CMDT")]
    [IsoId("_p3YXFa4CEeWL1uap3dNhCQ")]
    [Description(@"Non fixed value of the media, for instance gold, silver.")]
    Commodity = ATMMediaTypeCode.Commodity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Coupon media.
    /// Encoded/decoded by serializers as &quot;CPNS&quot;.
    /// </summary>
    [EnumMember(Value = "CPNS")]
    [IsoId("_p3YXF64CEeWL1uap3dNhCQ")]
    [Description(@"Coupon media.")]
    Coupons = ATMMediaTypeCode.Coupons, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank note media.
    /// Encoded/decoded by serializers as &quot;NOTE&quot;.
    /// </summary>
    [EnumMember(Value = "NOTE")]
    [IsoId("_p3YXGa4CEeWL1uap3dNhCQ")]
    [Description(@"Bank note media.")]
    Notes = ATMMediaTypeCode.Notes, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Stamp media.
    /// Encoded/decoded by serializers as &quot;STMP&quot;.
    /// </summary>
    [EnumMember(Value = "STMP")]
    [IsoId("_p3YXG64CEeWL1uap3dNhCQ")]
    [Description(@"Stamp media.")]
    Stamps = ATMMediaTypeCode.Stamps, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Undetermined medias.
    /// Encoded/decoded by serializers as &quot;UDTM&quot;.
    /// </summary>
    [EnumMember(Value = "UDTM")]
    [IsoId("_p3YXHa4CEeWL1uap3dNhCQ")]
    [Description(@"Undetermined medias.")]
    Undetermined = ATMMediaTypeCode.Undetermined, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Check media.
    /// Encoded/decoded by serializers as &quot;CHCK&quot;.
    /// </summary>
    [EnumMember(Value = "CHCK")]
    [IsoId("_thyzUa4CEeWL1uap3dNhCQ")]
    [Description(@"Check media.")]
    Check = ATMMediaTypeCode.Check, // same ordinal as derivation source for type conversions
    
}
