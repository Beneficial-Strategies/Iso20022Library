// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.camt;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice;
using BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice;
using BeneficialStrategies.Iso20022.Choices.EntryStatus1Choice;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Realistic instantiation examples for <see cref="BankToCustomerDebitCreditNotificationV11"/>
/// (camt.054.001.11 — Bank to Customer Debit Credit Notification).
///
/// camt.054 is an intraday notification sent by a bank to its corporate customer
/// immediately upon crediting or debiting their account. It triggers real-time
/// treasury and ERP reconciliation workflows. Replaces MT 900 (debit) / MT 910 (credit).
///
/// Unlike camt.053 (end-of-day statement), camt.054 is event-driven: one notification
/// per entry or per batch, typically sent within seconds of settlement.
/// </summary>
public class Camt054ExamplesTests
{
    // ── Shared builders ────────────────────────────────────────────────────────

    public static GroupHeader81 CreateGroupHeader(string msgId = "BNPAFRPP/240315/CAM054/00001") =>
        new()
        {
            MessageIdentification = msgId,
            CreationDateTime = Iso20022TestData.MessageCreationDateTime.AddMinutes(5),
            MessageRecipient = Iso20022TestData.Creditor,
        };

    public static CashAccount41 CreateNotificationAccount() =>
        new()
        {
            Identification = new IBAN { Value = "FR7630006000011234567890189" },
            Currency = Iso20022TestData.Currency,
            Name = "GlobalSupply S.A.S. Current Account",
            Owner = Iso20022TestData.Creditor,
            Servicer = Iso20022TestData.CreditorAgent,
        };

    public static ReportEntry13 CreateIncomingCreditEntry() =>
        new()
        {
            Amount = new ActiveOrHistoricCurrencyAndAmount
            {
                Currency = Iso20022TestData.Currency,
                Amount = Iso20022TestData.Amount
            },
            CreditDebitIndicator = CreditDebitCode.Credit,
            Status = new Code { Value = ExternalEntryStatus1Code.Booked },
            BookingDate = new Date { Value = Iso20022TestData.SettlementDate },
            ValueDate = new Date { Value = Iso20022TestData.SettlementDate },
            AccountServicerReference = "BNPAFRPP20240315CR001234",
            BankTransactionCode = new BankTransactionCodeStructure4
            {
                Domain = new BankTransactionCodeStructure5
                {
                    Code = "PMNT",
                    Family = new BankTransactionCodeStructure6
                    {
                        Code = "RCDT", // Received Credit Transfer
                        SubFamilyCode = "ESCT", // SEPA Credit Transfer
                    },
                },
            },
            EntryDetails = new EntryDetails12
            {
                TransactionDetails = new EntryTransaction13
                {
                    References = new TransactionReferences6
                    {
                        EndToEndIdentification = Iso20022TestData.EndToEndId,
                        UETR = Iso20022TestData.Uetr,
                    },
                    RemittanceInformation = new RemittanceInformation21
                    {
                        Unstructured = "INV-2024-847 EUR 47250.00",
                    },
                    RelatedParties = new TransactionParties9
                    {
                        Debtor = new Choices.Party40Choice.Party
                        {
                            Name = Iso20022TestData.Debtor.Name
                        },
                        DebtorAccount = Iso20022TestData.DebtorAccount,
                    },
                },
            },
        };

    // ── Examples ───────────────────────────────────────────────────────────────

    /// <summary>
    /// Intraday credit notification: BNP Paribas notifies GlobalSupply that
    /// EUR 47,250.00 has been credited to their account. Status is Booked via
    /// the <see cref="Code"/> variant of <see cref="EntryStatus1Choice_"/>.
    /// This is the most common real-world camt.054 use case.
    /// </summary>
    [Fact]
    public void CreditNotification_BookedStatus_EntryStatus1ChoiceCodeVariant()
    {
        var message = new BankToCustomerDebitCreditNotificationV11
        {
            GroupHeader = CreateGroupHeader(),
            Notification = new AccountNotification21
            {
                Identification = "BNPAFRPP-GLOBALSUPPLY-NTFN-20240315-001",
                Account = CreateNotificationAccount(),
                Entry = CreateIncomingCreditEntry(),
            },
        };

        Assert.NotNull(message);
        Assert.Equal("camt.054.001.11", BankToCustomerDebitCreditNotificationV11.IsoIdentifier);
        Assert.Equal(CreditDebitCode.Credit, message.Notification.Entry!.CreditDebitIndicator);
        Assert.IsType<Code>(message.Notification.Entry.Status);
    }

    /// <summary>
    /// Debit notification: Deutsche Bank notifies Acme Manufacturing that
    /// EUR 47,250.00 has been debited from their account for the outgoing SEPA transfer.
    /// Models the MT 900 replacement in corporate cash management.
    /// </summary>
    [Fact]
    public void DebitNotification_OutgoingSepaTransfer_CanInstantiate()
    {
        var message = new BankToCustomerDebitCreditNotificationV11
        {
            GroupHeader = new GroupHeader81
            {
                MessageIdentification = "DEUTDEFF/240315/CAM054/00001",
                CreationDateTime = Iso20022TestData.MessageCreationDateTime.AddMinutes(5),
                MessageRecipient = Iso20022TestData.Debtor,
            },
            Notification = new AccountNotification21
            {
                Identification = "DEUTDEFF-ACME-NTFN-20240315-001",
                Account = new CashAccount41
                {
                    Identification = new IBAN { Value = "DE89370400440532013000" },
                    Currency = Iso20022TestData.Currency,
                    Owner = Iso20022TestData.Debtor,
                    Servicer = Iso20022TestData.DebtorAgent,
                },
                Entry = new ReportEntry13
                {
                    Amount = new ActiveOrHistoricCurrencyAndAmount
                    {
                        Currency = Iso20022TestData.Currency,
                        Amount = Iso20022TestData.Amount
                    },
                    CreditDebitIndicator = CreditDebitCode.Debit,
                    Status = new Code { Value = ExternalEntryStatus1Code.Booked },
                    BookingDate = new Date { Value = Iso20022TestData.SettlementDate },
                    ValueDate = new Date { Value = Iso20022TestData.SettlementDate },
                    AccountServicerReference = "DEUTDEFF20240315DB005678",
                    BankTransactionCode = new BankTransactionCodeStructure4
                    {
                        Domain = new BankTransactionCodeStructure5
                        {
                            Code = "PMNT",
                            Family = new BankTransactionCodeStructure6
                            {
                                Code = "ICDT", // Issued Credit Transfer
                                SubFamilyCode = "ESCT", // SEPA Credit Transfer
                            },
                        },
                    },
                    EntryDetails = new EntryDetails12
                    {
                        TransactionDetails = new EntryTransaction13
                        {
                            References = new TransactionReferences6
                            {
                                EndToEndIdentification = Iso20022TestData.EndToEndId,
                                UETR = Iso20022TestData.Uetr,
                            },
                            RelatedParties = new TransactionParties9
                            {
                                Creditor = new Choices.Party40Choice.Party
                                {
                                    Name = Iso20022TestData.Creditor.Name
                                },
                                CreditorAccount = Iso20022TestData.CreditorAccount,
                            },
                        },
                    },
                },
            },
        };

        Assert.NotNull(message);
        Assert.Equal(CreditDebitCode.Debit, message.Notification.Entry!.CreditDebitIndicator);
    }

    /// <summary>
    /// Notification with a pending entry — <see cref="ExternalEntryStatus1Code.Pending"/>
    /// via the <see cref="Code"/> variant. Sent for SEPA SCT Inst (instant payments)
    /// where the bank notifies the corporate immediately upon receiving the payment
    /// instruction, before final book-posting (typically sub-10-second cycle).
    /// </summary>
    [Fact]
    public void CreditNotification_PendingInstantPayment_CanInstantiate()
    {
        var message = new BankToCustomerDebitCreditNotificationV11
        {
            GroupHeader = CreateGroupHeader("BNPAFRPP/240315/CAM054/00002"),
            Notification = new AccountNotification21
            {
                Identification = "BNPAFRPP-GLOBALSUPPLY-NTFN-20240315-INST",
                Account = CreateNotificationAccount(),
                Entry = CreateIncomingCreditEntry() with
                {
                    Status = new Code { Value = ExternalEntryStatus1Code.Pending },
                },
            },
        };

        Assert.NotNull(message);
        var status = Assert.IsType<Code>(message.Notification.Entry!.Status);
        Assert.Equal(ExternalEntryStatus1Code.Pending, status.Value);
    }

    /// <summary>
    /// Notification with a proprietary entry status — the <see cref="Proprietary"/>
    /// variant of <see cref="EntryStatus1Choice_"/>. Models a bank that uses
    /// internal staging codes before final ISO status assignment.
    /// </summary>
    [Fact]
    public void CreditNotification_ProprietaryEntryStatus_EntryStatus1ChoiceProprietaryVariant()
    {
        var message = new BankToCustomerDebitCreditNotificationV11
        {
            GroupHeader = CreateGroupHeader("BNPAFRPP/240315/CAM054/00003"),
            Notification = new AccountNotification21
            {
                Identification = "BNPAFRPP-GLOBALSUPPLY-NTFN-20240315-PROP",
                Account = CreateNotificationAccount(),
                Entry = CreateIncomingCreditEntry() with
                {
                    Status = new Proprietary { Value = "BNPFR-CREDITING" },
                },
            },
        };

        Assert.NotNull(message);
        Assert.IsType<Proprietary>(message.Notification.Entry!.Status);
    }
}
