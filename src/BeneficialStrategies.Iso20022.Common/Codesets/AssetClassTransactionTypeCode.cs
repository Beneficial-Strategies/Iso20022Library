// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code list of transaction type as specified by the trading venue.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yNs5MNDREeSv_Pll20DdbA")]
[Description(@"Code list of transaction type as specified by the trading venue.")]
[Derivations(typeof(AssetClassTransactionType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassTransactionTypeCode>))]
#endif
public enum AssetClassTransactionTypeCode
{
    /// <summary>
    /// Futures.
    /// Encoded/decoded by serializers as &quot;FUTR&quot;.
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("_r5UUkNDSEeSv_Pll20DdbA")]
    [Description(@"Futures.")]
    Futures,

    /// <summary>
    /// Options.
    /// Encoded/decoded by serializers as &quot;OPTN&quot;.
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("_sN_kENDSEeSv_Pll20DdbA")]
    [Description(@"Options.|")]
    Options,

    /// <summary>
    /// TAPOS.
    /// Encoded/decoded by serializers as &quot;TAPO&quot;.
    /// </summary>
    [EnumMember(Value = "TAPO")]
    [IsoId("_sPoi0NDSEeSv_Pll20DdbA")]
    [Description(@"TAPOS.")]
    TAPOS,

    /// <summary>
    /// Swaps.
    /// Encoded/decoded by serializers as &quot;SWAP&quot;.
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_sRargNDSEeSv_Pll20DdbA")]
    [Description(@"Swaps.")]
    Swaps,

    /// <summary>
    /// Minis.
    /// Encoded/decoded by serializers as &quot;MINI&quot;.
    /// </summary>
    [EnumMember(Value = "MINI")]
    [IsoId("_sS55QNDSEeSv_Pll20DdbA")]
    [Description(@"Minis.")]
    Minis,

    /// <summary>
    /// Over-The-Counter.
    /// Encoded/decoded by serializers as &quot;OTCT&quot;.
    /// </summary>
    [EnumMember(Value = "OTCT")]
    [IsoId("_sUiQ8NDSEeSv_Pll20DdbA")]
    [Description(@"Over-The-Counter.")]
    OTC,

    /// <summary>
    /// Outright.
    /// Encoded/decoded by serializers as &quot;ORIT&quot;.
    /// </summary>
    [EnumMember(Value = "ORIT")]
    [IsoId("_DBDFINDTEeSv_Pll20DdbA")]
    [Description(@"Outright.")]
    Outright,

    /// <summary>
    /// Crack.
    /// Encoded/decoded by serializers as &quot;CRCK&quot;.
    /// </summary>
    [EnumMember(Value = "CRCK")]
    [IsoId("_Kn13YNDTEeSv_Pll20DdbA")]
    [Description(@"Crack.")]
    Crack,

    /// <summary>
    /// Differential.
    /// Encoded/decoded by serializers as &quot;DIFF&quot;.
    /// </summary>
    [EnumMember(Value = "DIFF")]
    [IsoId("_Lz_hcNDTEeSv_Pll20DdbA")]
    [Description(@"Differential.")]
    Differential,

    /// <summary>
    /// Other.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Kt5UoFCOEeWchIYf-qgDzg")]
    [Description(@"Other.")]
    Other,
}
