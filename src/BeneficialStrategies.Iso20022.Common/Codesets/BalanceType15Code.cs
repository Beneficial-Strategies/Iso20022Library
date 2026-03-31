// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_r56MocSqEeuBjv5G5kw00g")]
[Description(@"Type of balance.")]
[DerivedFrom(typeof(BalanceTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<BalanceType15Code>))]
#endif
public enum BalanceType15Code
{
    /// <summary>
    /// Amount put on hold.
    /// Encoded/decoded by serializers as &quot;AMOH&quot;.
    /// </summary>
    [EnumMember(Value = "AMOH")]
    [IsoId("_r_HcwcSqEeuBjv5G5kw00g")]
    [Description(@"Amount put on hold.")]
    AmountOnHold = BalanceTypeCode.AmountOnHold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of money owed
    /// Encoded/decoded by serializers as &quot;AMTO&quot;.
    /// </summary>
    [EnumMember(Value = "AMTO")]
    [IsoId("_r_Hcw8SqEeuBjv5G5kw00g")]
    [Description(@"Amount of money owed")]
    AmountOwing = BalanceTypeCode.AmountOwing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of money due.
    /// Encoded/decoded by serializers as &quot;AMTD&quot;.
    /// </summary>
    [EnumMember(Value = "AMTD")]
    [IsoId("_r_HcxcSqEeuBjv5G5kw00g")]
    [Description(@"Amount of money due.")]
    AmountDue = BalanceTypeCode.AmountDue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Credit line available.
    /// Encoded/decoded by serializers as &quot;CRDL&quot;.
    /// </summary>
    [EnumMember(Value = "CRDL")]
    [IsoId("_r_Hcx8SqEeuBjv5G5kw00g")]
    [Description(@"Credit line available.")]
    CreditLine = BalanceTypeCode.CreditLine, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of balance defined at national level
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_r_HcycSqEeuBjv5G5kw00g")]
    [Description(@"Other type of balance defined at national level")]
    OtherNational = BalanceTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of balance defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_r_ID0cSqEeuBjv5G5kw00g")]
    [Description(@"Other type of balance defined at private level.")]
    OtherPrivate = BalanceTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of money or securities that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;AVLB&quot;.
    /// </summary>
    [EnumMember(Value = "AVLB")]
    [IsoId("_r_ID08SqEeuBjv5G5kw00g")]
    [Description(
        @"Balance of money or securities that is at the disposal of the account owner on the date specified."
    )]
    Available = BalanceTypeCode.Available, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cleared items balance.
    /// Encoded/decoded by serializers as &quot;CLRI&quot;.
    /// </summary>
    [EnumMember(Value = "CLRI")]
    [IsoId("_r_ID1cSqEeuBjv5G5kw00g")]
    [Description(@"Cleared items balance. ")]
    ClearedItem = BalanceTypeCode.ClearedItem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ledger balance refers to posted transactions (e.g. limit authorisation amount - posted transactions).
    /// Encoded/decoded by serializers as &quot;LDGR&quot;.
    /// </summary>
    [EnumMember(Value = "LDGR")]
    [IsoId("_r_ID18SqEeuBjv5G5kw00g")]
    [Description(
        @"Ledger balance refers to posted transactions (e.g. limit authorisation amount - posted transactions)."
    )]
    Ledger = BalanceTypeCode.Ledger, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Value expressed in points.
    /// Encoded/decoded by serializers as &quot;PNTS&quot;.
    /// </summary>
    [EnumMember(Value = "PNTS")]
    [IsoId("_y5o-4cSqEeuBjv5G5kw00g")]
    [Description(@"Value expressed in points.")]
    Points = BalanceTypeCode.Points, // same ordinal as derivation source for type conversions
}
