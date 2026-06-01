// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the tenor of the interest rate index.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YGPL8CPVEemWEvsGXWJaQg")]
[Description(@"Specifies the tenor of the interest rate index.")]
[Derivations(typeof(InterestRateIndexTenor2Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<InterestRateIndexTenorCode>))]
public enum InterestRateIndexTenorCode
{
    /// <summary>
    /// Tenor is 1 day.
    /// Encoded/decoded by serializers as &quot;DAIL&quot;.
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_5t8F4CPWEemWEvsGXWJaQg")]
    [Description(@"Tenor is 1 day.")]
    Day1,

    /// <summary>
    /// Tenor is 4 months.
    /// Encoded/decoded by serializers as &quot;FOMN&quot;.
    /// </summary>
    [EnumMember(Value = "FOMN")]
    [IsoId("_O_HkgCPXEemWEvsGXWJaQg")]
    [Description(@"Tenor is 4 months.")]
    Month4,

    /// <summary>
    /// Tenor is IntraDay.
    /// Encoded/decoded by serializers as &quot;INDA&quot;.
    /// </summary>
    [EnumMember(Value = "INDA")]
    [IsoId("_3asQ4CPWEemWEvsGXWJaQg")]
    [Description(@"Tenor is IntraDay.")]
    IntraDay,

    /// <summary>
    /// Tenor is 1 month.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_Crhr8CPXEemWEvsGXWJaQg")]
    [Description(@"Tenor is 1 month.")]
    Month1,

    /// <summary>
    /// Tenor is on demand.
    /// Encoded/decoded by serializers as &quot;ONDE&quot;.
    /// </summary>
    [EnumMember(Value = "ONDE")]
    [IsoId("_XUqTICPXEemWEvsGXWJaQg")]
    [Description(@"Tenor is on demand.")]
    OnDemand,

    /// <summary>
    /// Tenor is other unspecified time unit.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Zy0-sCPXEemWEvsGXWJaQg")]
    [Description(@"Tenor is other unspecified time unit.")]
    Other,

    /// <summary>
    /// Tenor is overnght.
    /// Encoded/decoded by serializers as &quot;OVNG&quot;.
    /// </summary>
    [EnumMember(Value = "OVNG")]
    [IsoId("_algOQCPWEemWEvsGXWJaQg")]
    [Description(@"Tenor is overnght.")]
    Overnight,

    /// <summary>
    /// Tenor is 3 months.
    /// Encoded/decoded by serializers as &quot;QUTR&quot;.
    /// </summary>
    [EnumMember(Value = "QUTR")]
    [IsoId("_L37KECPXEemWEvsGXWJaQg")]
    [Description(@"Tenor is 3 months.")]
    Month3,

    /// <summary>
    /// Tenor is 6 months.
    /// Encoded/decoded by serializers as &quot;SEMI&quot;.
    /// </summary>
    [EnumMember(Value = "SEMI")]
    [IsoId("_RUqfkCPXEemWEvsGXWJaQg")]
    [Description(@"Tenor is 6 months.")]
    Month6,

    /// <summary>
    /// Tenor is 2 months.
    /// Encoded/decoded by serializers as &quot;TOMN&quot;.
    /// </summary>
    [EnumMember(Value = "TOMN")]
    [IsoId("_GbGVACPXEemWEvsGXWJaQg")]
    [Description(@"Tenor is 2 months.")]
    Month2,

    /// <summary>
    /// Tenor is 2 weeks.
    /// Encoded/decoded by serializers as &quot;TOWK&quot;.
    /// </summary>
    [EnumMember(Value = "TOWK")]
    [IsoId("__cnf8CPWEemWEvsGXWJaQg")]
    [Description(@"Tenor is 2 weeks.")]
    Week2,

    /// <summary>
    /// Tenor is 1 week.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_8K9h8CPWEemWEvsGXWJaQg")]
    [Description(@"Tenor is 1 week.")]
    Week1,

    /// <summary>
    /// Tenor is 12 months.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_U9-IkCPXEemWEvsGXWJaQg")]
    [Description(@"Tenor is 12 months.")]
    Month12,
}
