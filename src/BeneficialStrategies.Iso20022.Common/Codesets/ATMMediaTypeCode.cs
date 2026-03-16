// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type or category of media inside an ATM cassette.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jtniYIqdEeS4a4abTJTSSw")]
[Description(@"Type or category of media inside an ATM cassette.")]
[Derivations(typeof(ATMMediaType1Code), typeof(ATMMediaType3Code), typeof(ATMMediaType2Code))]
public enum ATMMediaTypeCode
{
    /// <summary>
    /// Card media.
    /// Encoded/decoded by serializers as &quot;CARD&quot;.
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_n4p_cIqdEeS4a4abTJTSSw")]
    [Description(@"Card media.")]
    Cards,

    /// <summary>
    /// Coin media.
    /// Encoded/decoded by serializers as &quot;COIN&quot;.
    /// </summary>
    [EnumMember(Value = "COIN")]
    [IsoId("_sCQ5IIqdEeS4a4abTJTSSw")]
    [Description(@"Coin media.")]
    Coins,

    /// <summary>
    /// Non fixed value of the media, for instance gold, silver.
    /// Encoded/decoded by serializers as &quot;CMDT&quot;.
    /// </summary>
    [EnumMember(Value = "CMDT")]
    [IsoId("_vGNyUIqdEeS4a4abTJTSSw")]
    [Description(@"Non fixed value of the media, for instance gold, silver.")]
    Commodity,

    /// <summary>
    /// Coupon media.
    /// Encoded/decoded by serializers as &quot;CPNS&quot;.
    /// </summary>
    [EnumMember(Value = "CPNS")]
    [IsoId("_x3PvgIqdEeS4a4abTJTSSw")]
    [Description(@"Coupon media.")]
    Coupons,

    /// <summary>
    /// Bank note media.
    /// Encoded/decoded by serializers as &quot;NOTE&quot;.
    /// </summary>
    [EnumMember(Value = "NOTE")]
    [IsoId("_1EcEQIqdEeS4a4abTJTSSw")]
    [Description(@"Bank note media.")]
    Notes,

    /// <summary>
    /// Stamp media.
    /// Encoded/decoded by serializers as &quot;STMP&quot;.
    /// </summary>
    [EnumMember(Value = "STMP")]
    [IsoId("_3K2XIIqdEeS4a4abTJTSSw")]
    [Description(@"Stamp media.")]
    Stamps,

    /// <summary>
    /// Undetermined medias.
    /// Encoded/decoded by serializers as &quot;UDTM&quot;.
    /// </summary>
    [EnumMember(Value = "UDTM")]
    [IsoId("_6X7XIIqdEeS4a4abTJTSSw")]
    [Description(@"Undetermined medias.")]
    Undetermined,

    /// <summary>
    /// Check media.
    /// Encoded/decoded by serializers as &quot;CHCK&quot;.
    /// </summary>
    [EnumMember(Value = "CHCK")]
    [IsoId("_jCUjwK4CEeWL1uap3dNhCQ")]
    [Description(@"Check media.")]
    Check,

    /// <summary>
    /// Detected counterfeit media.
    /// Encoded/decoded by serializers as &quot;CNTR&quot;.
    /// </summary>
    [EnumMember(Value = "CNTR")]
    [IsoId("_Ae4IYK4DEeWL1uap3dNhCQ")]
    [Description(@"Detected counterfeit media.")]
    Counterfeit,

    /// <summary>
    /// Fit media.
    /// Encoded/decoded by serializers as &quot;FITN&quot;.
    /// </summary>
    [EnumMember(Value = "FITN")]
    [IsoId("_C75kcK4DEeWL1uap3dNhCQ")]
    [Description(@"Fit media.")]
    Fit,

    /// <summary>
    /// Fit or unfit media, if fitness cannot be determined.
    /// Encoded/decoded by serializers as &quot;FITU&quot;.
    /// </summary>
    [EnumMember(Value = "FITU")]
    [IsoId("_Fva08K4DEeWL1uap3dNhCQ")]
    [Description(@"Fit or unfit media, if fitness cannot be determined.")]
    FitAndUnfit,

    /// <summary>
    /// Suspect media.
    /// Encoded/decoded by serializers as &quot;SPCT&quot;.
    /// </summary>
    [EnumMember(Value = "SPCT")]
    [IsoId("_IwagwK4DEeWL1uap3dNhCQ")]
    [Description(@"Suspect media.")]
    Suspect,

    /// <summary>
    /// Unfit media (unacceptable quality).
    /// Encoded/decoded by serializers as &quot;UNFT&quot;.
    /// </summary>
    [EnumMember(Value = "UNFT")]
    [IsoId("_LGBGMK4DEeWL1uap3dNhCQ")]
    [Description(@"Unfit media (unacceptable quality).")]
    Unfit,

    /// <summary>
    /// Unrecognised media.
    /// Encoded/decoded by serializers as &quot;UNRG&quot;.
    /// </summary>
    [EnumMember(Value = "UNRG")]
    [IsoId("_PKQ-wK4DEeWL1uap3dNhCQ")]
    [Description(@"Unrecognised media.")]
    Unrecognised,
}
