// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies different levels of permission.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_fJFegJiuEeO4o528ngEXuw")]
[Description(@"Specifies different levels of permission.")]
[Derivations(typeof(AccountPermissionType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AccountPermissionTypeCode>))]
#endif
public enum AccountPermissionTypeCode
{
    /// <summary>
    /// No right to use the account.
    /// Encoded/decoded by serializers as &quot;NORI&quot;.
    /// </summary>
    [EnumMember(Value = "NORI")]
    [IsoId("_lCwnoJiuEeO4o528ngEXuw")]
    [Description(@"No right to use the account.")]
    NoRight,

    /// <summary>
    /// Right to use the account alone.
    /// Encoded/decoded by serializers as &quot;RIAL&quot;.
    /// </summary>
    [EnumMember(Value = "RIAL")]
    [IsoId("_smNK8JiuEeO4o528ngEXuw")]
    [Description(@"Right to use the account alone.")]
    RightToUseAlone,

    /// <summary>
    /// Right to use the account together with another person.
    /// Encoded/decoded by serializers as &quot;RIWI&quot;.
    /// </summary>
    [EnumMember(Value = "RIWI")]
    [IsoId("_0GHSEJiuEeO4o528ngEXuw")]
    [Description(@"Right to use the account together with another person.")]
    RightToUseWithOther,
}
