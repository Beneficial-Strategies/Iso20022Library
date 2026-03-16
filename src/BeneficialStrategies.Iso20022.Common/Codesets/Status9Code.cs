// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2GrRoPNvEeqRfth943bvEA")]
[Description(@"Specifies the status of an instruction.")]
[DerivedFrom(typeof(StatusV2Code))]
public enum Status9Code
{
    /// <summary>
    /// Instruction has been accepted and is validated for further processing.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_8eAnIfNvEeqRfth943bvEA")]
    [Description(@"Instruction has been accepted and is validated for further processing.")]
    Accepted = StatusV2Code.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Attendance is confirmed at the meeting.
    /// Encoded/decoded by serializers as &quot;ATTC&quot;.
    /// </summary>
    [EnumMember(Value = "ATTC")]
    [IsoId("_9EsMofNvEeqRfth943bvEA")]
    [Description(@"Attendance is confirmed at the meeting.")]
    AttendanceConfirmed = StatusV2Code.AttendanceConfirmed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been cancelled.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_9qfBUfNvEeqRfth943bvEA")]
    [Description(@"Instruction has been cancelled.")]
    Cancelled = StatusV2Code.Cancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been cancelled by the agent, for example, due to an event deadline extension.
    /// Encoded/decoded by serializers as &quot;CSUB&quot;.
    /// </summary>
    [EnumMember(Value = "CSUB")]
    [IsoId("_94UpAfNvEeqRfth943bvEA")]
    [Description(
        @"Instruction has been cancelled by the agent, for example, due to an event deadline extension."
    )]
    CancelledBySubcustodian = StatusV2Code.CancelledBySubcustodian, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Accepted and sent along the chain.
    /// Encoded/decoded by serializers as &quot;FRWD&quot;.
    /// </summary>
    [EnumMember(Value = "FRWD")]
    [IsoId("_-fmEYfNvEeqRfth943bvEA")]
    [Description(@"Accepted and sent along the chain.")]
    Forwarded = StatusV2Code.Forwarded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been received by Issuer, equivalent to the confirmation of receipt of votes cast electronically.
    /// Encoded/decoded by serializers as &quot;RCIS&quot;.
    /// </summary>
    [EnumMember(Value = "RCIS")]
    [IsoId("__E8NIfNvEeqRfth943bvEA")]
    [Description(
        @"Instruction has been received by Issuer, equivalent to the confirmation of receipt of votes cast electronically."
    )]
    ReceivedByIssuerOrRegistrar = StatusV2Code.ReceivedByIssuerOrRegistrar, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rights holder has been registered to participate to the meeting.
    /// Encoded/decoded by serializers as &quot;REGM&quot;.
    /// </summary>
    [EnumMember(Value = "REGM")]
    [IsoId("__qkpwfNvEeqRfth943bvEA")]
    [Description(@"Rights holder has been registered to participate to the meeting.")]
    RegisteredToParticipateAtMeeting = StatusV2Code.RegisteredToParticipateAtMeeting, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Standing instruction is applied.
    /// Encoded/decoded by serializers as &quot;STIN&quot;.
    /// </summary>
    [EnumMember(Value = "STIN")]
    [IsoId("_AMfrEfNwEeqRfth943bvEA")]
    [Description(@"Standing instruction is applied.")]
    StandingInstruction = StatusV2Code.StandingInstruction, // same ordinal as derivation source for type conversions
}
