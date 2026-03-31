// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the level of an account within the account hierarchy.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6Uas9pqlEeGSON8vddiWzQ_-1016370047")]
[Description(@"Defines the level of an account within the account hierarchy.")]
[DerivedFrom(typeof(AccountLevelCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AccountLevel2Code>))]
#endif
public enum AccountLevel2Code
{
    /// <summary>
    /// Intermediate level within an account hierarchy.
    /// Encoded/decoded by serializers as &quot;INTM&quot;.
    /// </summary>
    [EnumMember(Value = "INTM")]
    [IsoId("_6Uas95qlEeGSON8vddiWzQ_-77486222")]
    [Description(@"Intermediate level within an account hierarchy.")]
    Intermediate = AccountLevelCode.Intermediate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Highest level within an account hierarchy.
    /// Encoded/decoded by serializers as &quot;SMRY&quot;.
    /// </summary>
    [EnumMember(Value = "SMRY")]
    [IsoId("_6Ukd8JqlEeGSON8vddiWzQ_1446759063")]
    [Description(@"Highest level within an account hierarchy.")]
    Summary = AccountLevelCode.Summary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is a real deposit/current account.
    /// Encoded/decoded by serializers as &quot;DETL&quot;.
    /// </summary>
    [EnumMember(Value = "DETL")]
    [IsoId("_6Ukd8ZqlEeGSON8vddiWzQ_-2087443080")]
    [Description(@"Account is a real deposit/current account.")]
    Detail = AccountLevelCode.Detail, // same ordinal as derivation source for type conversions
}
