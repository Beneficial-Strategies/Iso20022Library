// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the floor limit applies to credit, to debit or to both credit and debit entries.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aqzT0tp-Ed-ak6NoX_4Aeg_-1031522617")]
[Description(
    @"Indicates whether the floor limit applies to credit, to debit or to both credit and debit entries."
)]
[DerivedFrom(typeof(FloorLimitTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<FloorLimitType1Code>))]
#endif
public enum FloorLimitType1Code
{
    /// <summary>
    /// Floor limit applies to credit entries.
    /// Encoded/decoded by serializers as &quot;CRED&quot;.
    /// </summary>
    [EnumMember(Value = "CRED")]
    [IsoId("_aqzT09p-Ed-ak6NoX_4Aeg_-430226238")]
    [Description(@"Floor limit applies to credit entries.")]
    Credit = FloorLimitTypeCode.Credit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Floor limit applies to debit entries.
    /// Encoded/decoded by serializers as &quot;DEBT&quot;.
    /// </summary>
    [EnumMember(Value = "DEBT")]
    [IsoId("_aqzT1Np-Ed-ak6NoX_4Aeg_-371121394")]
    [Description(@"Floor limit applies to debit entries.")]
    Debit = FloorLimitTypeCode.Debit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Floor limit applies to both credit and debit entries.
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_aqzT1dp-Ed-ak6NoX_4Aeg_-344337748")]
    [Description(@"Floor limit applies to both credit and debit entries.")]
    Both = FloorLimitTypeCode.Both, // same ordinal as derivation source for type conversions
}
