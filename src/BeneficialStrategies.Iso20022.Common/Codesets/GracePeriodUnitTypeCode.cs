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
[IsoId("_s_4u99uVEei2qvU6FBLZYA")]
[Description(@"Contains the details of the grace period applicable to the instalment.")]
[Derivations(typeof(GracePeriodUnitType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<GracePeriodUnitTypeCode>))]
#endif
public enum GracePeriodUnitTypeCode
{
    /// <summary>
    /// Grace period months.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_s_4u-duVEei2qvU6FBLZYA")]
    [Description(@"Grace period months.")]
    Months,

    /// <summary>
    /// Grace period payments.
    /// Encoded/decoded by serializers as &quot;PMTS&quot;.
    /// </summary>
    [EnumMember(Value = "PMTS")]
    [IsoId("_s_4u_NuVEei2qvU6FBLZYA")]
    [Description(@"Grace period payments.")]
    Payments,

    /// <summary>
    /// Grace period days.
    /// Encoded/decoded by serializers as &quot;DAYS&quot;.
    /// </summary>
    [EnumMember(Value = "DAYS")]
    [IsoId("_s_4u-NuVEei2qvU6FBLZYA")]
    [Description(@"Grace period days.")]
    Days,

    /// <summary>
    /// Grace period weeks.
    /// Encoded/decoded by serializers as &quot;WEKS&quot;.
    /// </summary>
    [EnumMember(Value = "WEKS")]
    [IsoId("_s_4u-9uVEei2qvU6FBLZYA")]
    [Description(@"Grace period weeks.")]
    Weeks,

    /// <summary>
    /// Other National Grace period.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_s_4u-tuVEei2qvU6FBLZYA")]
    [Description(@"Other National Grace period.")]
    OtherNational,

    /// <summary>
    /// Other Private Grace period.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_s_4u_duVEei2qvU6FBLZYA")]
    [Description(@"Other Private Grace period.")]
    OtherPrivate,
}
