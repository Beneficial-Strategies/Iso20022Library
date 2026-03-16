// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Date is specified as a fixed code value.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cgm0oO4EEeqc-LCjwLsUVg")]
[Description(@"Date is specified as a fixed code value.")]
[DerivedFrom(typeof(DateTypeCode))]
public enum DateType9Code
{
    /// <summary>
    /// Blocking occurs until and inclusive of the end of the election period of the option.
    /// Encoded/decoded by serializers as &quot;PWAL&quot;.
    /// </summary>
    [EnumMember(Value = "PWAL")]
    [IsoId("_fv2X0e4EEeqc-LCjwLsUVg")]
    [Description(
        @"Blocking occurs until and inclusive of the end of the election period of the option."
    )]
    BlockingTillEndOfElectionPeriod = DateTypeCode.BlockingTillEndOfElectionPeriod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Blocking occurs until and inclusive of the market deadline of the option.
    /// Encoded/decoded by serializers as &quot;MKDT&quot;.
    /// </summary>
    [EnumMember(Value = "MKDT")]
    [IsoId("_f1gT4e4EEeqc-LCjwLsUVg")]
    [Description(@"Blocking occurs until and inclusive of the market deadline of the option.")]
    BlockingTillMarketDeadline = DateTypeCode.BlockingTillMarketDeadline, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Blocking occurs until and inclusive of the meeting date.
    /// Encoded/decoded by serializers as &quot;MEET&quot;.
    /// </summary>
    [EnumMember(Value = "MEET")]
    [IsoId("_f7Ae8e4EEeqc-LCjwLsUVg")]
    [Description(@"Blocking occurs until and inclusive of the meeting date.")]
    BlockingTillMeetingDate = DateTypeCode.BlockingTillMeetingDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unblocking will occur on payment date of the option.
    /// Encoded/decoded by serializers as &quot;PAYD&quot;.
    /// </summary>
    [EnumMember(Value = "PAYD")]
    [IsoId("_gAqbAe4EEeqc-LCjwLsUVg")]
    [Description(@"Unblocking will occur on payment date of the option.")]
    BlockingTillPaymentDate = DateTypeCode.BlockingTillPaymentDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Blocking occurs until and inclusive of the record date of the event.
    /// Encoded/decoded by serializers as &quot;RDTE&quot;.
    /// </summary>
    [EnumMember(Value = "RDTE")]
    [IsoId("_gGKmEe4EEeqc-LCjwLsUVg")]
    [Description(@"Blocking occurs until and inclusive of the record date of the event.")]
    BlockingTillRecordDate = DateTypeCode.BlockingTillRecordDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Blocking occurs until and inclusive of the account servicer deadline for the option.
    /// Encoded/decoded by serializers as &quot;RDDT&quot;.
    /// </summary>
    [EnumMember(Value = "RDDT")]
    [IsoId("_gMROEe4EEeqc-LCjwLsUVg")]
    [Description(
        @"Blocking occurs until and inclusive of the account servicer deadline for the option."
    )]
    BlockingTillResponseDeadline = DateTypeCode.BlockingTillResponseDeadline, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Refer to additional information element for the date until when the securities are blocked.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_gUv0oe4EEeqc-LCjwLsUVg")]
    [Description(
        @"Refer to additional information element for the date until when the securities are blocked."
    )]
    NarrativeUnblockingDate = DateTypeCode.NarrativeUnblockingDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Date is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_gordQe4EEeqc-LCjwLsUVg")]
    [Description(@"Date is unknown by the sender or has not been established.")]
    Unknown = DateTypeCode.Unknown, // same ordinal as derivation source for type conversions
}
