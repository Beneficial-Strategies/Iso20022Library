// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice;
using BeneficialStrategies.Iso20022.Choices.Party38Choice;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.pacs;

namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// Realistic instantiation examples for <see cref="FIToFICustomerCreditTransferV11"/>
/// (pacs.008.001.11 — FI-to-FI Customer Credit Transfer).
///
/// pacs.008 is the highest-volume ISO 20022 message globally, replacing the
/// legacy SWIFT MT 103. It is mandatory on SWIFT CBPR+, SEPA SCT, SEPA SCT Inst,
/// TARGET2, CHAPS, Fedwire, FedNow, and CHIPS.
///
/// All examples share the same scenario: Acme Manufacturing GmbH (DE) paying
/// GlobalSupply S.A.S. (FR) EUR 47,250.00 for invoice INV-2024-847.
/// The UETR <see cref="Iso20022TestData.Uetr"/> threads through the full chain
/// into pacs.002, pacs.004, and camt.056 examples.
/// </summary>
public class Pacs008ExamplesTests
{
    // ── Shared builders ────────────────────────────────────────────────────────

    public static GroupHeader96 CreateGroupHeader(
        string msgId = Iso20022TestData.OriginalPacs008MsgId
    ) =>
        new()
        {
            MessageIdentification = msgId,
            CreationDateTime = Iso20022TestData.MessageCreationDateTime,
            NumberOfTransactions = "1",
            SettlementInformation = Iso20022TestData.ClearingSettlement,
            InstructingAgent = Iso20022TestData.DebtorAgent,
            InstructedAgent = Iso20022TestData.CreditorAgent,
        };

    public static PaymentIdentification13 CreatePaymentIdentification() =>
        new()
        {
            InstructionIdentification = Iso20022TestData.InstructionId,
            EndToEndIdentification = Iso20022TestData.EndToEndId,
            UETR = Iso20022TestData.Uetr,
        };

    public static CreditTransferTransaction58 CreateCreditTransfer() =>
        new()
        {
            PaymentIdentification = CreatePaymentIdentification(),
            InterbankSettlementAmount = Iso20022TestData.InvoiceAmount,
            InterbankSettlementDate = Iso20022TestData.SettlementDate,
            ChargeBearer = ChargeBearerType1Code.Shared,
            Debtor = Iso20022TestData.Debtor,
            DebtorAccount = Iso20022TestData.DebtorAccount,
            DebtorAgent = Iso20022TestData.DebtorAgent,
            CreditorAgent = Iso20022TestData.CreditorAgent,
            CreditorAccount = Iso20022TestData.CreditorAccount,
            Creditor = Iso20022TestData.Creditor,
        };

    // ── Examples ───────────────────────────────────────────────────────────────

    /// <summary>
    /// Minimal valid pacs.008: standard SEPA/TARGET2 credit transfer
    /// using IBAN accounts and BIC-identified banks.
    /// </summary>
    [Fact]
    public void StandardSepaTransfer_CanInstantiate()
    {
        var message = new FIToFICustomerCreditTransferV11
        {
            GroupHeader = CreateGroupHeader(),
            CreditTransferTransactionInformation = CreateCreditTransfer(),
        };

        Assert.NotNull(message);
        Assert.Equal("pacs.008.001.11", FIToFICustomerCreditTransferV11.IsoIdentifier);
        Assert.Equal(
            Iso20022TestData.Uetr,
            message.CreditTransferTransactionInformation.PaymentIdentification.UETR
        );
    }

    /// <summary>
    /// Creditor identified by <see cref="OrganisationIdentification"/> (LEI) — one
    /// variant of the <see cref="Party38Choice_"/> polymorphic identification choice.
    /// Use this when the creditor is a corporate with a known Legal Entity Identifier.
    /// </summary>
    [Fact]
    public void CreditorIdentifiedByOrganisationId_Party38ChoiceVariant()
    {
        var creditorWithLei = Iso20022TestData.Creditor with
        {
            Identification = new OrganisationIdentification { LEI = "969500T3MBS4SQAMHJ45", },
        };

        var message = new FIToFICustomerCreditTransferV11
        {
            GroupHeader = CreateGroupHeader(),
            CreditTransferTransactionInformation = CreateCreditTransfer() with
            {
                Creditor = creditorWithLei,
            },
        };

        Assert.NotNull(message);
        Assert.IsType<OrganisationIdentification>(
            message.CreditTransferTransactionInformation.Creditor!.Identification
        );
    }

    /// <summary>
    /// Debtor account identified by a proprietary scheme — the <see cref="Other"/>
    /// variant of <see cref="AccountIdentification4Choice_"/>.
    /// Used when the account number is not an IBAN (e.g., US domestic routing).
    /// </summary>
    [Fact]
    public void DebtorAccount_OtherIdentification_AccountChoice_OtherVariant()
    {
        var nonIbanAccount = new CashAccount40
        {
            Identification = new Other
            {
                Identification = "021000021-987654321", // ABA + account number
                SchemeName = new Choices.AccountSchemeName1Choice.Proprietary { Value = "USABA", },
            },
            Currency = "USD",
            Name = "Acme Operating Account",
        };

        var message = new FIToFICustomerCreditTransferV11
        {
            GroupHeader = CreateGroupHeader(),
            CreditTransferTransactionInformation = CreateCreditTransfer() with
            {
                DebtorAccount = nonIbanAccount,
            },
        };

        Assert.NotNull(message);
        Assert.IsType<Other>(
            message.CreditTransferTransactionInformation.DebtorAccount!.Identification
        );
    }

    /// <summary>
    /// Cover payment (COVE settlement method): Deutsche Bank instructs JPMorgan
    /// to cover the USD leg while the EUR leg is settled separately.
    /// Common in cross-currency SWIFT CBPR+ transactions.
    /// </summary>
    [Fact]
    public void CoverPayment_CoveSettlementMethod()
    {
        var coverGroupHeader = CreateGroupHeader("DEUTDEFF/240315/COV008/00001") with
        {
            SettlementInformation = Iso20022TestData.CoverSettlement,
        };

        var message = new FIToFICustomerCreditTransferV11
        {
            GroupHeader = coverGroupHeader,
            CreditTransferTransactionInformation = CreateCreditTransfer() with
            {
                IntermediaryAgent1 = Iso20022TestData.CorrespondentAgent,
            },
        };

        Assert.NotNull(message);
        Assert.Equal(
            SettlementMethod1Code.CoverMethod,
            message.GroupHeader.SettlementInformation.SettlementMethod
        );
    }
}
