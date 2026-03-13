// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.AmountType4Choice;
using BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice;
using BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice;
using BeneficialStrategies.Iso20022.Choices.Purpose2Choice;
using BeneficialStrategies.Iso20022.pain;

namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// Realistic instantiation examples for <see cref="CustomerCreditTransferInitiationV11"/>
/// (pain.001.001.11 — Customer Credit Transfer Initiation).
///
/// pain.001 is sent by a corporate (or bank on behalf of a corporate) to its bank
/// to initiate one or more credit transfers. It replaces the legacy MT 101 and is
/// the entry point for every SEPA SCT, SEPA SCT Inst, and SWIFT CBPR+ payment
/// chain — ultimately resulting in a pacs.008 between financial institutions.
///
/// All examples share the same underlying scenario: Acme Manufacturing GmbH (DE)
/// instructing Deutsche Bank to pay GlobalSupply S.A.S. (FR) EUR 47,250.00 for
/// invoice INV-2024-847. The UETR threads into the downstream pacs.008.
/// </summary>
public class Pain001ExamplesTests
{
    // ── Shared builders ────────────────────────────────────────────────────────

    public static GroupHeader95 CreateGroupHeader(string msgId = "ACME/240315/PAI001/00001") => new()
    {
        MessageIdentification = msgId,
        CreationDateTime = Iso20022TestData.MessageCreationDateTime,
        NumberOfTransactions = "1",
        InitiatingParty = Iso20022TestData.Debtor,
    };

    public static PaymentInstruction40 CreatePaymentInstruction(
        CreditTransferTransaction54? txn = null) => new()
    {
        PaymentInformationIdentification = "ACME/240315/PMTINF/001",
        PaymentMethod = PaymentMethod3Code.CreditTransfer,
        RequestedExecutionDate = new Date { Value = Iso20022TestData.SettlementDate },
        Debtor = Iso20022TestData.Debtor,
        DebtorAccount = Iso20022TestData.DebtorAccount,
        DebtorAgent = Iso20022TestData.DebtorAgent,
        CreditTransferTransactionInformation =
        [
            txn ?? CreateCreditTransfer(),
        ],
    };

    public static CreditTransferTransaction54 CreateCreditTransfer(
        AmountType4Choice_? amount = null) => new()
    {
        PaymentIdentification = new PaymentIdentification6
        {
            InstructionIdentification = Iso20022TestData.InstructionId,
            EndToEndIdentification = Iso20022TestData.EndToEndId,
            UETR = Iso20022TestData.Uetr,
        },
        Amount = amount ?? new InstructedAmount
        {
            Currency = Iso20022TestData.Currency,
            Amount = Iso20022TestData.Amount,
        },
        ChargeBearer = ChargeBearerType1Code.Shared,
        CreditorAgent = Iso20022TestData.CreditorAgent,
        CreditorAccount = Iso20022TestData.CreditorAccount,
        Creditor = Iso20022TestData.Creditor,
    };

    // ── Examples ───────────────────────────────────────────────────────────────

    /// <summary>
    /// Standard SEPA credit transfer with instructed amount in EUR.
    /// The <see cref="InstructedAmount"/> variant of <see cref="AmountType4Choice_"/>
    /// is used when the originator specifies exactly how much should arrive at the
    /// creditor — the most common case for SEPA SCT.
    /// </summary>
    [Fact]
    public void StandardSepaTransfer_InstructedAmount_CanInstantiate()
    {
        var message = new CustomerCreditTransferInitiationV11
        {
            GroupHeader = CreateGroupHeader(),
            PaymentInformation = CreatePaymentInstruction(),
        };

        Assert.NotNull(message);
        Assert.Equal("pain.001.001.11", CustomerCreditTransferInitiationV11.IsoIdentifier);
        Assert.IsType<InstructedAmount>(
            message.PaymentInformation.CreditTransferTransactionInformation[0].Amount);
    }

    /// <summary>
    /// Cross-currency payment using the <see cref="EquivalentAmount"/> variant of
    /// <see cref="AmountType4Choice_"/>. Acme instructs Deutsche Bank to debit its
    /// USD account and deliver EUR 47,250.00 to GlobalSupply — the bank handles
    /// the FX conversion. Common for USD-to-EUR SWIFT CBPR+ payments.
    /// </summary>
    [Fact]
    public void CrossCurrencyTransfer_EquivalentAmount_AmountType4ChoiceVariant()
    {
        var message = new CustomerCreditTransferInitiationV11
        {
            GroupHeader = CreateGroupHeader("ACME/240315/PAI001/00002"),
            PaymentInformation = CreatePaymentInstruction(
                CreateCreditTransfer(new Choices.AmountType4Choice.EquivalentAmount
                {
                    Amount = new ActiveOrHistoricCurrencyAndAmount
                    {
                        Currency = Iso20022TestData.Currency,
                        Amount = Iso20022TestData.Amount,
                    },
                    CurrencyOfTransfer = "USD",
                })),
        };

        Assert.NotNull(message);
        Assert.IsType<Choices.AmountType4Choice.EquivalentAmount>(
            message.PaymentInformation.CreditTransferTransactionInformation[0].Amount);
    }

    /// <summary>
    /// Payment with a standard purpose code — the <see cref="Code"/> variant of
    /// <see cref="Purpose2Choice_"/>. SUPP = supplier payment.
    /// Purpose codes inform the creditor's bank how to book the credit, and are
    /// mandatory in many schemes (e.g., TARGET2, Czech CERTIS).
    /// </summary>
    [Fact]
    public void TransferWithPurposeCode_Purpose2ChoiceCodeVariant()
    {
        var message = new CustomerCreditTransferInitiationV11
        {
            GroupHeader = CreateGroupHeader("ACME/240315/PAI001/00003"),
            PaymentInformation = CreatePaymentInstruction(
                CreateCreditTransfer() with
                {
                    Purpose = new Choices.Purpose2Choice.Code
                    {
                        Value = ExternalPurpose1Code.SupplierPayment,
                    },
                    RemittanceInformation = new RemittanceInformation21
                    {
                        Unstructured = "INV-2024-847 EUR 47250.00 due 2024-03-15",
                    },
                }),
        };

        Assert.NotNull(message);
        Assert.IsType<Choices.Purpose2Choice.Code>(
            message.PaymentInformation.CreditTransferTransactionInformation[0].Purpose);
    }

    /// <summary>
    /// Payment with a proprietary purpose — the <see cref="Proprietary"/> variant of
    /// <see cref="Purpose2Choice_"/>. Used when the standard ISO purpose code list
    /// does not contain an applicable code (e.g., internal treasury transfers).
    /// </summary>
    [Fact]
    public void TransferWithProprietaryPurpose_Purpose2ChoiceProprietaryVariant()
    {
        var message = new CustomerCreditTransferInitiationV11
        {
            GroupHeader = CreateGroupHeader("ACME/240315/PAI001/00004"),
            PaymentInformation = CreatePaymentInstruction(
                CreateCreditTransfer() with
                {
                    Purpose = new Choices.Purpose2Choice.Proprietary
                    {
                        Value = "ACME-INTERCOMPANY-LOAN",
                    },
                }),
        };

        Assert.NotNull(message);
        Assert.IsType<Choices.Purpose2Choice.Proprietary>(
            message.PaymentInformation.CreditTransferTransactionInformation[0].Purpose);
    }

    /// <summary>
    /// Requested execution as a date-time rather than a date — the
    /// <see cref="Choices.DateAndDateTime2Choice.DateTime"/> variant of
    /// <see cref="DateAndDateTime2Choice_"/>. Used for SEPA SCT Inst (instant
    /// payments) where sub-second timing matters; the precise moment of submission
    /// is included rather than just a value date.
    /// </summary>
    [Fact]
    public void InstantPayment_RequestedExecutionDateTime_DateAndDateTime2ChoiceVariant()
    {
        var message = new CustomerCreditTransferInitiationV11
        {
            GroupHeader = CreateGroupHeader("ACME/240315/PAI001/00005"),
            PaymentInformation = CreatePaymentInstruction() with
            {
                PaymentInformationIdentification = "ACME/240315/PMTINF/002",
                RequestedExecutionDate = new Choices.DateAndDateTime2Choice.DateTime
                {
                    Value = Iso20022TestData.MessageCreationDateTime,
                },
                PaymentTypeInformation = new PaymentTypeInformation26
                {
                    ServiceLevel = new Choices.ServiceLevel8Choice.Code
                    {
                        Value = ExternalServiceLevel1Code.InstantCreditTransferOrInstantDirectDebit,
                    },
                    LocalInstrument = new Choices.LocalInstrument2Choice.Code
                    {
                        Value = ExternalLocalInstrument1Code.InstantCreditTransfer,
                    },
                },
            },
        };

        Assert.NotNull(message);
        Assert.IsType<Choices.DateAndDateTime2Choice.DateTime>(
            message.PaymentInformation.RequestedExecutionDate);
    }
}
