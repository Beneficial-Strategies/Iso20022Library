// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the regularity of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_eDUHcA1nEeKGXqvMN6jpiw")]
[Description(@"Specifies the regularity of an event.")]
[DerivedFrom(typeof(FrequencyCode))]
public enum Frequency7Code
{
    /// <summary>
    /// Event takes place every year or once a year.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_gqp9IQ1nEeKGXqvMN6jpiw")]
    [Description(@"Event takes place every year or once a year.")]
    Annual = FrequencyCode.Annual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every day.
    /// Encoded/decoded by serializers as &quot;DAIL&quot;.
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_hLTMEQ1nEeKGXqvMN6jpiw")]
    [Description(@"Event takes place every day.")]
    Daily = FrequencyCode.Daily, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_he9u8Q1nEeKGXqvMN6jpiw")]
    [Description(@"Event takes place every month or once a month.")]
    Monthly = FrequencyCode.Monthly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as &quot;QURT&quot;.
    /// </summary>
    [EnumMember(Value = "QURT")]
    [IsoId("_iIZGcQ1nEeKGXqvMN6jpiw")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarterly = FrequencyCode.Quarterly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as &quot;MIAN&quot;.
    /// </summary>
    [EnumMember(Value = "MIAN")]
    [IsoId("_ijz3IQ1nEeKGXqvMN6jpiw")]
    [Description(@"Event takes place every six months or two times a year.")]
    SemiAnnual = FrequencyCode.SemiAnnual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every ten business days.
    /// Encoded/decoded by serializers as &quot;TEND&quot;.
    /// </summary>
    [EnumMember(Value = "TEND")]
    [IsoId("_i8jHQQ1nEeKGXqvMN6jpiw")]
    [Description(@"Event takes place every ten business days.")]
    TenDays = FrequencyCode.TenDays, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place at the end of the day if there was a movement on the account, otherwise nothing is sent that day.
    /// Encoded/decoded by serializers as &quot;MOVE&quot;.
    /// </summary>
    [EnumMember(Value = "MOVE")]
    [IsoId("_jV40UQ1nEeKGXqvMN6jpiw")]
    [Description(
        @"Event takes place at the end of the day if there was a movement on the account, otherwise nothing is sent that day."
    )]
    TriggeredByMovement = FrequencyCode.TriggeredByMovement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place once a week.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_jfRZ0Q1nEeKGXqvMN6jpiw")]
    [Description(@"Event takes place once a week.")]
    Weekly = FrequencyCode.Weekly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place several times a day.
    /// Encoded/decoded by serializers as &quot;INDA&quot;.
    /// </summary>
    [EnumMember(Value = "INDA")]
    [IsoId("_BmNaYUqAEeKw5sECfP82rg")]
    [Description(@"Event takes place several times a day.")]
    IntraDay = FrequencyCode.IntraDay, // same ordinal as derivation source for type conversions
}
