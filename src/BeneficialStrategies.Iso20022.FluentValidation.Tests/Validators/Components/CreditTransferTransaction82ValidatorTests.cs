// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CreditTransferTransaction82ValidatorTests
{
    private readonly CreditTransferTransaction82Validator _sut = new();

    private static BranchAndFinancialInstitutionIdentification8 ValidAgent(string bic) =>
        new() { FinancialInstitutionIdentification = new FinancialInstitutionIdentification23 { BICFI = bic } };

    private static CreditTransferTransaction82 ValidMessage() =>
        new()
        {
            PaymentIdentification = new PaymentIdentification13 { EndToEndIdentification = "E2E-001" },
            InterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m },
            Debtor = ValidAgent("DEUTDEFFXXX"),
            Creditor = ValidAgent("CHASUS33XXX"),
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

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

    [Fact]
    public void PaymentTypeInformation_Present_NoValidationError()
    {
        var msg = ValidMessage() with { PaymentTypeInformation = new PaymentTypeInformation28() };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SettlementTimeIndicationAndRequest_Present_NoValidationErrors()
    {
        var msg = ValidMessage() with
        {
            SettlementTimeIndication = new SettlementDateTimeIndication1(),
            SettlementTimeRequest = new SettlementTimeRequest2(),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PaymentSignature_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            PaymentSignature = new BeneficialStrategies.Iso20022.Choices.CryptographicKey1Choice.Signature
            {
                Value = new string('A', 64),
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InstructingAgentAndInstructedAgent_Present_NoValidationErrors()
    {
        var msg = ValidMessage() with { InstructingAgent = ValidAgent("BOFAUS3NXXX"), InstructedAgent = ValidAgent("BOFAUS3NXXX") };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Theory]
    [InlineData("PreviousInstructingAgent1")]
    [InlineData("PreviousInstructingAgent2")]
    [InlineData("PreviousInstructingAgent3")]
    [InlineData("IntermediaryAgent1")]
    [InlineData("IntermediaryAgent2")]
    [InlineData("IntermediaryAgent3")]
    public void OptionalAgentFields_Present_NoValidationErrors(string fieldName)
    {
        var msg = fieldName switch
        {
            "PreviousInstructingAgent1" => ValidMessage() with { PreviousInstructingAgent1 = ValidAgent("BOFAUS3NXXX") },
            "PreviousInstructingAgent2" => ValidMessage() with { PreviousInstructingAgent2 = ValidAgent("BOFAUS3NXXX") },
            "PreviousInstructingAgent3" => ValidMessage() with { PreviousInstructingAgent3 = ValidAgent("BOFAUS3NXXX") },
            "IntermediaryAgent1" => ValidMessage() with { IntermediaryAgent1 = ValidAgent("BOFAUS3NXXX") },
            "IntermediaryAgent2" => ValidMessage() with { IntermediaryAgent2 = ValidAgent("BOFAUS3NXXX") },
            "IntermediaryAgent3" => ValidMessage() with { IntermediaryAgent3 = ValidAgent("BOFAUS3NXXX") },
            _ => throw new ArgumentOutOfRangeException(nameof(fieldName)),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void UltimateDebtorAndUltimateCreditor_Present_NoValidationErrors()
    {
        var msg = ValidMessage() with { UltimateDebtor = ValidAgent("BOFAUS3NXXX"), UltimateCreditor = ValidAgent("BOFAUS3NXXX") };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InstructionForCreditorAgentAndNextAgent_Present_NoValidationErrors()
    {
        var msg = ValidMessage() with
        {
            InstructionForCreditorAgent = [new InstructionForCreditorAgent3()],
            InstructionForNextAgent = [new InstructionForNextAgent1()],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PurposeAndRemittanceInformation_Present_NoValidationErrors()
    {
        var msg = ValidMessage() with
        {
            Purpose = new BeneficialStrategies.Iso20022.Choices.Purpose2Choice.Proprietary { Value = "MYPURPOSE" },
            RemittanceInformation = new RemittanceInformation2(),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void UnderlyingAllocation_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            UnderlyingAllocation =
            [
                new TransactionAllocation2
                {
                    Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "EUR", Amount = 10m },
                    CreditDebitIndicator = CreditDebitCode.Credit,
                    Account = new CashAccount40
                    {
                        Identification = new Choices.AccountIdentification4Choice.Other { Identification = "ACC-001" },
                    },
                    Purpose = new BeneficialStrategies.Iso20022.Choices.Purpose2Choice.Proprietary { Value = "ALLOC" },
                    Reference = "REF-001",
                },
            ],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
