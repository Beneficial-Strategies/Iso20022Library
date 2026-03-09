// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code list of transaction type as specified by the trading venue.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Sv15QNDTEeSv_Pll20DdbA")]
[Description(@"Code list of transaction type as specified by the trading venue.")]
[DerivedFrom(typeof(AssetClassTransactionTypeCode))]
public enum AssetClassTransactionType1Code
{
    /// <summary>
    /// Crack.
    /// Encoded/decoded by serializers as &quot;CRCK&quot;.
    /// </summary>
    [EnumMember(Value = "CRCK")]
    [IsoId("_T3s5MdDTEeSv_Pll20DdbA")]
    [Description(@"Crack.")]
    Crack = AssetClassTransactionTypeCode.Crack, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Differential.
    /// Encoded/decoded by serializers as &quot;DIFF&quot;.
    /// </summary>
    [EnumMember(Value = "DIFF")]
    [IsoId("_T-YwAdDTEeSv_Pll20DdbA")]
    [Description(@"Differential.")]
    Differential = AssetClassTransactionTypeCode.Differential, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Futures.
    /// Encoded/decoded by serializers as &quot;FUTR&quot;.
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("_UHUCgdDTEeSv_Pll20DdbA")]
    [Description(@"Futures.")]
    Futures = AssetClassTransactionTypeCode.Futures, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Minis.
    /// Encoded/decoded by serializers as &quot;MINI&quot;.
    /// </summary>
    [EnumMember(Value = "MINI")]
    [IsoId("_UPMzMdDTEeSv_Pll20DdbA")]
    [Description(@"Minis.")]
    Minis = AssetClassTransactionTypeCode.Minis, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Options.
    /// Encoded/decoded by serializers as &quot;OPTN&quot;.
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("_UWMMAdDTEeSv_Pll20DdbA")]
    [Description(@"Options.|")]
    Options = AssetClassTransactionTypeCode.Options, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Over-The-Counter.
    /// Encoded/decoded by serializers as &quot;OTCT&quot;.
    /// </summary>
    [EnumMember(Value = "OTCT")]
    [IsoId("_UcS0AdDTEeSv_Pll20DdbA")]
    [Description(@"Over-The-Counter.")]
    OTC = AssetClassTransactionTypeCode.OTC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Outright.
    /// Encoded/decoded by serializers as &quot;ORIT&quot;.
    /// </summary>
    [EnumMember(Value = "ORIT")]
    [IsoId("_UiF6AdDTEeSv_Pll20DdbA")]
    [Description(@"Outright.")]
    Outright = AssetClassTransactionTypeCode.Outright, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Swaps.
    /// Encoded/decoded by serializers as &quot;SWAP&quot;.
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_Uo8I4dDTEeSv_Pll20DdbA")]
    [Description(@"Swaps.")]
    Swaps = AssetClassTransactionTypeCode.Swaps, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// TAPOS.
    /// Encoded/decoded by serializers as &quot;TAPO&quot;.
    /// </summary>
    [EnumMember(Value = "TAPO")]
    [IsoId("_UwYNodDTEeSv_Pll20DdbA")]
    [Description(@"TAPOS.")]
    TAPOS = AssetClassTransactionTypeCode.TAPOS, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_RVvyYVCOEeWchIYf-qgDzg")]
    [Description(@"Other.")]
    Other = AssetClassTransactionTypeCode.Other, // same ordinal as derivation source for type conversions
    
}
