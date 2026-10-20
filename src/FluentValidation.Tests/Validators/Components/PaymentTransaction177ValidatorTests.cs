// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentTransaction177ValidatorTests
{
    private readonly PaymentTransaction177Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new PaymentTransaction177()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void OriginalGroupInformation_Present_NoValidationError()
    {
        var msg = new PaymentTransaction177
        {
            OriginalGroupInformation = new OriginalGroupInformation33
            {
                OriginalMessageIdentification = "MSG-001",
                OriginalMessageNameIdentification = "pacs.008.001.08",
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void StatusReasonInformation_Present_NoValidationError()
    {
        var msg = new PaymentTransaction177 { StatusReasonInformation = [new StatusReasonInformation14()] };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ChargesInformation_Present_NoValidationError()
    {
        var msg = new PaymentTransaction177
        {
            ChargesInformation =
            [
                new Charges16
                {
                    Agent = new BranchAndFinancialInstitutionIdentification8
                    {
                        FinancialInstitutionIdentification = new FinancialInstitutionIdentification23 { BICFI = "DEUTDEFFXXX" },
                    },
                    Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "EUR", Amount = 5m },
                },
            ],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProcessingDate_Present_NoValidationError()
    {
        var msg = new PaymentTransaction177
        {
            ProcessingDate = new BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice.DateTime
            {
                Value = new DateTime(2026, 1, 1),
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void EffectiveInterbankSettlementDate_Present_NoValidationError()
    {
        var msg = new PaymentTransaction177
        {
            EffectiveInterbankSettlementDate = new BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice.Date
            {
                Value = new DateOnly(2026, 1, 1),
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InstructingAgent_Present_NoValidationError()
    {
        var msg = new PaymentTransaction177
        {
            InstructingAgent = new BranchAndFinancialInstitutionIdentification8
            {
                FinancialInstitutionIdentification = new FinancialInstitutionIdentification23 { BICFI = "DEUTDEFFXXX" },
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InstructedAgent_Present_NoValidationError()
    {
        var msg = new PaymentTransaction177
        {
            InstructedAgent = new BranchAndFinancialInstitutionIdentification8
            {
                FinancialInstitutionIdentification = new FinancialInstitutionIdentification23 { BICFI = "DEUTDEFFXXX" },
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void OriginalTransactionReference_Present_NoValidationError()
    {
        var msg = new PaymentTransaction177 { OriginalTransactionReference = new OriginalTransactionReference47() };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SupplementaryData_Present_NoValidationError()
    {
        var msg = new PaymentTransaction177
        {
            SupplementaryData = [new SupplementaryData1 { Envelope = new SupplementaryDataEnvelope1() }],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
