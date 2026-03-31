// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines if and how charges and taxes due are paid to the financial institution.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6Vwww5qlEeGSON8vddiWzQ_197335871")]
[Description(@"Defines if and how charges and taxes due are paid to the financial institution.")]
[Derivations(typeof(CompensationMethod1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CompensationMethodCode>))]
#endif
public enum CompensationMethodCode
{
    /// <summary>
    /// Account does not pay and charges or taxes due.
    /// Encoded/decoded by serializers as &quot;NOCP&quot;.
    /// </summary>
    [EnumMember(Value = "NOCP")]
    [IsoId("_6VwwxJqlEeGSON8vddiWzQ_375454543")]
    [Description(@"Account does not pay and charges or taxes due.")]
    No,

    /// <summary>
    /// Account is debited for any charges or taxes due.
    /// Encoded/decoded by serializers as &quot;DBTD&quot;.
    /// </summary>
    [EnumMember(Value = "DBTD")]
    [IsoId("_6VwwxZqlEeGSON8vddiWzQ_83496805")]
    [Description(@"Account is debited for any charges or taxes due.")]
    Debited,

    /// <summary>
    /// Account or summary account is invoiced for any charges or taxes due.
    /// Encoded/decoded by serializers as &quot;INVD&quot;.
    /// </summary>
    [EnumMember(Value = "INVD")]
    [IsoId("_6VwwxpqlEeGSON8vddiWzQ_1842603306")]
    [Description(@"Account or summary account is invoiced for any charges or taxes due.")]
    Invoiced,

    /// <summary>
    /// Account is automatically debited on a future date.
    /// Encoded/decoded by serializers as &quot;DDBT&quot;.
    /// </summary>
    [EnumMember(Value = "DDBT")]
    [IsoId("_6Vwwx5qlEeGSON8vddiWzQ_-799736482")]
    [Description(@"Account is automatically debited on a future date.")]
    DelayedDebit,
}
