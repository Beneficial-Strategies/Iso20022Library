// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of an interest rate derivative when the contract type is a swap, a swaption, a future on a swap and / or a forward on a swap.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_h8h1ECS1EeWsI5Sp3-B3zg")]
[Description(
    @"Specifies the type of an interest rate derivative when the contract type is a swap, a swaption, a future on a swap and / or a forward on a swap."
)]
[DerivedFrom(typeof(SwapTypeCode))]
public enum SwapType1Code
{
    /// <summary>
    /// Overnight Index Single Currency Swap.
    /// Encoded/decoded by serializers as &quot;OSSC&quot;.
    /// </summary>
    [EnumMember(Value = "OSSC")]
    [IsoId("_jZap0SS1EeWsI5Sp3-B3zg")]
    [Description(@"Overnight Index Single Currency Swap.")]
    OvernightIndexSingleCurrencySwap = SwapTypeCode.OvernightIndexSingleCurrencySwap, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fixed to Float Single Currency Swap.
    /// Encoded/decoded by serializers as &quot;XFSC&quot;.
    /// </summary>
    [EnumMember(Value = "XFSC")]
    [IsoId("_j4gZkSS1EeWsI5Sp3-B3zg")]
    [Description(@"Fixed to Float Single Currency Swap.")]
    FixedToFloatSingleCurrencySwap = SwapTypeCode.FixedToFloatSingleCurrencySwap, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fixed to Float Multi Currency Swap.
    /// Encoded/decoded by serializers as &quot;XFMC&quot;.
    /// </summary>
    [EnumMember(Value = "XFMC")]
    [IsoId("_j-IgcSS1EeWsI5Sp3-B3zg")]
    [Description(@"Fixed to Float Multi Currency Swap.")]
    FixedToFloatMultiCurrencySwap = SwapTypeCode.FixedToFloatMultiCurrencySwap, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fixed to Fixed Single Currency Swap.
    /// Encoded/decoded by serializers as &quot;XXSC&quot;.
    /// </summary>
    [EnumMember(Value = "XXSC")]
    [IsoId("_kC_yUSS1EeWsI5Sp3-B3zg")]
    [Description(@"Fixed to Fixed Single Currency Swap.")]
    FixedToFixedSingleCurrencySwap = SwapTypeCode.FixedToFixedSingleCurrencySwap, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fixed to Fixed Multi Currency Swap.
    /// Encoded/decoded by serializers as &quot;XXMC&quot;.
    /// </summary>
    [EnumMember(Value = "XXMC")]
    [IsoId("_kSQWUSS1EeWsI5Sp3-B3zg")]
    [Description(@"Fixed to Fixed Multi Currency Swap.")]
    FixedToFixedMultiCurrencySwap = SwapTypeCode.FixedToFixedMultiCurrencySwap, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Inflation Multi Currency Swap.
    /// Encoded/decoded by serializers as &quot;IFMC&quot;.
    /// </summary>
    [EnumMember(Value = "IFMC")]
    [IsoId("_k1EIcSS1EeWsI5Sp3-B3zg")]
    [Description(@"Inflation Multi Currency Swap.")]
    InflationMultiCurrencySwap = SwapTypeCode.InflationMultiCurrencySwap, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Float to Float Single Currency Swap.
    /// Encoded/decoded by serializers as &quot;FFSC&quot;.
    /// </summary>
    [EnumMember(Value = "FFSC")]
    [IsoId("_lOVkESS1EeWsI5Sp3-B3zg")]
    [Description(@"Float to Float Single Currency Swap.")]
    FloatToFloatSingleCurrencySwap = SwapTypeCode.FloatToFloatSingleCurrencySwap, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Float to Float Multi Currency Swap.
    /// Encoded/decoded by serializers as &quot;FFMC&quot;.
    /// </summary>
    [EnumMember(Value = "FFMC")]
    [IsoId("_lTAosSS1EeWsI5Sp3-B3zg")]
    [Description(@"Float to Float Multi Currency Swap.")]
    FloatToFloatMultiCurrencySwap = SwapTypeCode.FloatToFloatMultiCurrencySwap, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Inflation Single Currency Swap.
    /// Encoded/decoded by serializers as &quot;IFSC&quot;.
    /// </summary>
    [EnumMember(Value = "IFSC")]
    [IsoId("_l9cs0SS1EeWsI5Sp3-B3zg")]
    [Description(@"Inflation Single Currency Swap.")]
    InflationSingleCurrencySwap = SwapTypeCode.InflationSingleCurrencySwap, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Overnight Index Multi Currency Swap.
    /// Encoded/decoded by serializers as &quot;OSMC&quot;.
    /// </summary>
    [EnumMember(Value = "OSMC")]
    [IsoId("_mCT-sSS1EeWsI5Sp3-B3zg")]
    [Description(@"Overnight Index Multi Currency Swap.")]
    OvernightIndexMultiCurrencySwap = SwapTypeCode.OvernightIndexMultiCurrencySwap, // same ordinal as derivation source for type conversions
}
