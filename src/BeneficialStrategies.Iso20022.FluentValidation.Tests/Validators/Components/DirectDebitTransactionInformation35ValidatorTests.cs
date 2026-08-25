// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class DirectDebitTransactionInformation35ValidatorTests
{
    private readonly DirectDebitTransactionInformation35Validator _sut = new();

    private static BranchAndFinancialInstitutionIdentification8 ValidAgent(string bic) =>
        new() { FinancialInstitutionIdentification = new FinancialInstitutionIdentification23 { BICFI = bic } };

    private static CashAccount40 ValidAccount(string id = "ACC-001") =>
        new() { Identification = new Choices.AccountIdentification4Choice.Other { Identification = id } };

    private static DirectDebitTransactionInformation35 ValidMessage() =>
        new()
        {
            PaymentIdentification = new PaymentIdentification13 { EndToEndIdentification = "E2E-001" },
            InterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m },
            ChargeBearer = ChargeBearerType1Code.Shared,
            Creditor = new PartyIdentification272(),
            CreditorAgent = ValidAgent("CHASUS33XXX"),
            Debtor = new PartyIdentification272(),
            DebtorAccount = ValidAccount(),
            DebtorAgent = ValidAgent("DEUTDEFFXXX"),
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── InterbankSettlementAmount (required) ─────────────────────────────────────

    [Fact]
    public void InterbankSettlementAmount_InvalidCurrency_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            InterbankSettlementAmount = ValidMessage().InterbankSettlementAmount with { Currency = "eur" },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "InterbankSettlementAmount.Currency");
    }

    [Fact]
    public void InterbankSettlementAmount_ZeroAmount_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            InterbankSettlementAmount = ValidMessage().InterbankSettlementAmount with { Amount = 0m },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "InterbankSettlementAmount.Amount");
    }

    // ── InstructedAmount (optional) ───────────────────────────────────────────────

    [Fact]
    public void InstructedAmount_Valid_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            InstructedAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 50m },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InstructedAmount_ZeroAmount_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            InstructedAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 0m },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "InstructedAmount.Amount");
    }

    // ── Other optional building blocks ────────────────────────────────────────────

    [Fact]
    public void PaymentTypeInformation_Present_NoValidationError()
    {
        var msg = ValidMessage() with { PaymentTypeInformation = new PaymentTypeInformation27() };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SettlementTimeIndication_Present_NoValidationError()
    {
        var msg = ValidMessage() with { SettlementTimeIndication = new SettlementDateTimeIndication1() };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ChargesInformation_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            ChargesInformation =
            [
                new Charges16
                {
                    Agent = ValidAgent("BOFAUS3NXXX"),
                    Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "EUR", Amount = 5m },
                },
            ],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void DirectDebitTransaction_Present_NoValidationError()
    {
        var msg = ValidMessage() with { DirectDebitTransaction = new DirectDebitTransaction12() };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void CreditorAccountAndCreditorAgentAccount_Present_NoValidationErrors()
    {
        var msg = ValidMessage() with { CreditorAccount = ValidAccount(), CreditorAgentAccount = ValidAccount() };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void UltimateCreditorAndInitiatingParty_Present_NoValidationErrors()
    {
        var msg = ValidMessage() with { UltimateCreditor = new PartyIdentification272(), InitiatingParty = new PartyIdentification272() };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InstructingAgentAndInstructedAgent_Present_NoValidationErrors()
    {
        var msg = ValidMessage() with { InstructingAgent = ValidAgent("BOFAUS3NXXX"), InstructedAgent = ValidAgent("BOFAUS3NXXX") };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Theory]
    [InlineData("IntermediaryAgent1")]
    [InlineData("IntermediaryAgent2")]
    [InlineData("IntermediaryAgent3")]
    public void OptionalIntermediaryAgentFields_Present_NoValidationErrors(string fieldName)
    {
        var msg = fieldName switch
        {
            "IntermediaryAgent1" => ValidMessage() with { IntermediaryAgent1 = ValidAgent("BOFAUS3NXXX"), IntermediaryAgent1Account = ValidAccount() },
            "IntermediaryAgent2" => ValidMessage() with { IntermediaryAgent2 = ValidAgent("BOFAUS3NXXX"), IntermediaryAgent2Account = ValidAccount() },
            "IntermediaryAgent3" => ValidMessage() with { IntermediaryAgent3 = ValidAgent("BOFAUS3NXXX"), IntermediaryAgent3Account = ValidAccount() },
            _ => throw new ArgumentOutOfRangeException(nameof(fieldName)),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void DebtorAgentAccountAndUltimateDebtor_Present_NoValidationErrors()
    {
        var msg = ValidMessage() with { DebtorAgentAccount = ValidAccount(), UltimateDebtor = new PartyIdentification272() };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PurposeAndRegulatoryReporting_Present_NoValidationErrors()
    {
        var msg = ValidMessage() with
        {
            Purpose = new BeneficialStrategies.Iso20022.Choices.Purpose2Choice.Proprietary { Value = "MYPURPOSE" },
            RegulatoryReporting = [new RegulatoryReporting10 { DebitCreditReportingIndicator = RegulatoryReportingType1Code.Both }],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void RelatedRemittanceInformationAndRemittanceInformation_Present_NoValidationErrors()
    {
        var msg = ValidMessage() with
        {
            RelatedRemittanceInformation = [new RemittanceLocation8()],
            RemittanceInformation = new RemittanceInformation26(),
        };
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
