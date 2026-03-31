// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of repurchase transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8xAOMd0dEd-Cb-IGbQ4hBQ")]
[Description(@"Specifies the type of repurchase transaction.")]
[DerivedFrom(typeof(RepurchaseTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RepurchaseType6Code>))]
#endif
public enum RepurchaseType6Code
{
    /// <summary>
    /// Relates to a Swap/Substitution.
    /// Encoded/decoded by serializers as &quot;CADJ&quot;.
    /// </summary>
    [EnumMember(Value = "CADJ")]
    [IsoId("_q5t_JWtdEeCY4-KZ9JEyUQ_1110886064")]
    [Description(@"Relates to a Swap/Substitution.")]
    Swap = RepurchaseTypeCode.Swap, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a repo rollover of a position extending the closing or maturity date.
    /// Encoded/decoded by serializers as &quot;TOPU&quot;.
    /// </summary>
    [EnumMember(Value = "TOPU")]
    [IsoId("_q53wIGtdEeCY4-KZ9JEyUQ_-1569933634")]
    [Description(
        @"Relates to a repo rollover of a position extending the closing or maturity date."
    )]
    TopUp = RepurchaseTypeCode.TopUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a repo rollover of a position extending the closing or maturity date.
    /// Encoded/decoded by serializers as &quot;WTHD&quot;.
    /// </summary>
    [EnumMember(Value = "WTHD")]
    [IsoId("_q53wIWtdEeCY4-KZ9JEyUQ_1727961309")]
    [Description(
        @"Relates to a repo rollover of a position extending the closing or maturity date."
    )]
    Withdrawal = RepurchaseTypeCode.Withdrawal, // same ordinal as derivation source for type conversions
}
