// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the current status of a limit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8J5r8KMgEeCJ6YNENx4h-w_-308307214")]
[Description(@"Specifies the current status of a limit.")]
[DerivedFrom(typeof(ReservationStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ReservationStatus1Code>))]
#endif
public enum ReservationStatus1Code
{
    /// <summary>
    /// Reservation is currently in effect.
    /// Encoded/decoded by serializers as &quot;ENAB&quot;.
    /// </summary>
    [EnumMember(Value = "ENAB")]
    [IsoId("_8J5r8aMgEeCJ6YNENx4h-w_312799950")]
    [Description(@"Reservation is currently in effect.")]
    Enabled = ReservationStatusCode.Enabled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reservation is not currently in effect.|.
    /// Encoded/decoded by serializers as &quot;DISA&quot;.
    /// </summary>
    [EnumMember(Value = "DISA")]
    [IsoId("_8J5r8qMgEeCJ6YNENx4h-w_898746976")]
    [Description(@"Reservation is not currently in effect.|.")]
    Disabled = ReservationStatusCode.Disabled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reservation has been deleted or suspended.
    /// Encoded/decoded by serializers as &quot;DELD&quot;.
    /// </summary>
    [EnumMember(Value = "DELD")]
    [IsoId("_8J5r86MgEeCJ6YNENx4h-w_-173258083")]
    [Description(@"Reservation has been deleted or suspended.")]
    Deleted = ReservationStatusCode.Deleted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reservation has been asked for and is not yet enabled.|.
    /// Encoded/decoded by serializers as &quot;REQD&quot;.
    /// </summary>
    [EnumMember(Value = "REQD")]
    [IsoId("_8J5r9KMgEeCJ6YNENx4h-w_280829186")]
    [Description(@"Reservation has been asked for and is not yet enabled.|.")]
    Requested = ReservationStatusCode.Requested, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reservation is blocked or frozen due to external circumstances such as a court order, death of beneficiary or account owner, or bankruptcy.
    /// Encoded/decoded by serializers as &quot;BLKD&quot;.
    /// </summary>
    [EnumMember(Value = "BLKD")]
    [IsoId("_8J5r9aMgEeCJ6YNENx4h-w_-1729127672")]
    [Description(
        @"Reservation is blocked or frozen due to external circumstances such as a court order, death of beneficiary or account owner, or bankruptcy."
    )]
    Blocked = ReservationStatusCode.Blocked, // same ordinal as derivation source for type conversions
}
