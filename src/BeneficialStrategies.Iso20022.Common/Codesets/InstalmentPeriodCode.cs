// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Instalment period.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ji4689uTEei2qvU6FBLZYA")]
[Description(@"Instalment period.")]
[Derivations(typeof(InstalmentPeriod1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InstalmentPeriodCode>))]
#endif
public enum InstalmentPeriodCode
{
    /// <summary>
    /// Monthly instalment period.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_ji469duTEei2qvU6FBLZYA")]
    [Description(@"Monthly instalment period.")]
    Monthly,

    /// <summary>
    /// Annual instalment period.
    /// Encoded/decoded by serializers as &quot;ANNU&quot;.
    /// </summary>
    [EnumMember(Value = "ANNU")]
    [IsoId("_ji469NuTEei2qvU6FBLZYA")]
    [Description(@"Annual instalment period.")]
    Annual,
}
