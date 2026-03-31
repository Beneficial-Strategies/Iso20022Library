// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.StatusReason6Choice;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.pain;

namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// Realistic instantiation examples for <see cref="CustomerPaymentStatusReportV13"/>
/// (pain.002.001.13 — Customer Payment Status Report).
///
/// pain.002 is the bank's acknowledgment back to the originating corporate for a
/// pain.001 payment initiation. It may carry a positive acceptance, an in-process
/// status, or a rejection with reason codes. Used in every major scheme.
///
/// Examples reference the original pain.001 in <see cref="Pain001ExamplesTests"/>.
/// </summary>
public class Pain002ExamplesTests
{
    // ── Shared builders ────────────────────────────────────────────────────────

    public static GroupHeader86 CreateGroupHeader(string msgId = "DEUTDEFF/240315/PAI002/00001") =>
        new()
        {
            MessageIdentification = msgId,
            CreationDateTime = Iso20022TestData.MessageCreationDateTime.AddMinutes(1),
            DebtorAgent = Iso20022TestData.DebtorAgent,
        };

    public static OriginalGroupHeader17 CreateOriginalGroupInfo() =>
        new()
        {
            OriginalMessageIdentification = "ACME/240315/PAI001/00001",
            OriginalMessageNameIdentification = "pain.001.001.11",
            OriginalCreationDateTime = Iso20022TestData.MessageCreationDateTime,
        };

    public static OriginalPaymentInstruction45 CreateOriginalPaymentInfo(
        ExternalPaymentGroupStatus1Code? status = null
    ) =>
        new()
        {
            OriginalPaymentInformationIdentification = "ACME/240315/PMTINF/001",
            PaymentInformationStatus = status,
        };

    // ── Examples ───────────────────────────────────────────────────────────────

    /// <summary>
    /// Positive acknowledgment at group level: Deutsche Bank confirms the pain.001
    /// has been accepted for processing (ACCP — Accepted Customer Profile).
    /// No transaction-level detail is included at this stage.
    /// </summary>
    [Fact]
    public void GroupAccepted_ACCP_CanInstantiate()
    {
        var message = new CustomerPaymentStatusReportV13
        {
            GroupHeader = CreateGroupHeader(),
            OriginalGroupInformationAndStatus = CreateOriginalGroupInfo() with
            {
                GroupStatus = ExternalPaymentGroupStatus1Code.AcceptedCustomerProfile,
            },
        };

        Assert.NotNull(message);
        Assert.Equal("pain.002.001.13", CustomerPaymentStatusReportV13.IsoIdentifier);
        Assert.Equal(
            ExternalPaymentGroupStatus1Code.AcceptedCustomerProfile,
            message.OriginalGroupInformationAndStatus.GroupStatus
        );
    }

    /// <summary>
    /// Group-level technical validation passed (ACTC — Accepted Technical Validation).
    /// Deutsche Bank has validated the message syntax but has not yet processed it.
    /// </summary>
    [Fact]
    public void GroupTechnicallyValidated_ACTC_CanInstantiate()
    {
        var message = new CustomerPaymentStatusReportV13
        {
            GroupHeader = CreateGroupHeader("DEUTDEFF/240315/PAI002/00002"),
            OriginalGroupInformationAndStatus = CreateOriginalGroupInfo() with
            {
                GroupStatus = ExternalPaymentGroupStatus1Code.AcceptedTechnicalValidation,
            },
        };

        Assert.NotNull(message);
        Assert.Equal(
            ExternalPaymentGroupStatus1Code.AcceptedTechnicalValidation,
            message.OriginalGroupInformationAndStatus.GroupStatus
        );
    }

    /// <summary>
    /// Transaction-level rejection with a standard status reason code — the
    /// <see cref="Code"/> variant of <see cref="StatusReason6Choice_"/>.
    /// AC04 = account closed. The payment cannot be executed.
    /// </summary>
    [Fact]
    public void TransactionRejected_AC04_StatusReason6ChoiceCodeVariant()
    {
        var message = new CustomerPaymentStatusReportV13
        {
            GroupHeader = CreateGroupHeader("DEUTDEFF/240315/PAI002/00003"),
            OriginalGroupInformationAndStatus = CreateOriginalGroupInfo(),
            OriginalPaymentInformationAndStatus = CreateOriginalPaymentInfo(
                ExternalPaymentGroupStatus1Code.Rejected
            ) with
            {
                TransactionInformationAndStatus = [new PaymentTransaction144
                {
                    OriginalInstructionIdentification = Iso20022TestData.InstructionId,
                    OriginalEndToEndIdentification = Iso20022TestData.EndToEndId,
                    OriginalUETR = Iso20022TestData.Uetr,
                    TransactionStatus = ExternalPaymentTransactionStatus1Code.Rejected,
                    StatusReasonInformation = [new StatusReasonInformation12
                    {
                        Originator = Iso20022TestData.Debtor,
                        Reason = new Code
                        {
                            Value = ExternalStatusReason1Code.ClosedAccountNumber,
                        },
                        AdditionalInformation =
                            ["Creditor account FR7630006000011234567890189 was closed on 2024-01-31."],
                    }],
                }],
            },
        };

        Assert.NotNull(message);
        Assert.Equal(
            ExternalPaymentGroupStatus1Code.Rejected,
            message.OriginalPaymentInformationAndStatus!.PaymentInformationStatus
        );
        Assert.IsType<Code>(
            message
                .OriginalPaymentInformationAndStatus
                .TransactionInformationAndStatus![0]
                .StatusReasonInformation![0]
                .Reason
        );
    }

    /// <summary>
    /// Transaction-level rejection with a proprietary reason — the
    /// <see cref="Proprietary"/> variant of <see cref="StatusReason6Choice_"/>.
    /// Used for bank-internal reasons with no standard ISO code mapping.
    /// </summary>
    [Fact]
    public void TransactionRejected_ProprietaryReason_StatusReason6ChoiceProprietaryVariant()
    {
        var message = new CustomerPaymentStatusReportV13
        {
            GroupHeader = CreateGroupHeader("DEUTDEFF/240315/PAI002/00004"),
            OriginalGroupInformationAndStatus = CreateOriginalGroupInfo(),
            OriginalPaymentInformationAndStatus = CreateOriginalPaymentInfo(
                ExternalPaymentGroupStatus1Code.Rejected
            ) with
            {
                TransactionInformationAndStatus = [new PaymentTransaction144
                {
                    OriginalEndToEndIdentification = Iso20022TestData.EndToEndId,
                    OriginalUETR = Iso20022TestData.Uetr,
                    TransactionStatus = ExternalPaymentTransactionStatus1Code.Rejected,
                    StatusReasonInformation = [new StatusReasonInformation12
                    {
                        Reason = new Proprietary { Value = "DEUTDE-DAILY-LIMIT-EXCEEDED", },
                        AdditionalInformation =
                            ["Single-payment limit EUR 50,000 exceeded. Contact your relationship manager."],
                    }],
                }],
            },
        };

        Assert.NotNull(message);
        Assert.IsType<Proprietary>(
            message
                .OriginalPaymentInformationAndStatus!
                .TransactionInformationAndStatus![0]
                .StatusReasonInformation![0]
                .Reason
        );
    }

    /// <summary>
    /// Payment accepted and pending settlement — PDNG status at transaction level.
    /// The instruction has been accepted but settlement has not yet occurred.
    /// Typical for same-day SEPA SCT with a future execution date.
    /// </summary>
    [Fact]
    public void TransactionPending_PDNG_CanInstantiate()
    {
        var message = new CustomerPaymentStatusReportV13
        {
            GroupHeader = CreateGroupHeader("DEUTDEFF/240315/PAI002/00005"),
            OriginalGroupInformationAndStatus = CreateOriginalGroupInfo() with
            {
                GroupStatus = ExternalPaymentGroupStatus1Code.AcceptedWithChange,
            },
            OriginalPaymentInformationAndStatus = new OriginalPaymentInstruction45
            {
                OriginalPaymentInformationIdentification = "ACME/240315/PMTINF/001",
                TransactionInformationAndStatus = [new PaymentTransaction144
                {
                    OriginalEndToEndIdentification = Iso20022TestData.EndToEndId,
                    OriginalUETR = Iso20022TestData.Uetr,
                    TransactionStatus = ExternalPaymentTransactionStatus1Code.Pending,
                    AcceptanceDateTime = Iso20022TestData.MessageCreationDateTime.AddMinutes(1),
                }],
            },
        };

        Assert.NotNull(message);
        Assert.Equal(
            ExternalPaymentTransactionStatus1Code.Pending,
            message
                .OriginalPaymentInformationAndStatus!
                .TransactionInformationAndStatus![0]
                .TransactionStatus
        );
    }
}
