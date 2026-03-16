// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_k1I4cfNvEeqRfth943bvEA")]
[Description(@"Specifies the status of an instruction.")]
[Derivations(typeof(Status9Code))]
public enum StatusV2Code
{
    /// <summary>
    /// Processing of the instruction is pending.
    /// Encoded/decoded by serializers as &quot;PPRC&quot;.
    /// </summary>
    [EnumMember(Value = "PPRC")]
    [IsoId("_k1I4dvNvEeqRfth943bvEA")]
    [Description(@"Processing of the instruction is pending.")]
    PendingProcessing,

    /// <summary>
    /// Instruction has been acknowledged and accepted and is validated for further processing.
    /// Encoded/decoded by serializers as &quot;PAAC&quot;.
    /// </summary>
    [EnumMember(Value = "PAAC")]
    [IsoId("_k1I4ffNvEeqRfth943bvEA")]
    [Description(
        @"Instruction has been acknowledged and accepted and is validated for further processing."
    )]
    AcknowledgedAccepted,

    /// <summary>
    /// Instruction has been rejected.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_k1I4ePNvEeqRfth943bvEA")]
    [Description(@"Instruction has been rejected.")]
    Rejected,

    /// <summary>
    /// Instruction has been accepted and is validated for further processing.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_k1I4c_NvEeqRfth943bvEA")]
    [Description(@"Instruction has been accepted and is validated for further processing.")]
    Accepted,

    /// <summary>
    /// Processing has been completed.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_k1I4evNvEeqRfth943bvEA")]
    [Description(@"Processing has been completed.")]
    Completed,

    /// <summary>
    /// No instruction has been received (to be used in a reminder).
    /// Encoded/decoded by serializers as &quot;NOIN&quot;.
    /// </summary>
    [EnumMember(Value = "NOIN")]
    [IsoId("_k1I4fvNvEeqRfth943bvEA")]
    [Description(@"No instruction has been received (to be used in a reminder).")]
    NotReceived,

    /// <summary>
    /// Instruction has been cancelled.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_k1I4f_NvEeqRfth943bvEA")]
    [Description(@"Instruction has been cancelled.")]
    Cancelled,

    /// <summary>
    /// Cancel request is being processed.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_k1I4d_NvEeqRfth943bvEA")]
    [Description(@"Cancel request is being processed.")]
    BeingCancelled,

    /// <summary>
    /// Instruction has been received by Issuer, equivalent to the confirmation of receipt of votes cast electronically.
    /// Encoded/decoded by serializers as &quot;RCIS&quot;.
    /// </summary>
    [EnumMember(Value = "RCIS")]
    [IsoId("_k1I4gfNvEeqRfth943bvEA")]
    [Description(
        @"Instruction has been received by Issuer, equivalent to the confirmation of receipt of votes cast electronically."
    )]
    ReceivedByIssuerOrRegistrar,

    /// <summary>
    /// Instruction is pending.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_k1I4e_NvEeqRfth943bvEA")]
    [Description(@"Instruction is pending.")]
    Pending,

    /// <summary>
    /// Standing instruction is applied.
    /// Encoded/decoded by serializers as &quot;STIN&quot;.
    /// </summary>
    [EnumMember(Value = "STIN")]
    [IsoId("_k1I4dPNvEeqRfth943bvEA")]
    [Description(@"Standing instruction is applied.")]
    StandingInstruction,

    /// <summary>
    /// Instruction is queued.
    /// Encoded/decoded by serializers as &quot;QUED&quot;.
    /// </summary>
    [EnumMember(Value = "QUED")]
    [IsoId("_k1I4efNvEeqRfth943bvEA")]
    [Description(@"Instruction is queued.")]
    Queued,

    /// <summary>
    /// Instruction has been cancelled by the agent, for example, due to an event deadline extension.
    /// Encoded/decoded by serializers as &quot;CSUB&quot;.
    /// </summary>
    [EnumMember(Value = "CSUB")]
    [IsoId("_k1I4fPNvEeqRfth943bvEA")]
    [Description(
        @"Instruction has been cancelled by the agent, for example, due to an event deadline extension."
    )]
    CancelledBySubcustodian,

    /// <summary>
    /// Accepted and sent along the chain.
    /// Encoded/decoded by serializers as &quot;FRWD&quot;.
    /// </summary>
    [EnumMember(Value = "FRWD")]
    [IsoId("_k1I4gPNvEeqRfth943bvEA")]
    [Description(@"Accepted and sent along the chain.")]
    Forwarded,

    /// <summary>
    /// Attendance is confirmed at the meeting.
    /// Encoded/decoded by serializers as &quot;ATTC&quot;.
    /// </summary>
    [EnumMember(Value = "ATTC")]
    [IsoId("_k1I4cvNvEeqRfth943bvEA")]
    [Description(@"Attendance is confirmed at the meeting.")]
    AttendanceConfirmed,

    /// <summary>
    /// Rights holder has been registered to participate to the meeting.
    /// Encoded/decoded by serializers as &quot;REGM&quot;.
    /// </summary>
    [EnumMember(Value = "REGM")]
    [IsoId("_k1I4dfNvEeqRfth943bvEA")]
    [Description(@"Rights holder has been registered to participate to the meeting.")]
    RegisteredToParticipateAtMeeting,
}
