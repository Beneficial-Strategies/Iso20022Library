// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the frequency of an interest payment with a time unit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ln76kSLBEe2KAJot-YBP6w")]
[Description(@"Specifies the frequency of an interest payment with a time unit.")]
[DerivedFrom(typeof(FrequencyCode))]
public enum Frequency19Code
{
    /// <summary>
    /// Event takes place every day.
    /// Encoded/decoded by serializers as &quot;DAIL&quot;.
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_lo_qgSLBEe2KAJot-YBP6w")]
    [Description(@"Event takes place every day.")]
    Daily = FrequencyCode.Daily, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place once a week.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_lo_qiSLBEe2KAJot-YBP6w")]
    [Description(@"Event takes place once a week.")]
    Weekly = FrequencyCode.Weekly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_lo_qlyLBEe2KAJot-YBP6w")]
    [Description(@"Event takes place every month or once a month.")]
    Monthly = FrequencyCode.Monthly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every year or once a year.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_lo_qpSLBEe2KAJot-YBP6w")]
    [Description(@"Event takes place every year or once a year.")]
    Annual = FrequencyCode.Annual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place on request or as necessary.
    /// Encoded/decoded by serializers as &quot;ADHO&quot;.
    /// </summary>
    [EnumMember(Value = "ADHO")]
    [IsoId("_lo_qsyLBEe2KAJot-YBP6w")]
    [Description(@"Event takes place on request or as necessary.")]
    Adhoc = FrequencyCode.Adhoc, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event occurs on expiry of a financial contract.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_lo_quyLBEe2KAJot-YBP6w")]
    [Description(@"Event occurs on expiry of a financial contract.")]
    OnExpiry = FrequencyCode.OnExpiry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as &quot;MIAN&quot;.
    /// </summary>
    [EnumMember(Value = "MIAN")]
    [IsoId("_lo_qvSLBEe2KAJot-YBP6w")]
    [Description(@"Event takes place every six months or two times a year.")]
    SemiAnnual = FrequencyCode.SemiAnnual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as &quot;QURT&quot;.
    /// </summary>
    [EnumMember(Value = "QURT")]
    [IsoId("_lo_qxSLBEe2KAJot-YBP6w")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarterly = FrequencyCode.Quarterly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every hours.
    /// Encoded/decoded by serializers as &quot;HOUL&quot;.
    /// </summary>
    [EnumMember(Value = "HOUL")]
    [IsoId("_lo_q0yLBEe2KAJot-YBP6w")]
    [Description(@"Event takes place every hours.")]
    Hourly = FrequencyCode.Hourly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place on demand.
    /// Encoded/decoded by serializers as &quot;ODMD&quot;.
    /// </summary>
    [EnumMember(Value = "ODMD")]
    [IsoId("_mn0DMSLBEe2KAJot-YBP6w")]
    [Description(@"Event takes place on demand.")]
    OnDemand = FrequencyCode.OnDemand, // same ordinal as derivation source for type conversions
}
