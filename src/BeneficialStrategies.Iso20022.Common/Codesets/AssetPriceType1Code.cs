// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of price for an asset.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Rjfl8BtFEeWhp-Wous5jzA")]
[Description(@"Specifies the type of price for an asset.")]
[DerivedFrom(typeof(AssetPriceTypeCode))]
public enum AssetPriceType1Code
{
    /// <summary>
    /// Argus / Mc Closkey price.
    /// Encoded/decoded by serializers as &quot;ARGM&quot;.
    /// </summary>
    [EnumMember(Value = "ARGM")]
    [IsoId("_Uio3oRtFEeWhp-Wous5jzA")]
    [Description(@"Argus / Mc Closkey price.")]
    ArgusMcCloskey = AssetPriceTypeCode.ArgusMcCloskey, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Baltic price.
    /// Encoded/decoded by serializers as &quot;BLTC&quot;.
    /// </summary>
    [EnumMember(Value = "BLTC")]
    [IsoId("_UnPq0RtFEeWhp-Wous5jzA")]
    [Description(@"Baltic price.")]
    Baltic = AssetPriceTypeCode.Baltic, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exchange price.
    /// Encoded/decoded by serializers as &quot;EXOF&quot;.
    /// </summary>
    [EnumMember(Value = "EXOF")]
    [IsoId("_UsAPARtFEeWhp-Wous5jzA")]
    [Description(@"Exchange price.")]
    Exchange = AssetPriceTypeCode.Exchange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Global coal price.
    /// Encoded/decoded by serializers as &quot;GBCL&quot;.
    /// </summary>
    [EnumMember(Value = "GBCL")]
    [IsoId("_UwnpQRtFEeWhp-Wous5jzA")]
    [Description(@"Global coal price.")]
    GlobalCoal = AssetPriceTypeCode.GlobalCoal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// IHS Mc Closkey price.
    /// Encoded/decoded by serializers as &quot;IHSM&quot;.
    /// </summary>
    [EnumMember(Value = "IHSM")]
    [IsoId("_U1YNcRtFEeWhp-Wous5jzA")]
    [Description(@"IHS Mc Closkey price.")]
    IHSMcCloskey = AssetPriceTypeCode.IHSMcCloskey, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other price.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_U9tqERtFEeWhp-Wous5jzA")]
    [Description(@"Other price.")]
    Other = AssetPriceTypeCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Platts price.
    /// Encoded/decoded by serializers as &quot;PLAT&quot;.
    /// </summary>
    [EnumMember(Value = "PLAT")]
    [IsoId("_VFS4wRtFEeWhp-Wous5jzA")]
    [Description(@"Platts price.")]
    Platts = AssetPriceTypeCode.Platts, // same ordinal as derivation source for type conversions
    
}
