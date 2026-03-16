// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of day.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ay2cktp-Ed-ak6NoX_4Aeg_1637875532")]
[Description(@"Specifies the type of day.")]
[DerivedFrom(typeof(DayTypeCode))]
public enum DayType1Code
{
    /// <summary>
    /// Elapsed calendar days.
    /// Encoded/decoded by serializers as &quot;ACTU&quot;.
    /// </summary>
    [EnumMember(Value = "ACTU")]
    [IsoId("_ay2ck9p-Ed-ak6NoX_4Aeg_1678509570")]
    [Description(@"Elapsed calendar days.")]
    ElapsedCalendarDays = DayTypeCode.ElapsedCalendarDays, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Elapsed business days.
    /// Encoded/decoded by serializers as &quot;BUSE&quot;.
    /// </summary>
    [EnumMember(Value = "BUSE")]
    [IsoId("_ay2clNp-Ed-ak6NoX_4Aeg_1678509571")]
    [Description(@"Elapsed business days.")]
    ElapsedBusinessDays = DayTypeCode.ElapsedBusinessDays, // same ordinal as derivation source for type conversions
}
