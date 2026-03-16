// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type or class of amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7MFYEFFFEeyhmN3K0lwfug")]
[Description(@"Type or class of amount.")]
[DerivedFrom(typeof(TypeOfAmountCode))]
public enum TypeOfAmount22Code
{
    /// <summary>
    /// Actual amount.
    /// Encoded/decoded by serializers as &quot;ACTL&quot;.
    /// </summary>
    [EnumMember(Value = "ACTL")]
    [IsoId("_-9S_4VFFEeyhmN3K0lwfug")]
    [Description(@"Actual amount.")]
    Actual = TypeOfAmountCode.Actual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Default amount.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("__unIEVFFEeyhmN3K0lwfug")]
    [Description(@"Default amount.")]
    Default = TypeOfAmountCode.Default, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deposit amount.
    /// Encoded/decoded by serializers as &quot;DPST&quot;.
    /// </summary>
    [EnumMember(Value = "DPST")]
    [IsoId("_ARnHcVFGEeyhmN3K0lwfug")]
    [Description(@"Deposit amount.")]
    Deposit = TypeOfAmountCode.Deposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Estimated amount (the final amount could be above or below).
    /// Encoded/decoded by serializers as &quot;ESTM&quot;.
    /// </summary>
    [EnumMember(Value = "ESTM")]
    [IsoId("_Al1rAVFGEeyhmN3K0lwfug")]
    [Description(@"Estimated amount (the final amount could be above or below).")]
    Estimated = TypeOfAmountCode.Estimated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Maximum amount (the final amount must be less or equal).
    /// Encoded/decoded by serializers as &quot;MAXI&quot;.
    /// </summary>
    [EnumMember(Value = "MAXI")]
    [IsoId("_BQzTkVFGEeyhmN3K0lwfug")]
    [Description(@"Maximum amount (the final amount must be less or equal).")]
    Maximum = TypeOfAmountCode.Maximum, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Substitute for an amount to be authorised.
    /// Encoded/decoded by serializers as &quot;PRXY&quot;.
    /// </summary>
    [EnumMember(Value = "PRXY")]
    [IsoId("_CP_fsVFGEeyhmN3K0lwfug")]
    [Description(@"Substitute for an amount to be authorised.")]
    Proxy = TypeOfAmountCode.Proxy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reserved or updated reserved amount for reservation.
    /// Encoded/decoded by serializers as &quot;RESD&quot;.
    /// </summary>
    [EnumMember(Value = "RESD")]
    [IsoId("_DV9CMVFGEeyhmN3K0lwfug")]
    [Description(@"Reserved or updated reserved amount for reservation.")]
    Reserved = TypeOfAmountCode.Reserved, // same ordinal as derivation source for type conversions
}
