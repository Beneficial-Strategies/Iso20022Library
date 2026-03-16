// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the permission to use the account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9snSQJiuEeO4o528ngEXuw")]
[Description(@"Specifies the permission to use the account.")]
[DerivedFrom(typeof(AccountPermissionTypeCode))]
public enum AccountPermissionType1Code
{
    /// <summary>
    /// No right to use the account.
    /// Encoded/decoded by serializers as &quot;NORI&quot;.
    /// </summary>
    [EnumMember(Value = "NORI")]
    [IsoId("_WMuDoZiyEeOuCKiE8vUpBQ")]
    [Description(@"No right to use the account.")]
    NoRight = AccountPermissionTypeCode.NoRight, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Right to use the account alone.
    /// Encoded/decoded by serializers as &quot;RIAL&quot;.
    /// </summary>
    [EnumMember(Value = "RIAL")]
    [IsoId("_WbHsAZiyEeOuCKiE8vUpBQ")]
    [Description(@"Right to use the account alone.")]
    RightToUseAlone = AccountPermissionTypeCode.RightToUseAlone, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Right to use the account together with another person.
    /// Encoded/decoded by serializers as &quot;RIWI&quot;.
    /// </summary>
    [EnumMember(Value = "RIWI")]
    [IsoId("_WoKCcZiyEeOuCKiE8vUpBQ")]
    [Description(@"Right to use the account together with another person.")]
    RightToUseWithOther = AccountPermissionTypeCode.RightToUseWithOther, // same ordinal as derivation source for type conversions
}
