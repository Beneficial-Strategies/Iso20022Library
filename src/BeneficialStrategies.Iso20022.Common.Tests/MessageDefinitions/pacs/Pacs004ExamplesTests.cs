// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.ReturnReason5Choice;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.pacs;

namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// Realistic instantiation examples for <see cref="PaymentReturnV12"/>
/// (pacs.004.001.12 — Payment Return).
///
/// pacs.004 returns a previously settled payment back to the originating bank.
/// Required in every major scheme for error correction and recall resolution.
/// It follows a pacs.008 and may follow a camt.056 recall request.
///
/// Examples reference the original pacs.008 in <see cref="Pacs008ExamplesTests"/>.
/// </summary>
public class Pacs004ExamplesTests
{
    // ── Shared builders ────────────────────────────────────────────────────────

    public static GroupHeader99 CreateGroupHeader(string msgId = "BNPAFRPP/240316/PAC004/00001") =>
        new()
        {
            MessageIdentification = msgId,
            CreationDateTime = Iso20022TestData.MessageCreationDateTime.AddDays(1),
            NumberOfTransactions = "1",
            SettlementInformation = Iso20022TestData.ClearingSettlement,
            InstructingAgent = Iso20022TestData.CreditorAgent,
            InstructedAgent = Iso20022TestData.DebtorAgent,
        };

    public static PaymentTransaction146 CreateReturnTransaction(
        ActiveCurrencyAndAmount? returnAmount = null
    ) =>
        new()
        {
            ReturnIdentification = "BNPAFRPP/240316/RET/00001",
            OriginalEndToEndIdentification = Iso20022TestData.EndToEndId,
            OriginalUETR = Iso20022TestData.Uetr,
            OriginalInterbankSettlementAmount = new ActiveOrHistoricCurrencyAndAmount
            {
                Currency = Iso20022TestData.Currency,
                Amount = Iso20022TestData.Amount,
            },
            OriginalInterbankSettlementDate = Iso20022TestData.SettlementDate,
            ReturnedInterbankSettlementAmount = returnAmount ?? Iso20022TestData.InvoiceAmount,
            InterbankSettlementDate = Iso20022TestData.SettlementDate.AddDays(1),
            ChargeBearer = ChargeBearerType1Code.Shared,
            InstructingAgent = Iso20022TestData.CreditorAgent,
            InstructedAgent = Iso20022TestData.DebtorAgent,
        };

    // ── Examples ───────────────────────────────────────────────────────────────

    /// <summary>
    /// Return due to closed account — the <see cref="Code"/> variant of
    /// <see cref="ReturnReason5Choice_"/>. AC04 = account closed.
    /// BNP Paribas returns the full EUR 47,250.00 to Deutsche Bank the next day.
    /// </summary>
    [Fact]
    public void ReturnForClosedAccount_ReturnReason5ChoiceCodeVariant()
    {
        var message = new PaymentReturnV12
        {
            GroupHeader = CreateGroupHeader(),
            TransactionInformation = CreateReturnTransaction() with
            {
                ReturnReasonInformation = new PaymentReturnReason6
                {
                    Originator = Iso20022TestData.Creditor,
                    Reason = new Code { Value = ExternalReturnReason1Code.ClosedAccountNumber, },
                    AdditionalInformation =
                        "Account FR7630006000011234567890189 closed 2024-01-31. Return per SEPA SCT rulebook section 4.3.",
                },
            },
        };

        Assert.NotNull(message);
        Assert.Equal("pacs.004.001.12", PaymentReturnV12.IsoIdentifier);
        Assert.IsType<Code>(message.TransactionInformation!.ReturnReasonInformation!.Reason);
    }

    /// <summary>
    /// Return following a recall (camt.056): the creditor bank accepted the
    /// recall request and returns the funds with reason CUST (customer request).
    /// This represents the end of the cancel/recall lifecycle.
    /// </summary>
    [Fact]
    public void ReturnFollowingRecall_CustomerRequest()
    {
        var message = new PaymentReturnV12
        {
            GroupHeader = CreateGroupHeader("BNPAFRPP/240316/PAC004/00002"),
            OriginalGroupInformation = new OriginalGroupHeader18
            {
                OriginalMessageIdentification = Iso20022TestData.OriginalPacs008MsgId,
                OriginalMessageNameIdentification = "pacs.008.001.11",
                OriginalCreationDateTime = Iso20022TestData.MessageCreationDateTime,
            },
            TransactionInformation = CreateReturnTransaction() with
            {
                ReturnReasonInformation = new PaymentReturnReason6
                {
                    Originator = Iso20022TestData.Creditor,
                    Reason = new Code { Value = ExternalReturnReason1Code.RequestedByCustomer, },
                    AdditionalInformation =
                        "Return per recall request CAMT056-DEUTDEFF-240316-001 accepted by beneficiary.",
                },
            },
        };

        Assert.NotNull(message);
        Assert.IsType<Code>(message.TransactionInformation!.ReturnReasonInformation!.Reason);
    }

    /// <summary>
    /// Return with a proprietary reason code — the <see cref="Proprietary"/> variant
    /// of <see cref="ReturnReason5Choice_"/>. Used for scheme-specific or
    /// internal return reasons with no standard ISO mapping.
    /// </summary>
    [Fact]
    public void ReturnWithProprietaryReason_ReturnReason5ChoiceProprietaryVariant()
    {
        var message = new PaymentReturnV12
        {
            GroupHeader = CreateGroupHeader("BNPAFRPP/240316/PAC004/00003"),
            TransactionInformation = CreateReturnTransaction() with
            {
                ReturnReasonInformation = new PaymentReturnReason6
                {
                    Reason = new Proprietary { Value = "BNPFR-EXCEED-DAILY-LIMIT", },
                    AdditionalInformation =
                        "Beneficiary single-day receipt limit exceeded. Contact relationship manager.",
                },
            },
        };

        Assert.NotNull(message);
        Assert.IsType<Proprietary>(message.TransactionInformation!.ReturnReasonInformation!.Reason);
    }
}
