// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.StatusReason6Choice;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.pacs;

namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// Realistic instantiation examples for <see cref="FIToFIPaymentStatusReportV13"/>
/// (pacs.002.001.13 — FI-to-FI Payment Status Report).
///
/// pacs.002 carries the positive or negative acknowledgment for a previously
/// submitted pacs.008 or pacs.009. Used by every major scheme.
///
/// Examples reference the pacs.008 in <see cref="Pacs008ExamplesTests"/>.
/// </summary>
public class Pacs002ExamplesTests
{
    // ── Shared builders ────────────────────────────────────────────────────────

    public static GroupHeader101 CreateGroupHeader(string msgId = "BNPAFRPP/240315/PAC002/00001") =>
        new()
        {
            MessageIdentification = msgId,
            CreationDateTime = Iso20022TestData.MessageCreationDateTime.AddMinutes(2),
            InstructingAgent = Iso20022TestData.CreditorAgent,
            InstructedAgent = Iso20022TestData.DebtorAgent,
        };

    public static OriginalGroupHeader17 CreateOriginalGroupInfo() =>
        new()
        {
            OriginalMessageIdentification = Iso20022TestData.OriginalPacs008MsgId,
            OriginalMessageNameIdentification = "pacs.008.001.11",
            OriginalCreationDateTime = Iso20022TestData.MessageCreationDateTime,
        };

    public static PaymentTransaction142 CreateAcceptedTransactionStatus() =>
        new()
        {
            OriginalEndToEndIdentification = Iso20022TestData.EndToEndId,
            OriginalUETR = Iso20022TestData.Uetr,
            TransactionStatus = ExternalPaymentTransactionStatus1Code.AcceptedSettlementInProcess,
            AcceptanceDateTime = Iso20022TestData.MessageCreationDateTime.AddMinutes(1),
        };

    // ── Examples ───────────────────────────────────────────────────────────────

    /// <summary>
    /// Positive acknowledgment: BNP Paribas confirms the pacs.008 has been
    /// accepted for processing (ACSP — Accepted Settlement In Process).
    /// </summary>
    [Fact]
    public void AcceptedStatus_ACSP_CanInstantiate()
    {
        var message = new FIToFIPaymentStatusReportV13
        {
            GroupHeader = CreateGroupHeader(),
            OriginalGroupInformationAndStatus = CreateOriginalGroupInfo(),
            TransactionInformationAndStatus = CreateAcceptedTransactionStatus(),
        };

        Assert.NotNull(message);
        Assert.Equal("pacs.002.001.13", FIToFIPaymentStatusReportV13.IsoIdentifier);
        Assert.Equal(
            ExternalPaymentTransactionStatus1Code.AcceptedSettlementInProcess,
            message.TransactionInformationAndStatus!.TransactionStatus
        );
    }

    /// <summary>
    /// Settlement completed: BNP Paribas confirms the funds have reached the
    /// creditor account (ACCC — Accepted Settlement Completed Creditor Account).
    /// </summary>
    [Fact]
    public void SettlementCompleted_ACCC_CanInstantiate()
    {
        var message = new FIToFIPaymentStatusReportV13
        {
            GroupHeader = CreateGroupHeader("BNPAFRPP/240315/PAC002/00002"),
            TransactionInformationAndStatus = CreateAcceptedTransactionStatus() with
            {
                TransactionStatus =
                    ExternalPaymentTransactionStatus1Code.AcceptedSettlementCompletedCreditorAccount,
                EffectiveInterbankSettlementDate = new Choices.DateAndDateTime2Choice.Date
                {
                    Value = Iso20022TestData.SettlementDate,
                },
            },
        };

        Assert.NotNull(message);
        Assert.Equal(
            ExternalPaymentTransactionStatus1Code.AcceptedSettlementCompletedCreditorAccount,
            message.TransactionInformationAndStatus!.TransactionStatus
        );
    }

    /// <summary>
    /// Rejection with a standard reason code — the <see cref="Code"/> variant of
    /// <see cref="StatusReason6Choice_"/>. AC04 = account closed.
    /// The creditor bank rejects because the account was closed.
    /// </summary>
    [Fact]
    public void Rejected_WithStatusReasonCode_StatusReason6ChoiceCodeVariant()
    {
        var message = new FIToFIPaymentStatusReportV13
        {
            GroupHeader = CreateGroupHeader("BNPAFRPP/240315/PAC002/00003"),
            TransactionInformationAndStatus = new PaymentTransaction142
            {
                OriginalEndToEndIdentification = Iso20022TestData.EndToEndId,
                OriginalUETR = Iso20022TestData.Uetr,
                TransactionStatus = ExternalPaymentTransactionStatus1Code.Rejected,
                StatusReasonInformation = [new StatusReasonInformation12
                {
                    Originator = Iso20022TestData.Creditor,
                    Reason = new Code { Value = ExternalStatusReason1Code.ClosedAccountNumber, },
                    AdditionalInformation =
                        ["Beneficiary account FR7630006000011234567890189 was closed on 2024-01-31."],
                }],
            },
        };

        Assert.NotNull(message);
        Assert.Equal(
            ExternalPaymentTransactionStatus1Code.Rejected,
            message.TransactionInformationAndStatus!.TransactionStatus
        );
        Assert.IsType<Code>(
            message.TransactionInformationAndStatus.StatusReasonInformation![0].Reason
        );
    }

    /// <summary>
    /// Rejection with a proprietary reason — the <see cref="Proprietary"/> variant
    /// of <see cref="StatusReason6Choice_"/>. Used when the rejection reason is
    /// scheme-specific or internal and has no standard ISO code mapping.
    /// </summary>
    [Fact]
    public void Rejected_WithProprietaryReason_StatusReason6ChoiceProprietaryVariant()
    {
        var message = new FIToFIPaymentStatusReportV13
        {
            GroupHeader = CreateGroupHeader("BNPAFRPP/240315/PAC002/00004"),
            TransactionInformationAndStatus = new PaymentTransaction142
            {
                OriginalEndToEndIdentification = Iso20022TestData.EndToEndId,
                OriginalUETR = Iso20022TestData.Uetr,
                TransactionStatus = ExternalPaymentTransactionStatus1Code.Rejected,
                StatusReasonInformation = [new StatusReasonInformation12
                {
                    Originator = Iso20022TestData.Creditor,
                    Reason = new Proprietary { Value = "BNPFR-SANCTION-SCREENING-HOLD", },
                    AdditionalInformation =
                        ["Transaction held pending compliance review per internal policy CP-2024-007."],
                }],
            },
        };

        Assert.NotNull(message);
        Assert.IsType<Proprietary>(
            message.TransactionInformationAndStatus!.StatusReasonInformation![0].Reason
        );
    }
}
