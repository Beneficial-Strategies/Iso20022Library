// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CreditTransferTransaction66ValidatorTests
{
    private readonly CreditTransferTransaction66Validator _sut = new();

    private static BranchAndFinancialInstitutionIdentification8 ValidAgent(string bic) =>
        new() { FinancialInstitutionIdentification = new FinancialInstitutionIdentification23 { BICFI = bic } };

    private static DirectDebitTransactionInformation33 ValidDirectDebitTransactionInformation() =>
        new()
        {
            PaymentIdentification = new PaymentIdentification13 { EndToEndIdentification = "E2E-001" },
            Debtor = ValidAgent("DEUTDEFFXXX"),
            InterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m },
        };

    private static CreditTransferTransaction66 ValidMessage() =>
        new()
        {
            CreditIdentification = "CDT-001",
            Creditor = ValidAgent("BOFAUS3NXXX"),
            DirectDebitTransactionInformation = [ValidDirectDebitTransactionInformation()],
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── DirectDebitTransactionInformation minimum-count (1..∞) ───────────────────

    [Fact]
    public void DirectDebitTransactionInformation_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { DirectDebitTransactionInformation = [] };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "DirectDebitTransactionInformation");
    }

    // ── TotalInterbankSettlementAmount ────────────────────────────────────────────

    [Fact]
    public void TotalInterbankSettlementAmount_InvalidCurrency_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            TotalInterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "EU", Amount = 100m },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalInterbankSettlementAmount.Currency");
    }

    [Fact]
    public void TotalInterbankSettlementAmount_ZeroAmount_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            TotalInterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 0m },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalInterbankSettlementAmount.Amount");
    }

    [Fact]
    public void TotalInterbankSettlementAmount_Valid_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            TotalInterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── Optional agent/account building blocks ───────────────────────────────────

    [Theory]
    [InlineData("CreditorAgent")]
    [InlineData("CreditorAgentAccount")]
    [InlineData("CreditorAccount")]
    [InlineData("UltimateCreditor")]
    [InlineData("InstructingAgent")]
    [InlineData("InstructedAgent")]
    [InlineData("IntermediaryAgent1")]
    [InlineData("IntermediaryAgent1Account")]
    [InlineData("IntermediaryAgent2")]
    [InlineData("IntermediaryAgent2Account")]
    [InlineData("IntermediaryAgent3")]
    [InlineData("IntermediaryAgent3Account")]
    public void OptionalAgentOrAccountFields_Present_NoValidationErrors(string fieldName)
    {
        var msg = fieldName switch
        {
            "CreditorAgent" => ValidMessage() with { CreditorAgent = ValidAgent("CHASUS33XXX") },
            "CreditorAgentAccount" => ValidMessage() with { CreditorAgentAccount = ValidIban() },
            "CreditorAccount" => ValidMessage() with { CreditorAccount = ValidIban() },
            "UltimateCreditor" => ValidMessage() with { UltimateCreditor = ValidAgent("CHASUS33XXX") },
            "InstructingAgent" => ValidMessage() with { InstructingAgent = ValidAgent("CHASUS33XXX") },
            "InstructedAgent" => ValidMessage() with { InstructedAgent = ValidAgent("CHASUS33XXX") },
            "IntermediaryAgent1" => ValidMessage() with { IntermediaryAgent1 = ValidAgent("CHASUS33XXX") },
            "IntermediaryAgent1Account" => ValidMessage() with { IntermediaryAgent1Account = ValidIban() },
            "IntermediaryAgent2" => ValidMessage() with { IntermediaryAgent2 = ValidAgent("CHASUS33XXX") },
            "IntermediaryAgent2Account" => ValidMessage() with { IntermediaryAgent2Account = ValidIban() },
            "IntermediaryAgent3" => ValidMessage() with { IntermediaryAgent3 = ValidAgent("CHASUS33XXX") },
            "IntermediaryAgent3Account" => ValidMessage() with { IntermediaryAgent3Account = ValidIban() },
            _ => throw new ArgumentOutOfRangeException(nameof(fieldName)),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    private static CashAccount40 ValidIban() =>
        new()
        {
            Identification = new BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IBAN
            {
                Value = "DE89370400440532013000",
            },
        };

    [Fact]
    public void PaymentTypeInformation_Present_NoValidationError()
    {
        var msg = ValidMessage() with { PaymentTypeInformation = new PaymentTypeInformation28() };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SettlementTimeIndication_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            SettlementTimeIndication = new SettlementDateTimeIndication1 { CreditDateTime = new DateTime(2026, 1, 1) },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InstructionForCreditorAgent_Present_NoValidationError()
    {
        var msg = ValidMessage() with { InstructionForCreditorAgent = [new InstructionForCreditorAgent3()] };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
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
