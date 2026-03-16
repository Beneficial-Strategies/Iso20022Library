// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of notice period.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aNwLcNp-Ed-ak6NoX_4Aeg_1085847746")]
[Description(@"Specifies the type of notice period.")]
public enum NoticePeriodTypeCode
{
    /// <summary>
    /// The notice period is expressed in banking working days.
    /// Encoded/decoded by serializers as &quot;BKWD&quot;.
    /// </summary>
    [EnumMember(Value = "BKWD")]
    [IsoId("_aNwLcdp-Ed-ak6NoX_4Aeg_-1131461794")]
    [Description(@"The notice period is expressed in banking working days.")]
    BankWorkingDay,

    /// <summary>
    /// The notice period is expressed in calendar days.
    /// Encoded/decoded by serializers as &quot;DAYC&quot;.
    /// </summary>
    [EnumMember(Value = "DAYC")]
    [IsoId("_aNwLctp-Ed-ak6NoX_4Aeg_-852557806")]
    [Description(@"The notice period is expressed in calendar days.")]
    CalendarDay,

    /// <summary>
    /// The notice period is expressed in months.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_aNwLc9p-Ed-ak6NoX_4Aeg_-833163063")]
    [Description(@"The notice period is expressed in months.")]
    Month,

    /// <summary>
    /// The notice period is expressed in weeks.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_aNwLdNp-Ed-ak6NoX_4Aeg_-816539570")]
    [Description(@"The notice period is expressed in weeks.")]
    Week,

    /// <summary>
    /// The notice period is expressed in working days.
    /// Encoded/decoded by serializers as &quot;WOKD&quot;.
    /// </summary>
    [EnumMember(Value = "WOKD")]
    [IsoId("_aNwLddp-Ed-ak6NoX_4Aeg_-792530041")]
    [Description(@"The notice period is expressed in working days.")]
    WorkingDay,

    /// <summary>
    /// The notice period is expressed in years.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_aNwLdtp-Ed-ak6NoX_4Aeg_-774982225")]
    [Description(@"The notice period is expressed in years.")]
    Year,
}
