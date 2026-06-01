// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the details of the grace period applicable to the instalment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZtKP0RUUEfC_aaedwHHlmw")]
[Description(@"Contains the details of the grace period applicable to the instalment.")]
[DerivedFrom(typeof(GracePeriodUnitTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<GracePeriodUnitType2Code>))]
public enum GracePeriodUnitType2Code
{
    /// <summary>
    /// Grace period days.
    /// Encoded/decoded by serializers as &quot;DAYS&quot;.
    /// </summary>
    [EnumMember(Value = "DAYS")]
    [IsoId("_Z0QWWxUUEfC_aaedwHHlmw")]
    [Description(@"Grace period days.")]
    Days = GracePeriodUnitTypeCode.Days, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Grace period months.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_Z0QWWRUUEfC_aaedwHHlmw")]
    [Description(@"Grace period months.")]
    Months = GracePeriodUnitTypeCode.Months, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Grace period weeks.
    /// Encoded/decoded by serializers as &quot;WEKS&quot;.
    /// </summary>
    [EnumMember(Value = "WEKS")]
    [IsoId("_Z0QWURUUEfC_aaedwHHlmw")]
    [Description(@"Grace period weeks.")]
    Weeks = GracePeriodUnitTypeCode.Weeks, // same ordinal as derivation source for type conversions
}
