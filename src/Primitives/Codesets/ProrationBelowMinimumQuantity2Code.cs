// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of proration when below the minimum quantity to instruct.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CkKE4Kj5EfCG_LQaXOxwew")]
[Description(@"Specifies the type of proration when below the minimum quantity to instruct.")]
[DerivedFrom(typeof(ProrationBelowMinimumQuantityCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ProrationBelowMinimumQuantity2Code>))]
public enum ProrationBelowMinimumQuantity2Code
{
    /// <summary>
    /// Instructions will be accepted in full (with their original quantity of securities).
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_KyqXYaj5EfCG_LQaXOxwew")]
    [Description(@"Instructions will be accepted in full (with their original quantity of securities).")]
    AcceptedInFull = ProrationBelowMinimumQuantityCode.AcceptedInFull, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instructions will be accepted but prorated to the minimum quantity to instruct.
    /// Encoded/decoded by serializers as &quot;MIEX&quot;.
    /// </summary>
    [EnumMember(Value = "MIEX")]
    [IsoId("_K1fo8aj5EfCG_LQaXOxwew")]
    [Description(@"Instructions will be accepted but prorated to the minimum quantity to instruct.")]
    MinimumQuantity = ProrationBelowMinimumQuantityCode.MinimumQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instructions will be accepted but rounded down to the nearest minimum multiple quantity.
    /// Encoded/decoded by serializers as &quot;MILD&quot;.
    /// </summary>
    [EnumMember(Value = "MILD")]
    [IsoId("_LAGWcaj5EfCG_LQaXOxwew")]
    [Description(@"Instructions will be accepted but rounded down to the nearest minimum multiple quantity.")]
    RoundDown = ProrationBelowMinimumQuantityCode.RoundDown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instructions will be accepted but rounded up to the nearest minimum multiple quantity.
    /// Encoded/decoded by serializers as &quot;MILU&quot;.
    /// </summary>
    [EnumMember(Value = "MILU")]
    [IsoId("_LCcf0aj5EfCG_LQaXOxwew")]
    [Description(@"Instructions will be accepted but rounded up to the nearest minimum multiple quantity.")]
    RoundUp = ProrationBelowMinimumQuantityCode.RoundUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instructions will be rejected.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_K9BNQaj5EfCG_LQaXOxwew")]
    [Description(@"Instructions will be rejected.")]
    Rejected = ProrationBelowMinimumQuantityCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Processing of instructions prorated below the minimum quantity to instruct is unknown.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_LFoWsaj5EfCG_LQaXOxwew")]
    [Description(@"Processing of instructions prorated below the minimum quantity to instruct is unknown.")]
    Unknown = ProrationBelowMinimumQuantityCode.Unknown, // same ordinal as derivation source for type conversions
}
