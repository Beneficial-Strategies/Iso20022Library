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
[IsoId("_aqzT1tp-Ed-ak6NoX_4Aeg_611309431")]
[Description(
    @"Indicates whether the floor limit applies to credit, to debit or to both credit and debit entries."
)]
[Derivations(typeof(FloorLimitType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<FloorLimitTypeCode>))]
#endif
public enum FloorLimitTypeCode
{
    /// <summary>
    /// Floor limit applies to credit entries.
    /// Encoded/decoded by serializers as &quot;CRED&quot;.
    /// </summary>
    [EnumMember(Value = "CRED")]
    [IsoId("_aqzT19p-Ed-ak6NoX_4Aeg_611309456")]
    [Description(@"Floor limit applies to credit entries.")]
    Credit,

    /// <summary>
    /// Floor limit applies to debit entries.
    /// Encoded/decoded by serializers as &quot;DEBT&quot;.
    /// </summary>
    [EnumMember(Value = "DEBT")]
    [IsoId("_aq9E0Np-Ed-ak6NoX_4Aeg_612229445")]
    [Description(@"Floor limit applies to debit entries.")]
    Debit,

    /// <summary>
    /// Floor limit applies to both credit and debit entries.
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_aq9E0dp-Ed-ak6NoX_4Aeg_612229462")]
    [Description(@"Floor limit applies to both credit and debit entries.")]
    Both,
}
