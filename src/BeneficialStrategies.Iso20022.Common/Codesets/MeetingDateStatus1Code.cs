// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the possible statuses of a meeting date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aVWBMdp-Ed-ak6NoX_4Aeg_890839689")]
[Description(@"Identifies the possible statuses of a meeting date.")]
[DerivedFrom(typeof(MeetingDateStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MeetingDateStatus1Code>))]
#endif
public enum MeetingDateStatus1Code
{
    /// <summary>
    /// Meeting date is tentative.
    /// Encoded/decoded by serializers as &quot;TNTA&quot;.
    /// </summary>
    [EnumMember(Value = "TNTA")]
    [IsoId("_aVWBMtp-Ed-ak6NoX_4Aeg_1034907041")]
    [Description(@"Meeting date is tentative.")]
    Tentative = MeetingDateStatusCode.Tentative, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Meeting date is confirmed.
    /// Encoded/decoded by serializers as &quot;CNFR&quot;.
    /// </summary>
    [EnumMember(Value = "CNFR")]
    [IsoId("_aVWBM9p-Ed-ak6NoX_4Aeg_1049683942")]
    [Description(@"Meeting date is confirmed.")]
    Confirmed = MeetingDateStatusCode.Confirmed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Meeting date has been cancelled.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_aVWBNNp-Ed-ak6NoX_4Aeg_1064459735")]
    [Description(@"Meeting date has been cancelled.")]
    Cancelled = MeetingDateStatusCode.Cancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Meeting could not take place as the quorum was not reached.
    /// Encoded/decoded by serializers as &quot;NOQO&quot;.
    /// </summary>
    [EnumMember(Value = "NOQO")]
    [IsoId("_aVWBNdp-Ed-ak6NoX_4Aeg_-1791743871")]
    [Description(@"Meeting could not take place as the quorum was not reached.")]
    NoQuorum = MeetingDateStatusCode.NoQuorum, // same ordinal as derivation source for type conversions
}
