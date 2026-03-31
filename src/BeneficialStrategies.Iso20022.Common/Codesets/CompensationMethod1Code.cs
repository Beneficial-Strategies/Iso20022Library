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
[IsoId("_6Vm_x5qlEeGSON8vddiWzQ_2080901699")]
[Description(@"Defines if and how charges and taxes due are paid to the financial institution.")]
[DerivedFrom(typeof(CompensationMethodCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CompensationMethod1Code>))]
#endif
public enum CompensationMethod1Code
{
    /// <summary>
    /// Account does not pay and charges or taxes due.
    /// Encoded/decoded by serializers as &quot;NOCP&quot;.
    /// </summary>
    [EnumMember(Value = "NOCP")]
    [IsoId("_6Vm_yJqlEeGSON8vddiWzQ_-1993728072")]
    [Description(@"Account does not pay and charges or taxes due.")]
    No = CompensationMethodCode.No, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is debited for any charges or taxes due.
    /// Encoded/decoded by serializers as &quot;DBTD&quot;.
    /// </summary>
    [EnumMember(Value = "DBTD")]
    [IsoId("_6VwwwJqlEeGSON8vddiWzQ_-1432359176")]
    [Description(@"Account is debited for any charges or taxes due.")]
    Debited = CompensationMethodCode.Debited, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account or summary account is invoiced for any charges or taxes due.
    /// Encoded/decoded by serializers as &quot;INVD&quot;.
    /// </summary>
    [EnumMember(Value = "INVD")]
    [IsoId("_6VwwwZqlEeGSON8vddiWzQ_1164179586")]
    [Description(@"Account or summary account is invoiced for any charges or taxes due.")]
    Invoiced = CompensationMethodCode.Invoiced, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is automatically debited on a future date.
    /// Encoded/decoded by serializers as &quot;DDBT&quot;.
    /// </summary>
    [EnumMember(Value = "DDBT")]
    [IsoId("_6VwwwpqlEeGSON8vddiWzQ_-174770726")]
    [Description(@"Account is automatically debited on a future date.")]
    DelayedDebit = CompensationMethodCode.DelayedDebit, // same ordinal as derivation source for type conversions
}
