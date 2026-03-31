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
[IsoId("_s75uYDEqEemzCpWiCwK4aQ")]
[Description(@"Instalment period.")]
[DerivedFrom(typeof(InstalmentPeriodCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InstalmentPeriod1Code>))]
#endif
public enum InstalmentPeriod1Code
{
    /// <summary>
    /// Monthly instalment period.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_wMPdwTEqEemzCpWiCwK4aQ")]
    [Description(@"Monthly instalment period.")]
    Monthly = InstalmentPeriodCode.Monthly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Annual instalment period.
    /// Encoded/decoded by serializers as &quot;ANNU&quot;.
    /// </summary>
    [EnumMember(Value = "ANNU")]
    [IsoId("_wgNioTEqEemzCpWiCwK4aQ")]
    [Description(@"Annual instalment period.")]
    Annual = InstalmentPeriodCode.Annual, // same ordinal as derivation source for type conversions
}
