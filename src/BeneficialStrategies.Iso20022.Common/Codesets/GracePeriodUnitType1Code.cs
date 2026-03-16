// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the details of the grace period applicable to the instalment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tjpgUDEpEemzCpWiCwK4aQ")]
[Description(@"Contains the details of the grace period applicable to the instalment.")]
[DerivedFrom(typeof(GracePeriodUnitTypeCode))]
public enum GracePeriodUnitType1Code
{
    /// <summary>
    /// Grace period weeks.
    /// Encoded/decoded by serializers as &quot;WEKS&quot;.
    /// </summary>
    [EnumMember(Value = "WEKS")]
    [IsoId("_xb7ZcTEpEemzCpWiCwK4aQ")]
    [Description(@"Grace period weeks.")]
    Weeks = GracePeriodUnitTypeCode.Weeks, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Grace period payments.
    /// Encoded/decoded by serializers as &quot;PMTS&quot;.
    /// </summary>
    [EnumMember(Value = "PMTS")]
    [IsoId("_xwpFMTEpEemzCpWiCwK4aQ")]
    [Description(@"Grace period payments.")]
    Payments = GracePeriodUnitTypeCode.Payments, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other Private Grace period.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_yFqS8TEpEemzCpWiCwK4aQ")]
    [Description(@"Other Private Grace period.")]
    OtherPrivate = GracePeriodUnitTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other National Grace period.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_yaONsTEpEemzCpWiCwK4aQ")]
    [Description(@"Other National Grace period.")]
    OtherNational = GracePeriodUnitTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Grace period months.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_yuo-gTEpEemzCpWiCwK4aQ")]
    [Description(@"Grace period months.")]
    Months = GracePeriodUnitTypeCode.Months, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Grace period days.
    /// Encoded/decoded by serializers as &quot;DAYS&quot;.
    /// </summary>
    [EnumMember(Value = "DAYS")]
    [IsoId("_zDWqQTEpEemzCpWiCwK4aQ")]
    [Description(@"Grace period days.")]
    Days = GracePeriodUnitTypeCode.Days, // same ordinal as derivation source for type conversions
}
