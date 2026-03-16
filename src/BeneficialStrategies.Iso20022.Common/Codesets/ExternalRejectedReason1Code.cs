// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a rejected status
/// The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cgC6IFj8EeOgwYxfAV02bg")]
[Description(
    @"Specifies the reason for a rejected status|The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalRejectedReasonCode))]
public enum ExternalRejectedReason1Code
{
    /// <summary>
    /// Received after the servicer&apos;s deadline
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_uVsmNfRYEeuLhpyIdtJzwg")]
    [Description(@"Received after the servicer's deadline")]
    ServicerDeadlineMissed = ExternalRejectedReasonCode.ServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Date is not a business day
    /// Encoded/decoded by serializers as &quot;BDAY&quot;.
    /// </summary>
    [EnumMember(Value = "BDAY")]
    [IsoId("_uVsmOPRYEeuLhpyIdtJzwg")]
    [Description(@"Date is not a business day")]
    NotBusinessDay = ExternalRejectedReasonCode.NotBusinessDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid client
    /// Encoded/decoded by serializers as &quot;CTRC&quot;.
    /// </summary>
    [EnumMember(Value = "CTRC")]
    [IsoId("_uVsmO_RYEeuLhpyIdtJzwg")]
    [Description(@"Unrecognised or invalid client")]
    ClosingTransaction = ExternalRejectedReasonCode.ClosingTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request has been rejected because the instruction process is in progress or has been processed
    /// Encoded/decoded by serializers as &quot;DPRG&quot;.
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("_uV1wIvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Request has been rejected because the instruction process is in progress or has been processed"
    )]
    RejectedSinceInProgress = ExternalRejectedReasonCode.RejectedSinceInProgress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Some message details specified in the instruction/request are inconsistent with those that expected
    /// Encoded/decoded by serializers as &quot;INDT&quot;.
    /// </summary>
    [EnumMember(Value = "INDT")]
    [IsoId("_uV1wJfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Some message details specified in the instruction/request are inconsistent with those that expected"
    )]
    InvalidDetails = ExternalRejectedReasonCode.InvalidDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The request cannot be executed. The message requested is not valid
    /// Encoded/decoded by serializers as &quot;MISM&quot;.
    /// </summary>
    [EnumMember(Value = "MISM")]
    [IsoId("_uV1wKPRYEeuLhpyIdtJzwg")]
    [Description(@"The request cannot be executed. The message requested is not valid")]
    InvalidRequest = ExternalRejectedReasonCode.InvalidRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Permission to be processed is not granted
    /// Encoded/decoded by serializers as &quot;NAUT&quot;.
    /// </summary>
    [EnumMember(Value = "NAUT")]
    [IsoId("_uV1wK_RYEeuLhpyIdtJzwg")]
    [Description(@"Permission to be processed is not granted")]
    NotAuthorised = ExternalRejectedReasonCode.NotAuthorised, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Referred instrument does not exist
    /// Encoded/decoded by serializers as &quot;NINS&quot;.
    /// </summary>
    [EnumMember(Value = "NINS")]
    [IsoId("_uV_hIvRYEeuLhpyIdtJzwg")]
    [Description(@"Referred instrument does not exist")]
    NoInstrument = ExternalRejectedReasonCode.NoInstrument, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Client has no access to the service
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_uV_hJfRYEeuLhpyIdtJzwg")]
    [Description(@"Client has no access to the service")]
    NoAccessToService = ExternalRejectedReasonCode.NoAccessToService, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid effective date/time
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_uV_hKPRYEeuLhpyIdtJzwg")]
    [Description(@"Unrecognised or invalid effective date/time")]
    ClosingDateTimeRejection = ExternalRejectedReasonCode.ClosingDateTimeRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Acknowledgement of settlement batch received from PSO for settlement.
    /// Encoded/decoded by serializers as &quot;ASBR&quot;.
    /// </summary>
    [EnumMember(Value = "ASBR")]
    [IsoId("_dCfacQTqEey95qpfbNuEwg")]
    [Description(@"Acknowledgement of settlement batch received from PSO for settlement.")]
    AcknowledgementOfSettlementBatchReceived =
        ExternalRejectedReasonCode.AcknowledgementOfSettlementBatchReceived, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement Instruction with invalid account number or specific settlement type.
    /// Encoded/decoded by serializers as &quot;AB15&quot;.
    /// </summary>
    [EnumMember(Value = "AB15")]
    [IsoId("_dIAMkQTqEey95qpfbNuEwg")]
    [Description(
        @"Settlement Instruction with invalid account number or specific settlement type."
    )]
    InvalidAccountNumberForSettlementType =
        ExternalRejectedReasonCode.InvalidAccountNumberForSettlementType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid batch Settlement Instruction received.
    /// Encoded/decoded by serializers as &quot;AB26&quot;.
    /// </summary>
    [EnumMember(Value = "AB26")]
    [IsoId("_dQMfQQTqEey95qpfbNuEwg")]
    [Description(@"Invalid batch Settlement Instruction received.")]
    InvalidBatchSettlementInstruction =
        ExternalRejectedReasonCode.InvalidBatchSettlementInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Process a Batch Removal Instruction with an incorrect Batch Concurrent Sequence.
    /// Encoded/decoded by serializers as &quot;AB12&quot;.
    /// </summary>
    [EnumMember(Value = "AB12")]
    [IsoId("_dV3CYQTqEey95qpfbNuEwg")]
    [Description(
        @"Process a Batch Removal Instruction with an incorrect Batch Concurrent Sequence."
    )]
    InvalidConcurrentBatchSettlementInstructionSequenceNumber =
        ExternalRejectedReasonCode.InvalidConcurrentBatchSettlementInstructionSequenceNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Process a Batch Removal Instruction with an incorrect &quot;Original Creation Date and Time&quot; for the batch.
    /// Encoded/decoded by serializers as &quot;DT07&quot;.
    /// </summary>
    [EnumMember(Value = "DT07")]
    [IsoId("_dbX0gQTqEey95qpfbNuEwg")]
    [Description(
        @"Process a Batch Removal Instruction with an incorrect ""Original Creation Date and Time"" for the batch."
    )]
    InvalidCreationDate = ExternalRejectedReasonCode.InvalidCreationDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid routing code send by participant to settlement operator.
    /// Encoded/decoded by serializers as &quot;AB13&quot;.
    /// </summary>
    [EnumMember(Value = "AB13")]
    [IsoId("_dhCXoQTqEey95qpfbNuEwg")]
    [Description(@"Invalid routing code send by participant to settlement operator.")]
    InvalidRoutingCodeUtilised = ExternalRejectedReasonCode.InvalidRoutingCodeUtilised, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Processing interbank batch settlement instruction with invalid agreement number for settlement type.
    /// Encoded/decoded by serializers as &quot;AB21&quot;.
    /// </summary>
    [EnumMember(Value = "AB21")]
    [IsoId("_dqt4EQTqEey95qpfbNuEwg")]
    [Description(
        @"Processing interbank batch settlement instruction with invalid agreement number for settlement type."
    )]
    InvalidSettlementAgreementNumberSpecified =
        ExternalRejectedReasonCode.InvalidSettlementAgreementNumberSpecified, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid settlement window for settlement instruction.
    /// Encoded/decoded by serializers as &quot;ISWS&quot;.
    /// </summary>
    [EnumMember(Value = "ISWS")]
    [IsoId("_dw-4IQTqEey95qpfbNuEwg")]
    [Description(@"Invalid settlement window for settlement instruction.")]
    InvalidSettlementWindow = ExternalRejectedReasonCode.InvalidSettlementWindow, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Missing ISIN on settlement instruction.
    /// Encoded/decoded by serializers as &quot;MISN&quot;.
    /// </summary>
    [EnumMember(Value = "MISN")]
    [IsoId("_d3iMEQTqEey95qpfbNuEwg")]
    [Description(@"Missing ISIN on settlement instruction.")]
    MissingISIN = ExternalRejectedReasonCode.MissingISIN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Warning messages that is send to participants when settlement account must be funded.
    /// Encoded/decoded by serializers as &quot;NOFR&quot;.
    /// </summary>
    [EnumMember(Value = "NOFR")]
    [IsoId("_eB0JcQTqEey95qpfbNuEwg")]
    [Description(
        @"Warning messages that is send to participants when settlement account must be funded."
    )]
    OutstandingFundingForSettlement = ExternalRejectedReasonCode.OutstandingFundingForSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participant is in BCP no settlement instruction for CLS.
    /// Encoded/decoded by serializers as &quot;RC14&quot;.
    /// </summary>
    [EnumMember(Value = "RC14")]
    [IsoId("_eH7YgQTqEey95qpfbNuEwg")]
    [Description(@"Participant is in BCP no settlement instruction for CLS.")]
    ParticipantInBCPNoCLSInstructionsAllowed =
        ExternalRejectedReasonCode.ParticipantInBCPNoCLSInstructionsAllowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Originator of the instruction is not an active participant in SADC RTGS.
    /// Encoded/decoded by serializers as &quot;RC16&quot;.
    /// </summary>
    [EnumMember(Value = "RC16")]
    [IsoId("_eNvFkQTqEey95qpfbNuEwg")]
    [Description(@"Originator of the instruction is not an active participant in SADC RTGS.")]
    ParticipantNotActiveMemberOfSADCRTGS =
        ExternalRejectedReasonCode.ParticipantNotActiveMemberOfSADCRTGS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participant is not an active member of a specific settlement type.
    /// Encoded/decoded by serializers as &quot;RC15&quot;.
    /// </summary>
    [EnumMember(Value = "RC15")]
    [IsoId("_eVMYcQTqEey95qpfbNuEwg")]
    [Description(@"Participant is not an active member of a specific settlement type.")]
    ParticipantNotActiveMemberSettlementType =
        ExternalRejectedReasonCode.ParticipantNotActiveMemberSettlementType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Originator of the instruction is not an active participant in RTGS.
    /// Encoded/decoded by serializers as &quot;RC13&quot;.
    /// </summary>
    [EnumMember(Value = "RC13")]
    [IsoId("_ebvsYQTqEey95qpfbNuEwg")]
    [Description(@"Originator of the instruction is not an active participant in RTGS.")]
    ParticipantNotAnActiveMemberOfRTGS =
        ExternalRejectedReasonCode.ParticipantNotAnActiveMemberOfRTGS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement batch removal notification due to batch not funded at window closure by participants.
    /// Encoded/decoded by serializers as &quot;SBRN&quot;.
    /// </summary>
    [EnumMember(Value = "SBRN")]
    [IsoId("_eiTnYQTqEey95qpfbNuEwg")]
    [Description(
        @"Settlement batch removal notification due to batch not funded at window closure by participants."
    )]
    SettlementBatchRemovalNotification =
        ExternalRejectedReasonCode.SettlementBatchRemovalNotification, // same ordinal as derivation source for type conversions
}
