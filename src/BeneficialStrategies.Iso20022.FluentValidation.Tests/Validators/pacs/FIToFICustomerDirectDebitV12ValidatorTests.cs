// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pacs;

public class FIToFICustomerDirectDebitV12ValidatorTests
{
    private readonly FIToFICustomerDirectDebitV12Validator _sut = new();

    private static BranchAndFinancialInstitutionIdentification8 ValidAgent(string bic) =>
        new() { FinancialInstitutionIdentification = new FinancialInstitutionIdentification23 { BICFI = bic } };

    private static CashAccount40 ValidAccount(string id = "ACC-001") =>
        new() { Identification = new Choices.AccountIdentification4Choice.Other { Identification = id } };

    private static GroupHeader125 ValidGroupHeader() =>
        new()
        {
            MessageIdentification = "MSG-001",
            CreationDateTime = new DateTime(2026, 1, 1),
            NumberOfTransactions = "1",
            SettlementInformation = new SettlementInstruction14 { SettlementMethod = SettlementMethod2Code.ClearingSystem },
        };

    private static DirectDebitTransactionInformation35 ValidTransaction() =>
        new()
        {
            PaymentIdentification = new PaymentIdentification13 { EndToEndIdentification = "E2E-001" },
            InterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m },
            // GroupHeader carries no InterbankSettlementDate in these fixtures, so — per
            // TransactionInterbankSettlementDateRule — each transaction must carry its own.
            InterbankSettlementDate = new DateOnly(2026, 1, 1),
            ChargeBearer = ChargeBearerType1Code.Shared,
            Creditor = new PartyIdentification272(),
            CreditorAgent = ValidAgent("CHASUS33XXX"),
            Debtor = new PartyIdentification272(),
            DebtorAccount = ValidAccount(),
            DebtorAgent = ValidAgent("DEUTDEFFXXX"),
        };

    private static FIToFICustomerDirectDebitV12 ValidMessage() =>
        new() { GroupHeader = ValidGroupHeader(), DirectDebitTransactionInformation = [ValidTransaction()] };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── InstructedAgentRule / InstructingAgentRule ────────────────────────────────

    [Fact]
    public void GroupHeaderInstructedAgentPresent_TransactionInstructedAgentPresent_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader() with { InstructedAgent = ValidAgent("BOFAUS3NXXX") },
            DirectDebitTransactionInformation = [ValidTransaction() with { InstructedAgent = ValidAgent("BOFAUS3NXXX") }],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "InstructedAgentRule");
    }

    [Fact]
    public void GroupHeaderInstructingAgentPresent_TransactionInstructingAgentPresent_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader() with { InstructingAgent = ValidAgent("BOFAUS3NXXX") },
            DirectDebitTransactionInformation = [ValidTransaction() with { InstructingAgent = ValidAgent("BOFAUS3NXXX") }],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "InstructingAgentRule");
    }

    // ── TotalInterbankSettlementAmountRule / AndSumRule ──────────────────────────

    [Fact]
    public void TotalInterbankSettlementAmountCurrencyMismatch_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader() with
            {
                TotalInterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "USD", Amount = 100m },
            },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalInterbankSettlementAmountRule");
    }

    [Fact]
    public void TotalInterbankSettlementAmountSumMismatch_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader() with
            {
                TotalInterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 999m },
            },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalInterbankSettlementAmountAndSumRule");
    }

    [Fact]
    public void TotalInterbankSettlementAmountMatchesSumAndCurrency_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader() with
            {
                TotalInterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m },
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── GroupHeaderInterbankSettlementDateRule / TransactionInterbankSettlementDateRule ──

    [Fact]
    public void GroupHeaderInterbankSettlementDatePresent_TransactionAlsoPresent_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader() with { InterbankSettlementDate = new DateOnly(2026, 1, 1) },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupHeaderInterbankSettlementDateRule");
    }

    [Fact]
    public void GroupHeaderInterbankSettlementDateAbsent_TransactionAlsoAbsent_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            DirectDebitTransactionInformation = [ValidTransaction() with { InterbankSettlementDate = null }],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TransactionInterbankSettlementDateRule");
    }

    // ── PaymentTypeInformationRule ────────────────────────────────────────────────

    [Fact]
    public void GroupHeaderPaymentTypeInformationPresent_TransactionAlsoPresent_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader() with { PaymentTypeInformation = new PaymentTypeInformation27() },
            DirectDebitTransactionInformation = [ValidTransaction() with { PaymentTypeInformation = new PaymentTypeInformation27() }],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "PaymentTypeInformationRule");
    }

    [Fact]
    public void SupplementaryData_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            SupplementaryData = [new SupplementaryData1 { Envelope = new SupplementaryDataEnvelope1() }],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
