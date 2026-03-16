// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.camt;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.CancellationReason33Choice;
using BeneficialStrategies.Iso20022.Choices.Party40Choice;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Realistic instantiation examples for <see cref="FIToFIPaymentCancellationRequestV10"/>
/// (camt.056.001.10 — FI-to-FI Payment Cancellation Request).
///
/// camt.056 initiates the recall or cancellation of an in-flight or settled
/// payment. It is central to the SWIFT gpi recall workflow, SEPA's recall scheme,
/// and CHAPS exception handling.
///
/// A successful cancellation results in a pacs.004 return (see Pacs004ExamplesTests).
/// </summary>
public class Camt056ExamplesTests
{
    private const string CancellationId = "DEUTDEFF/240316/CAMT056/00001";
    private const string CaseId = "CASE-DEUTDEFF-20240316-001";

    // ── Shared builders ────────────────────────────────────────────────────────

    public static CaseAssignment5 CreateCaseAssignment() =>
        new()
        {
            Identification = CancellationId,
            Assigner = new Agent
            {
                FinancialInstitutionIdentification = Iso20022TestData
                    .DebtorAgent
                    .FinancialInstitutionIdentification,
            },
            Assignee = new Agent
            {
                FinancialInstitutionIdentification = Iso20022TestData
                    .CreditorAgent
                    .FinancialInstitutionIdentification,
            },
            CreationDateTime = Iso20022TestData.MessageCreationDateTime.AddDays(1),
        };

    public static Case5 CreateCase() =>
        new()
        {
            Identification = CaseId,
            Creator = new Agent
            {
                FinancialInstitutionIdentification = Iso20022TestData
                    .DebtorAgent
                    .FinancialInstitutionIdentification,
            },
        };

    public static PaymentTransaction137 CreateTransactionCancellation(
        CancellationReason33Choice_? reason = null
    ) =>
        new()
        {
            CancellationIdentification = CancellationId,
            OriginalEndToEndIdentification = Iso20022TestData.EndToEndId,
            OriginalUETR = Iso20022TestData.Uetr,
            OriginalInstructionIdentification = Iso20022TestData.InstructionId,
            OriginalInterbankSettlementAmount = new ActiveOrHistoricCurrencyAndAmount
            {
                Currency = Iso20022TestData.Currency,
                Amount = Iso20022TestData.Amount,
            },
            OriginalInterbankSettlementDate = Iso20022TestData.SettlementDate,
            CancellationReasonInformation = new PaymentCancellationReason5
            {
                Originator = Iso20022TestData.Debtor,
                Reason =
                    reason
                    ?? new Code { Value = ExternalCancellationReason1Code.RequestedByCustomer, },
            },
        };

    // ── Examples ───────────────────────────────────────────────────────────────

    /// <summary>
    /// Transaction-level cancellation with standard reason code CUST (customer request).
    /// Acme Manufacturing asks Deutsche Bank to recall the payment to GlobalSupply.
    /// This is the most common cancellation scenario in SEPA and SWIFT gpi.
    /// </summary>
    [Fact]
    public void TransactionCancellation_CustomerRequest_CancellationReasonCodeVariant()
    {
        var message = new FIToFIPaymentCancellationRequestV10
        {
            Assignment = CreateCaseAssignment(),
            Case = CreateCase(),
            Underlying = new UnderlyingTransaction28
            {
                TransactionInformation = CreateTransactionCancellation(
                    new Code { Value = ExternalCancellationReason1Code.RequestedByCustomer }
                ),
            },
        };

        Assert.NotNull(message);
        Assert.Equal("camt.056.001.10", FIToFIPaymentCancellationRequestV10.IsoIdentifier);
        Assert.IsType<Code>(
            message.Underlying.TransactionInformation!.CancellationReasonInformation!.Reason
        );
    }

    /// <summary>
    /// Cancellation due to duplicate payment — DUPL code.
    /// The debtor's system accidentally submitted the same payment twice;
    /// the second instance is recalled.
    /// </summary>
    [Fact]
    public void TransactionCancellation_DuplicatePayment_DuplCode()
    {
        var message = new FIToFIPaymentCancellationRequestV10
        {
            Assignment = CreateCaseAssignment() with
            {
                Identification = "DEUTDEFF/240316/CAMT056/00002",
            },
            Case = CreateCase() with { Identification = "CASE-DEUTDEFF-20240316-002", },
            Underlying = new UnderlyingTransaction28
            {
                TransactionInformation = CreateTransactionCancellation(
                    new Code { Value = ExternalCancellationReason1Code.DuplicatePayment }
                ) with
                {
                    CancellationIdentification = "DEUTDEFF/240316/CAMT056/00002",
                    CancellationReasonInformation = new PaymentCancellationReason5
                    {
                        Reason = new Code
                        {
                            Value = ExternalCancellationReason1Code.DuplicatePayment
                        },
                        AdditionalInformation =
                            "Duplicate of UETR 97ed4827-7b6f-4491-a06f-b548d5a7512d. Original sent at 08:30 UTC; duplicate submitted at 08:31 UTC.",
                    },
                },
            },
        };

        Assert.NotNull(message);
        var reason = (Code)
            message.Underlying.TransactionInformation!.CancellationReasonInformation!.Reason!;
        Assert.Equal(ExternalCancellationReason1Code.DuplicatePayment, reason.Value);
    }

    /// <summary>
    /// Cancellation with a proprietary reason — the <see cref="Proprietary"/> variant
    /// of <see cref="CancellationReason33Choice_"/>. Used when no standard ISO code
    /// applies, such as an internal fraud-hold reason.
    /// </summary>
    [Fact]
    public void TransactionCancellation_ProprietaryReason_CancellationReasonProprietaryVariant()
    {
        var message = new FIToFIPaymentCancellationRequestV10
        {
            Assignment = CreateCaseAssignment() with
            {
                Identification = "DEUTDEFF/240316/CAMT056/00003",
            },
            Case = CreateCase() with { Identification = "CASE-DEUTDEFF-20240316-003", },
            Underlying = new UnderlyingTransaction28
            {
                TransactionInformation = CreateTransactionCancellation(
                    new Proprietary { Value = "DEUTDE-AML-FREEZE-REF-2024-03-16-0042", }
                ) with
                {
                    CancellationIdentification = "DEUTDEFF/240316/CAMT056/00003",
                },
            },
        };

        Assert.NotNull(message);
        Assert.IsType<Proprietary>(
            message.Underlying.TransactionInformation!.CancellationReasonInformation!.Reason
        );
    }

    /// <summary>
    /// Group-level cancellation: cancel all transactions in the original pacs.008
    /// message group rather than a single transaction.
    /// </summary>
    [Fact]
    public void GroupCancellation_CanInstantiate()
    {
        var message = new FIToFIPaymentCancellationRequestV10
        {
            Assignment = CreateCaseAssignment() with
            {
                Identification = "DEUTDEFF/240316/CAMT056/00004",
            },
            ControlData = new ControlData1
            {
                NumberOfTransactions = "3",
                ControlSum = 141_750UL, // 3 × EUR 47,250.00
            },
            Underlying = new UnderlyingTransaction28
            {
                OriginalGroupInformationAndCancellation = new OriginalGroupHeader15
                {
                    OriginalMessageIdentification = Iso20022TestData.OriginalPacs008MsgId,
                    OriginalMessageNameIdentification = "pacs.008.001.11",
                    OriginalCreationDateTime = Iso20022TestData.MessageCreationDateTime,
                    GroupCancellation = "true",
                    CancellationReasonInformation = new PaymentCancellationReason5
                    {
                        Reason = new Code
                        {
                            Value = ExternalCancellationReason1Code.RequestedByCustomer
                        },
                        AdditionalInformation =
                            "Customer requested cancellation of all payments in batch DEUTDEFF/240315/PAC008/00001.",
                    },
                },
            },
        };

        Assert.NotNull(message);
        Assert.NotNull(message.Underlying.OriginalGroupInformationAndCancellation);
        Assert.Equal("3", message.ControlData!.NumberOfTransactions);
    }

    /// <summary>
    /// Case assigner and assignee identified as parties (not agents) — the
    /// <see cref="Party"/> variant of <see cref="Party40Choice_"/>.
    /// Used when the initiating party is a corporate, not a financial institution.
    /// </summary>
    [Fact]
    public void CaseAssignment_WithPartyIdentification_Party40ChoicePartyVariant()
    {
        var corporateAssigner = new Party
        {
            Name = "Acme Manufacturing GmbH",
            PostalAddress = Iso20022TestData.Debtor.PostalAddress,
        };

        var message = new FIToFIPaymentCancellationRequestV10
        {
            Assignment = new CaseAssignment5
            {
                Identification = "ACME/240316/CAMT056/00001",
                Assigner = corporateAssigner,
                Assignee = new Agent
                {
                    FinancialInstitutionIdentification = Iso20022TestData
                        .DebtorAgent
                        .FinancialInstitutionIdentification,
                },
                CreationDateTime = Iso20022TestData.MessageCreationDateTime.AddDays(1),
            },
            Underlying = new UnderlyingTransaction28
            {
                TransactionInformation = CreateTransactionCancellation(),
            },
        };

        Assert.NotNull(message);
        Assert.IsType<Party>(message.Assignment.Assigner);
        Assert.IsType<Agent>(message.Assignment.Assignee);
    }
}
