// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of day.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ay2cldp-Ed-ak6NoX_4Aeg_1145636079")]
[Description(@"Specifies the type of day.")]
[Derivations(typeof(DayType1Code))]
public enum DayTypeCode
{
    /// <summary>
    /// Elapsed calendar days.
    /// Encoded/decoded by serializers as &quot;ACTU&quot;.
    /// </summary>
    [EnumMember(Value = "ACTU")]
    [IsoId("_ay2cltp-Ed-ak6NoX_4Aeg_1179808198")]
    [Description(@"Elapsed calendar days.")]
    ElapsedCalendarDays,

    /// <summary>
    /// Elapsed business days.
    /// Encoded/decoded by serializers as &quot;BUSE&quot;.
    /// </summary>
    [EnumMember(Value = "BUSE")]
    [IsoId("_ay2cl9p-Ed-ak6NoX_4Aeg_1296170343")]
    [Description(@"Elapsed business days.")]
    ElapsedBusinessDays,
}
