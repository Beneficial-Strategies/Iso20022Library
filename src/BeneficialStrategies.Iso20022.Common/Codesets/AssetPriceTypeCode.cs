// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of price for an asset.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EnANEBsTEeWhp-Wous5jzA")]
[Description(@"Specifies the type of price for an asset.")]
[Derivations(typeof(AssetPriceType1Code))]
public enum AssetPriceTypeCode
{
    /// <summary>
    /// Argus / Mc Closkey price.
    /// Encoded/decoded by serializers as &quot;ARGM&quot;.
    /// </summary>
    [EnumMember(Value = "ARGM")]
    [IsoId("_N3C1EBsTEeWhp-Wous5jzA")]
    [Description(@"Argus / Mc Closkey price.")]
    ArgusMcCloskey,

    /// <summary>
    /// Baltic price.
    /// Encoded/decoded by serializers as &quot;BLTC&quot;.
    /// </summary>
    [EnumMember(Value = "BLTC")]
    [IsoId("_N-VI0BsTEeWhp-Wous5jzA")]
    [Description(@"Baltic price.")]
    Baltic,

    /// <summary>
    /// Exchange price.
    /// Encoded/decoded by serializers as &quot;EXOF&quot;.
    /// </summary>
    [EnumMember(Value = "EXOF")]
    [IsoId("_OARCgBsTEeWhp-Wous5jzA")]
    [Description(@"Exchange price.")]
    Exchange,

    /// <summary>
    /// Global coal price.
    /// Encoded/decoded by serializers as &quot;GBCL&quot;.
    /// </summary>
    [EnumMember(Value = "GBCL")]
    [IsoId("_OCDLMBsTEeWhp-Wous5jzA")]
    [Description(@"Global coal price.")]
    GlobalCoal,

    /// <summary>
    /// IHS Mc Closkey price.
    /// Encoded/decoded by serializers as &quot;IHSM&quot;.
    /// </summary>
    [EnumMember(Value = "IHSM")]
    [IsoId("_OD_E4BsTEeWhp-Wous5jzA")]
    [Description(@"IHS Mc Closkey price.")]
    IHSMcCloskey,

    /// <summary>
    /// Platts price.
    /// Encoded/decoded by serializers as &quot;PLAT&quot;.
    /// </summary>
    [EnumMember(Value = "PLAT")]
    [IsoId("_OFnckBsTEeWhp-Wous5jzA")]
    [Description(@"Platts price.")]
    Platts,

    /// <summary>
    /// Other price.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_OHjWQBsTEeWhp-Wous5jzA")]
    [Description(@"Other price.")]
    Other,
}
