// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a rejected status
/// The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_W-sxcVj8EeOgwYxfAV02bg")]
[Description(
    @"Specifies the reason for a rejected status|The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalRejectedReason1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalRejectedReasonCode>))]
#endif
public enum ExternalRejectedReasonCode
{
    /// <summary>
    /// Received after the servicer&apos;s deadline
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_uVsmM_RYEeuLhpyIdtJzwg")]
    [Description(@"Received after the servicer's deadline")]
    ServicerDeadlineMissed,

    /// <summary>
    /// Date is not a business day
    /// Encoded/decoded by serializers as &quot;BDAY&quot;.
    /// </summary>
    [EnumMember(Value = "BDAY")]
    [IsoId("_uVsmNvRYEeuLhpyIdtJzwg")]
    [Description(@"Date is not a business day")]
    NotBusinessDay,

    /// <summary>
    /// Unrecognised or invalid client
    /// Encoded/decoded by serializers as &quot;CTRC&quot;.
    /// </summary>
    [EnumMember(Value = "CTRC")]
    [IsoId("_uVsmOfRYEeuLhpyIdtJzwg")]
    [Description(@"Unrecognised or invalid client")]
    ClosingTransaction,

    /// <summary>
    /// Request has been rejected because the instruction process is in progress or has been processed
    /// Encoded/decoded by serializers as &quot;DPRG&quot;.
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("_uV1wIPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Request has been rejected because the instruction process is in progress or has been processed"
    )]
    RejectedSinceInProgress,

    /// <summary>
    /// Some message details specified in the instruction/request are inconsistent with those that expected
    /// Encoded/decoded by serializers as &quot;INDT&quot;.
    /// </summary>
    [EnumMember(Value = "INDT")]
    [IsoId("_uV1wI_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Some message details specified in the instruction/request are inconsistent with those that expected"
    )]
    InvalidDetails,

    /// <summary>
    /// The request cannot be executed. The message requested is not valid
    /// Encoded/decoded by serializers as &quot;MISM&quot;.
    /// </summary>
    [EnumMember(Value = "MISM")]
    [IsoId("_uV1wJvRYEeuLhpyIdtJzwg")]
    [Description(@"The request cannot be executed. The message requested is not valid")]
    InvalidRequest,

    /// <summary>
    /// Permission to be processed is not granted
    /// Encoded/decoded by serializers as &quot;NAUT&quot;.
    /// </summary>
    [EnumMember(Value = "NAUT")]
    [IsoId("_uV1wKfRYEeuLhpyIdtJzwg")]
    [Description(@"Permission to be processed is not granted")]
    NotAuthorised,

    /// <summary>
    /// Referred instrument does not exist
    /// Encoded/decoded by serializers as &quot;NINS&quot;.
    /// </summary>
    [EnumMember(Value = "NINS")]
    [IsoId("_uV_hIPRYEeuLhpyIdtJzwg")]
    [Description(@"Referred instrument does not exist")]
    NoInstrument,

    /// <summary>
    /// Client has no access to the service
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_uV_hI_RYEeuLhpyIdtJzwg")]
    [Description(@"Client has no access to the service")]
    NoAccessToService,

    /// <summary>
    /// Unrecognised or invalid effective date/time
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_uV_hJvRYEeuLhpyIdtJzwg")]
    [Description(@"Unrecognised or invalid effective date/time")]
    ClosingDateTimeRejection,

    /// <summary>
    /// Process a Batch Removal Instruction with an incorrect Batch Concurrent Sequence.
    /// Encoded/decoded by serializers as &quot;AB12&quot;.
    /// </summary>
    [EnumMember(Value = "AB12")]
    [IsoId("_IDy6UATnEey95qpfbNuEwg")]
    [Description(
        @"Process a Batch Removal Instruction with an incorrect Batch Concurrent Sequence."
    )]
    InvalidConcurrentBatchSettlementInstructionSequenceNumber,

    /// <summary>
    /// Process a Batch Removal Instruction with an incorrect &quot;Original Creation Date and Time&quot; for the batch.
    /// Encoded/decoded by serializers as &quot;DT07&quot;.
    /// </summary>
    [EnumMember(Value = "DT07")]
    [IsoId("_WvddgATnEey95qpfbNuEwg")]
    [Description(
        @"Process a Batch Removal Instruction with an incorrect ""Original Creation Date and Time"" for the batch."
    )]
    InvalidCreationDate,

    /// <summary>
    /// Invalid routing code send by participant to settlement operator.
    /// Encoded/decoded by serializers as &quot;AB13&quot;.
    /// </summary>
    [EnumMember(Value = "AB13")]
    [IsoId("_hL7cYATnEey95qpfbNuEwg")]
    [Description(@"Invalid routing code send by participant to settlement operator.")]
    InvalidRoutingCodeUtilised,

    /// <summary>
    /// Settlement Instruction with invalid account number or specific settlement type.
    /// Encoded/decoded by serializers as &quot;AB15&quot;.
    /// </summary>
    [EnumMember(Value = "AB15")]
    [IsoId("_8bzuEATnEey95qpfbNuEwg")]
    [Description(
        @"Settlement Instruction with invalid account number or specific settlement type."
    )]
    InvalidAccountNumberForSettlementType,

    /// <summary>
    /// Processing interbank batch settlement instruction with invalid agreement number for settlement type.
    /// Encoded/decoded by serializers as &quot;AB21&quot;.
    /// </summary>
    [EnumMember(Value = "AB21")]
    [IsoId("_HN4JgAToEey95qpfbNuEwg")]
    [Description(
        @"Processing interbank batch settlement instruction with invalid agreement number for settlement type."
    )]
    InvalidSettlementAgreementNumberSpecified,

    /// <summary>
    /// Warning messages that is send to participants when settlement account must be funded.
    /// Encoded/decoded by serializers as &quot;NOFR&quot;.
    /// </summary>
    [EnumMember(Value = "NOFR")]
    [IsoId("_UWBEcAToEey95qpfbNuEwg")]
    [Description(
        @"Warning messages that is send to participants when settlement account must be funded."
    )]
    OutstandingFundingForSettlement,

    /// <summary>
    /// Acknowledgement of settlement batch received from PSO for settlement.
    /// Encoded/decoded by serializers as &quot;ASBR&quot;.
    /// </summary>
    [EnumMember(Value = "ASBR")]
    [IsoId("_iiYcgAToEey95qpfbNuEwg")]
    [Description(@"Acknowledgement of settlement batch received from PSO for settlement.")]
    AcknowledgementOfSettlementBatchReceived,

    /// <summary>
    /// Settlement batch removal notification due to batch not funded at window closure by participants.
    /// Encoded/decoded by serializers as &quot;SBRN&quot;.
    /// </summary>
    [EnumMember(Value = "SBRN")]
    [IsoId("_vKelcAToEey95qpfbNuEwg")]
    [Description(
        @"Settlement batch removal notification due to batch not funded at window closure by participants."
    )]
    SettlementBatchRemovalNotification,

    /// <summary>
    /// Invalid batch Settlement Instruction received.
    /// Encoded/decoded by serializers as &quot;AB26&quot;.
    /// </summary>
    [EnumMember(Value = "AB26")]
    [IsoId("_4KQj4AToEey95qpfbNuEwg")]
    [Description(@"Invalid batch Settlement Instruction received.")]
    InvalidBatchSettlementInstruction,

    /// <summary>
    /// Originator of the instruction is not an active participant in RTGS.
    /// Encoded/decoded by serializers as &quot;RC13&quot;.
    /// </summary>
    [EnumMember(Value = "RC13")]
    [IsoId("_D5kqsATpEey95qpfbNuEwg")]
    [Description(@"Originator of the instruction is not an active participant in RTGS.")]
    ParticipantNotAnActiveMemberOfRTGS,

    /// <summary>
    /// Participant is in BCP no settlement instruction for CLS.
    /// Encoded/decoded by serializers as &quot;RC14&quot;.
    /// </summary>
    [EnumMember(Value = "RC14")]
    [IsoId("_Q7clkATpEey95qpfbNuEwg")]
    [Description(@"Participant is in BCP no settlement instruction for CLS.")]
    ParticipantInBCPNoCLSInstructionsAllowed,

    /// <summary>
    /// Participant is not an active member of a specific settlement type.
    /// Encoded/decoded by serializers as &quot;RC15&quot;.
    /// </summary>
    [EnumMember(Value = "RC15")]
    [IsoId("_fdkyQATpEey95qpfbNuEwg")]
    [Description(@"Participant is not an active member of a specific settlement type.")]
    ParticipantNotActiveMemberSettlementType,

    /// <summary>
    /// Originator of the instruction is not an active participant in SADC RTGS.
    /// Encoded/decoded by serializers as &quot;RC16&quot;.
    /// </summary>
    [EnumMember(Value = "RC16")]
    [IsoId("_zN7-YATpEey95qpfbNuEwg")]
    [Description(@"Originator of the instruction is not an active participant in SADC RTGS.")]
    ParticipantNotActiveMemberOfSADCRTGS,

    /// <summary>
    /// Invalid settlement window for settlement instruction.
    /// Encoded/decoded by serializers as &quot;ISWS&quot;.
    /// </summary>
    [EnumMember(Value = "ISWS")]
    [IsoId("_7i9IkATpEey95qpfbNuEwg")]
    [Description(@"Invalid settlement window for settlement instruction.")]
    InvalidSettlementWindow,

    /// <summary>
    /// Missing ISIN on settlement instruction.
    /// Encoded/decoded by serializers as &quot;MISN&quot;.
    /// </summary>
    [EnumMember(Value = "MISN")]
    [IsoId("_IojF0ATqEey95qpfbNuEwg")]
    [Description(@"Missing ISIN on settlement instruction.")]
    MissingISIN,
}
