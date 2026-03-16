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
/// Realistic instantiation examples for <see cref="BankToCustomerStatementV11"/>
/// (camt.053.001.11 — Bank to Customer Statement).
///
/// camt.053 is the end-of-day account statement sent by a bank to its corporate
/// customer (or cash management system). It carries opening/closing balances and
/// all booked entries for a reporting period. Replaces MT 940.
///
/// Used in SWIFT CBPR+, SEPA, TARGET2, CHAPS, and virtually every corporate
/// treasury management workflow.
/// </summary>
public class Camt053ExamplesTests
{
    // ── Shared builders ────────────────────────────────────────────────────────

    public static GroupHeader81 CreateGroupHeader(string msgId = "DEUTDEFF/240315/CAM053/00001") =>
        new()
        {
            MessageIdentification = msgId,
            CreationDateTime = Iso20022TestData.MessageCreationDateTime.AddHours(18),
        };

    public static CashAccount41 CreateStatementAccount() =>
        new()
        {
            Identification = new IBAN { Value = "DE89370400440532013000" },
            Currency = Iso20022TestData.Currency,
            Name = "Acme Manufacturing GmbH Operating Account",
            Owner = Iso20022TestData.Debtor,
            Servicer = Iso20022TestData.DebtorAgent,
        };

    public static CashBalance8 CreateClosingBookedBalance(
        decimal amount = 952_750.00m,
        CreditDebitCode indicator = CreditDebitCode.Credit
    ) =>
        new()
        {
            Type = new BalanceType13
            {
                CodeOrProprietary = new Choices.BalanceType10Choice.Code
                {
                    Value = ExternalBalanceType1Code.ClosingBooked,
                },
            },
            Amount = new ActiveOrHistoricCurrencyAndAmount
            {
                Currency = Iso20022TestData.Currency,
                Amount = amount,
            },
            CreditDebitIndicator = indicator,
            Date = new Date { Value = Iso20022TestData.SettlementDate },
        };

    public static ReportEntry13 CreateCreditEntry(EntryStatus1Choice_? status = null) =>
        new()
        {
            Amount = new ActiveOrHistoricCurrencyAndAmount
            {
                Currency = Iso20022TestData.Currency,
                Amount = Iso20022TestData.Amount
            },
            CreditDebitIndicator = CreditDebitCode.Credit,
            Status = status ?? new Code { Value = ExternalEntryStatus1Code.Booked },
            BookingDate = new Date { Value = Iso20022TestData.SettlementDate },
            ValueDate = new Date { Value = Iso20022TestData.SettlementDate },
            AccountServicerReference = "BNPAFRPP20240315001234",
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
                        InstructionIdentification = Iso20022TestData.InstructionId,
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
    /// Minimal end-of-day statement with a closing booked balance.
    /// No entries — a zero-activity day report typical in treasury systems.
    /// </summary>
    [Fact]
    public void EndOfDayStatement_WithClosingBalance_CanInstantiate()
    {
        var message = new BankToCustomerStatementV11
        {
            GroupHeader = CreateGroupHeader(),
            Statement = new AccountStatement12
            {
                Identification = "DEUTDEFF-ACME-STMT-20240315-001",
                Account = CreateStatementAccount(),
                Balance =
                [
                    new()
                    {
                        Type = new BalanceType13
                        {
                            CodeOrProprietary = new Choices.BalanceType10Choice.Code
                            {
                                Value = ExternalBalanceType1Code.OpeningBooked,
                            },
                        },
                        Amount = new ActiveOrHistoricCurrencyAndAmount
                        {
                            Currency = Iso20022TestData.Currency,
                            Amount = 905_500.00m,
                        },
                        CreditDebitIndicator = CreditDebitCode.Credit,
                        Date = new Date { Value = Iso20022TestData.SettlementDate.AddDays(-1) },
                    },
                    CreateClosingBookedBalance(),
                ],
            },
        };

        Assert.NotNull(message);
        Assert.Equal("camt.053.001.11", BankToCustomerStatementV11.IsoIdentifier);
        Assert.Equal(2, message.Statement.Balance.Count);
    }

    /// <summary>
    /// Statement with a booked credit entry — <see cref="ExternalEntryStatus1Code.Booked"/>
    /// via the <see cref="Code"/> variant of <see cref="EntryStatus1Choice_"/>.
    /// Models the incoming EUR 47,250.00 credit from Acme's payment appearing on
    /// GlobalSupply's end-of-day account statement at BNP Paribas.
    /// </summary>
    [Fact]
    public void StatementWithBookedCreditEntry_EntryStatus1ChoiceCodeVariant()
    {
        var message = new BankToCustomerStatementV11
        {
            GroupHeader = CreateGroupHeader("BNPAFRPP/240315/CAM053/00001"),
            Statement = new AccountStatement12
            {
                Identification = "BNPAFRPP-GLOBALSUPPLY-STMT-20240315",
                Account = new CashAccount41
                {
                    Identification = new IBAN { Value = "FR7630006000011234567890189" },
                    Currency = Iso20022TestData.Currency,
                    Owner = Iso20022TestData.Creditor,
                    Servicer = Iso20022TestData.CreditorAgent,
                },
                Balance = [CreateClosingBookedBalance()],
                Entry = CreateCreditEntry(),
            },
        };

        Assert.NotNull(message);
        Assert.IsType<Code>(message.Statement.Entry!.Status);
        Assert.Equal(CreditDebitCode.Credit, message.Statement.Entry.CreditDebitIndicator);
    }

    /// <summary>
    /// Statement entry with a pending status — the <see cref="Code"/> variant with
    /// <see cref="ExternalEntryStatus1Code.Pending"/>. Models an intraday credit
    /// that has not yet been posted to the account ledger, typical in real-time
    /// gross settlement (RTGS) systems before end-of-day finalization.
    /// </summary>
    [Fact]
    public void StatementWithPendingEntry_EntryStatusPending()
    {
        var message = new BankToCustomerStatementV11
        {
            GroupHeader = CreateGroupHeader("BNPAFRPP/240315/CAM053/00002"),
            Statement = new AccountStatement12
            {
                Identification = "BNPAFRPP-GLOBALSUPPLY-STMT-20240315-INTRADAY",
                Account = new CashAccount41
                {
                    Identification = new IBAN { Value = "FR7630006000011234567890189" },
                    Currency = Iso20022TestData.Currency,
                },
                Entry = CreateCreditEntry(new Code { Value = ExternalEntryStatus1Code.Pending }),
            },
        };

        Assert.NotNull(message);
        var status = Assert.IsType<Code>(message.Statement.Entry!.Status);
        Assert.Equal(ExternalEntryStatus1Code.Pending, status.Value);
    }

    /// <summary>
    /// Statement entry with a proprietary status — the <see cref="Proprietary"/>
    /// variant of <see cref="EntryStatus1Choice_"/>. Used when the bank's core
    /// banking system uses internal status codes not mapped to ISO external codes.
    /// </summary>
    [Fact]
    public void StatementWithProprietaryEntryStatus_EntryStatus1ChoiceProprietaryVariant()
    {
        var message = new BankToCustomerStatementV11
        {
            GroupHeader = CreateGroupHeader("BNPAFRPP/240315/CAM053/00003"),
            Statement = new AccountStatement12
            {
                Identification = "BNPAFRPP-GLOBALSUPPLY-STMT-20240315-PROP",
                Account = new CashAccount41
                {
                    Identification = new IBAN { Value = "FR7630006000011234567890189" },
                    Currency = Iso20022TestData.Currency,
                },
                Entry = CreateCreditEntry(new Proprietary { Value = "BNPFR-PRE-BOOKED" }),
            },
        };

        Assert.NotNull(message);
        Assert.IsType<Proprietary>(message.Statement.Entry!.Status);
    }

    /// <summary>
    /// Debit entry — a charge or outgoing payment on Acme's account.
    /// Models Deutsche Bank debiting EUR 47,250.00 for the outgoing SEPA transfer.
    /// </summary>
    [Fact]
    public void StatementWithDebitEntry_CanInstantiate()
    {
        var debitEntry = new ReportEntry13
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
            AccountServicerReference = "DEUTDEFF20240315005678",
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
        };

        var message = new BankToCustomerStatementV11
        {
            GroupHeader = CreateGroupHeader(),
            Statement = new AccountStatement12
            {
                Identification = "DEUTDEFF-ACME-STMT-20240315-DEBIT",
                Account = CreateStatementAccount(),
                Balance = [CreateClosingBookedBalance()],
                Entry = debitEntry,
            },
        };

        Assert.NotNull(message);
        Assert.Equal(CreditDebitCode.Debit, message.Statement.Entry!.CreditDebitIndicator);
    }
}
