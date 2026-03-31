// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Qualifies the amount associated with the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_f6oSka11EeawR4FMacHsRQ")]
[Description(@"Qualifies the amount associated with the transaction.")]
[DerivedFrom(typeof(TypeOfAmountCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TypeOfAmount8Code>))]
#endif
public enum TypeOfAmount8Code
{
    /// <summary>
    /// Actual amount.
    /// Encoded/decoded by serializers as &quot;ACTL&quot;.
    /// </summary>
    [EnumMember(Value = "ACTL")]
    [IsoId("_gKHgEa11EeawR4FMacHsRQ")]
    [Description(@"Actual amount.")]
    Actual = TypeOfAmountCode.Actual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Estimated amount (the final amount could be above or below).
    /// Encoded/decoded by serializers as &quot;ESTM&quot;.
    /// </summary>
    [EnumMember(Value = "ESTM")]
    [IsoId("_gKHgE611EeawR4FMacHsRQ")]
    [Description(@"Estimated amount (the final amount could be above or below).")]
    Estimated = TypeOfAmountCode.Estimated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Maximum amount (the final amount must be less or equal).
    /// Encoded/decoded by serializers as &quot;MAXI&quot;.
    /// </summary>
    [EnumMember(Value = "MAXI")]
    [IsoId("_gKHgFa11EeawR4FMacHsRQ")]
    [Description(@"Maximum amount (the final amount must be less or equal).")]
    Maximum = TypeOfAmountCode.Maximum, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Default amount.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_gKHgF611EeawR4FMacHsRQ")]
    [Description(@"Default amount.")]
    Default = TypeOfAmountCode.Default, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Replacement amount.
    /// Encoded/decoded by serializers as &quot;RPLT&quot;.
    /// </summary>
    [EnumMember(Value = "RPLT")]
    [IsoId("_gKHgGa11EeawR4FMacHsRQ")]
    [Description(@"Replacement amount.")]
    Replacement = TypeOfAmountCode.Replacement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Incremental amount for reservation.
    /// Encoded/decoded by serializers as &quot;INCR&quot;.
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("_ldQNoa11EeawR4FMacHsRQ")]
    [Description(@"Incremental amount for reservation.")]
    Incremental = TypeOfAmountCode.Incremental, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Decremental amount for reservation.
    /// Encoded/decoded by serializers as &quot;DECR&quot;.
    /// </summary>
    [EnumMember(Value = "DECR")]
    [IsoId("_mJlvMa11EeawR4FMacHsRQ")]
    [Description(@"Decremental amount for reservation.")]
    Decremental = TypeOfAmountCode.Decremental, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reserved or updated reserved amount for reservation.
    /// Encoded/decoded by serializers as &quot;RESD&quot;.
    /// </summary>
    [EnumMember(Value = "RESD")]
    [IsoId("_m246Ea11EeawR4FMacHsRQ")]
    [Description(@"Reserved or updated reserved amount for reservation.")]
    Reserved = TypeOfAmountCode.Reserved, // same ordinal as derivation source for type conversions
}
