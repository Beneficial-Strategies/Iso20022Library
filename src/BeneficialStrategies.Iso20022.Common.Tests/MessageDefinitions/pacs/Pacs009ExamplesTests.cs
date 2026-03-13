// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice;
using BeneficialStrategies.Iso20022.pacs;

namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// Realistic instantiation examples for <see cref="FinancialInstitutionCreditTransferV10"/>
/// (pacs.009.001.10 — Financial Institution Credit Transfer).
///
/// pacs.009 replaces MT 202 / MT 205 for bank-to-bank transfers without an
/// underlying customer payment (liquidity management, cover payments, etc.).
/// Mandatory on SWIFT CBPR+, TARGET2, CHAPS, Fedwire, and CHIPS.
/// </summary>
public class Pacs009ExamplesTests
{
    // ── Shared builders ────────────────────────────────────────────────────────

    public static GroupHeader96 CreateGroupHeader(string msgId = "DEUTDEFF/240315/PAC009/00001") => new()
    {
        MessageIdentification = msgId,
        CreationDateTime = Iso20022TestData.MessageCreationDateTime,
        NumberOfTransactions = "1",
        SettlementInformation = Iso20022TestData.ClearingSettlement,
        InstructingAgent = Iso20022TestData.DebtorAgent,
        InstructedAgent = Iso20022TestData.CreditorAgent,
    };

    public static CreditTransferTransaction56 CreateFiTransfer() => new()
    {
        PaymentIdentification = new PaymentIdentification13
        {
            InstructionIdentification = "DEUTDEFF/240315/FI009/00001",
            EndToEndIdentification = "NOSTRO-REBAL-20240315-001",
            UETR = "a3c8e91f-2b4d-4f67-8e9a-bc1234567890",
        },
        InterbankSettlementAmount = new ActiveCurrencyAndAmount
        {
            Currency = "EUR",
            Amount = 5_000_000.00m,
        },
        InterbankSettlementDate = Iso20022TestData.SettlementDate,
        Debtor = Iso20022TestData.DebtorAgent,
        Creditor = Iso20022TestData.CreditorAgent,
    };

    // ── Examples ───────────────────────────────────────────────────────────────

    /// <summary>
    /// Nostro account rebalancing: Deutsche Bank moves EUR 5M to its BNP Paribas
    /// nostro account for liquidity management. No underlying customer payment.
    /// </summary>
    [Fact]
    public void NostroRebalancing_CanInstantiate()
    {
        var message = new FinancialInstitutionCreditTransferV10
        {
            GroupHeader = CreateGroupHeader(),
            CreditTransferTransactionInformation = CreateFiTransfer() with
            {
                DebtorAccount = new CashAccount40
                {
                    Identification = new IBAN { Value = "DE89370400440532013000" },
                    Name = "Deutsche Bank EUR Nostro",
                },
                CreditorAccount = new CashAccount40
                {
                    Identification = new IBAN { Value = "FR7630006000011234567890189" },
                    Name = "BNP Paribas EUR Nostro",
                },
            },
        };

        Assert.NotNull(message);
        Assert.Equal("pacs.009.001.10", FinancialInstitutionCreditTransferV10.IsoIdentifier);
    }

    /// <summary>
    /// Cover payment: Deutsche Bank sends a USD cover to JPMorgan Chase to fund
    /// the USD leg of a cross-currency customer payment (pacs.008 COVE settlement).
    /// The <see cref="CreditTransferTransaction56.UnderlyingCustomerCreditTransfer"/>
    /// references the associated pacs.008 transaction.
    /// </summary>
    [Fact]
    public void CoverPaymentForCrossCurrencyTransfer_CanInstantiate()
    {
        var message = new FinancialInstitutionCreditTransferV10
        {
            GroupHeader = CreateGroupHeader("DEUTDEFF/240315/COV009/00001") with
            {
                SettlementInformation = Iso20022TestData.CoverSettlement,
                InstructingAgent = Iso20022TestData.DebtorAgent,
                InstructedAgent = Iso20022TestData.CorrespondentAgent,
            },
            CreditTransferTransactionInformation = new CreditTransferTransaction56
            {
                PaymentIdentification = new PaymentIdentification13
                {
                    InstructionIdentification = "DEUTDEFF/240315/COV009/00001",
                    EndToEndIdentification = Iso20022TestData.EndToEndId,
                    UETR = Iso20022TestData.Uetr,
                },
                InterbankSettlementAmount = new ActiveCurrencyAndAmount
                {
                    Currency = "USD",
                    Amount = 51_300.00m,   // USD equivalent at spot rate
                },
                InterbankSettlementDate = Iso20022TestData.SettlementDate,
                Debtor = Iso20022TestData.DebtorAgent,
                Creditor = Iso20022TestData.CorrespondentAgent,
            },
        };

        Assert.NotNull(message);
        Assert.Equal(SettlementMethod1Code.CoverMethod,
            message.GroupHeader.SettlementInformation.SettlementMethod);
    }

    /// <summary>
    /// FI transfer with a clearing system member identification — using
    /// <see cref="ClearingSystemMemberIdentification2"/> instead of BIC.
    /// Common for domestic systems like CHIPS (US) or CHAPS (UK).
    /// </summary>
    [Fact]
    public void FiTransferWithClearingSystemMemberId_CanInstantiate()
    {
        var chipsAgent = new BranchAndFinancialInstitutionIdentification6
        {
            FinancialInstitutionIdentification = new FinancialInstitutionIdentification18
            {
                ClearingSystemMemberIdentification = new ClearingSystemMemberIdentification2
                {
                    MemberIdentification = "0002",  // JPMorgan CHIPS UID
                },
            },
        };

        var message = new FinancialInstitutionCreditTransferV10
        {
            GroupHeader = CreateGroupHeader("CHASUS33/240315/PAC009/00001") with
            {
                SettlementInformation = new SettlementInstruction11
                {
                    SettlementMethod = SettlementMethod1Code.ClearingSystem,
                },
                InstructingAgent = chipsAgent,
                InstructedAgent = Iso20022TestData.CorrespondentAgent,
            },
            CreditTransferTransactionInformation = CreateFiTransfer() with
            {
                Debtor = chipsAgent,
                Creditor = Iso20022TestData.CorrespondentAgent,
            },
        };

        Assert.NotNull(message);
        Assert.NotNull(message.CreditTransferTransactionInformation.Debtor
            .FinancialInstitutionIdentification.ClearingSystemMemberIdentification);
    }
}
