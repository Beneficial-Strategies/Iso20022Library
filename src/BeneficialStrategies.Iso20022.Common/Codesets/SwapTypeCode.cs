// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of an interest rate derivative when the contract type is a swap, a swaption, a future on a swap and / or a forward on a swap.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_i7J28CSpEeWsI5Sp3-B3zg")]
[Description(
    @"Specifies the type of an interest rate derivative when the contract type is a swap, a swaption, a future on a swap and / or a forward on a swap."
)]
[Derivations(typeof(SwapType1Code))]
public enum SwapTypeCode
{
    /// <summary>
    /// Float to Float Multi Currency Swap.
    /// Encoded/decoded by serializers as &quot;FFMC&quot;.
    /// </summary>
    [EnumMember(Value = "FFMC")]
    [IsoId("_lG-OQCSpEeWsI5Sp3-B3zg")]
    [Description(@"Float to Float Multi Currency Swap.")]
    FloatToFloatMultiCurrencySwap,

    /// <summary>
    /// Inflation Multi Currency Swap.
    /// Encoded/decoded by serializers as &quot;IFMC&quot;.
    /// </summary>
    [EnumMember(Value = "IFMC")]
    [IsoId("_ssZukSSpEeWsI5Sp3-B3zg")]
    [Description(@"Inflation Multi Currency Swap.")]
    InflationMultiCurrencySwap,

    /// <summary>
    /// Float to Float Single Currency Swap.
    /// Encoded/decoded by serializers as &quot;FFSC&quot;.
    /// </summary>
    [EnumMember(Value = "FFSC")]
    [IsoId("_w4rhwSSpEeWsI5Sp3-B3zg")]
    [Description(@"Float to Float Single Currency Swap.")]
    FloatToFloatSingleCurrencySwap,

    /// <summary>
    /// Fixed to Fixed Single Currency Swap.
    /// Encoded/decoded by serializers as &quot;XXSC&quot;.
    /// </summary>
    [EnumMember(Value = "XXSC")]
    [IsoId("_0g6MsSSpEeWsI5Sp3-B3zg")]
    [Description(@"Fixed to Fixed Single Currency Swap.")]
    FixedToFixedSingleCurrencySwap,

    /// <summary>
    /// Overnight Index Multi Currency Swap.
    /// Encoded/decoded by serializers as &quot;OSMC&quot;.
    /// </summary>
    [EnumMember(Value = "OSMC")]
    [IsoId("_CDckoiSqEeWsI5Sp3-B3zg")]
    [Description(@"Overnight Index Multi Currency Swap.")]
    OvernightIndexMultiCurrencySwap,

    /// <summary>
    /// Overnight Index Single Currency Swap.
    /// Encoded/decoded by serializers as &quot;OSSC&quot;.
    /// </summary>
    [EnumMember(Value = "OSSC")]
    [IsoId("_CDckoySqEeWsI5Sp3-B3zg")]
    [Description(@"Overnight Index Single Currency Swap.")]
    OvernightIndexSingleCurrencySwap,

    /// <summary>
    /// Fixed to Float Multi Currency Swap.
    /// Encoded/decoded by serializers as &quot;XFMC&quot;.
    /// </summary>
    [EnumMember(Value = "XFMC")]
    [IsoId("_N-NtgiSqEeWsI5Sp3-B3zg")]
    [Description(@"Fixed to Float Multi Currency Swap.")]
    FixedToFloatMultiCurrencySwap,

    /// <summary>
    /// Fixed to Float Single Currency Swap.
    /// Encoded/decoded by serializers as &quot;XFSC&quot;.
    /// </summary>
    [EnumMember(Value = "XFSC")]
    [IsoId("_N-NtgySqEeWsI5Sp3-B3zg")]
    [Description(@"Fixed to Float Single Currency Swap.")]
    FixedToFloatSingleCurrencySwap,

    /// <summary>
    /// Fixed to Fixed Multi Currency Swap.
    /// Encoded/decoded by serializers as &quot;XXMC&quot;.
    /// </summary>
    [EnumMember(Value = "XXMC")]
    [IsoId("_OtCiYiSqEeWsI5Sp3-B3zg")]
    [Description(@"Fixed to Fixed Multi Currency Swap.")]
    FixedToFixedMultiCurrencySwap,

    /// <summary>
    /// Inflation Single Currency Swap.
    /// Encoded/decoded by serializers as &quot;IFSC&quot;.
    /// </summary>
    [EnumMember(Value = "IFSC")]
    [IsoId("_OtCiYySqEeWsI5Sp3-B3zg")]
    [Description(@"Inflation Single Currency Swap.")]
    InflationSingleCurrencySwap,

    /// <summary>
    /// Fixed to Face Value
    /// Encoded/decoded by serializers as &quot;FTFV&quot;.
    /// </summary>
    [EnumMember(Value = "FTFV")]
    [IsoId("_82X2wNW3EeyVKLlq2-NhyA")]
    [Description(@"Fixed to Face Value")]
    FixedToFaceValue,
}
