// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the trade is a pre-allocation or a post-allocation trade, or whether the trade is unallocated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UrZRYCjoEeK1Sbo8NpBROA")]
[Description(
    @"Specifies whether the trade is a pre-allocation or a post-allocation trade, or whether the trade is unallocated."
)]
[DerivedFrom(typeof(AllocationIndicatorCode))]
public enum AllocationIndicator1Code
{
    /// <summary>
    /// Trade is a post-allocation trade.
    /// Encoded/decoded by serializers as &quot;POST&quot;.
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_kPSY4SjvEeK1Sbo8NpBROA")]
    [Description(@"Trade is a post-allocation trade.")]
    Post_allocation = AllocationIndicatorCode.Post_allocation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade is a pre-allocation trade.
    /// Encoded/decoded by serializers as &quot;PREA&quot;.
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("_kUnk0SjvEeK1Sbo8NpBROA")]
    [Description(@"Trade is a pre-allocation trade.")]
    Pre_allocation = AllocationIndicatorCode.Pre_allocation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade is unallocated.
    /// Encoded/decoded by serializers as &quot;UNAL&quot;.
    /// </summary>
    [EnumMember(Value = "UNAL")]
    [IsoId("_kZ_NASjvEeK1Sbo8NpBROA")]
    [Description(@"Trade is unallocated.")]
    Unallocated = AllocationIndicatorCode.Unallocated, // same ordinal as derivation source for type conversions
}
