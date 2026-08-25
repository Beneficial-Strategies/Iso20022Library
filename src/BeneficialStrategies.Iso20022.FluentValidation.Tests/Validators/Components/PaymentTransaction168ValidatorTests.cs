// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentTransaction168ValidatorTests
{
    private readonly PaymentTransaction168Validator _sut = new();

    private static BranchAndFinancialInstitutionIdentification8 ValidAgent(string bic) =>
        new() { FinancialInstitutionIdentification = new FinancialInstitutionIdentification23 { BICFI = bic } };

    private static BeneficialStrategies.Iso20022.Choices.Party50Choice_ ValidParty() =>
        new BeneficialStrategies.Iso20022.Choices.Party50Choice.Party { Value = new PartyIdentification272() };

    private static PaymentTransaction168 ValidMessage() =>
        new() { ReturnedInterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m } };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ReturnedInterbankSettlementAmount_InvalidCurrency_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            ReturnedInterbankSettlementAmount = ValidMessage().ReturnedInterbankSettlementAmount with { Currency = "eur" },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "ReturnedInterbankSettlementAmount.Currency");
    }

    [Fact]
    public void ReturnedInterbankSettlementAmount_ZeroAmount_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            ReturnedInterbankSettlementAmount = ValidMessage().ReturnedInterbankSettlementAmount with { Amount = 0m },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "ReturnedInterbankSettlementAmount.Amount");
    }

    [Fact]
    public void OriginalGroupInformation_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            OriginalGroupInformation = new OriginalGroupInformation33
            {
                OriginalMessageIdentification = "ORGMSG-001",
                OriginalMessageNameIdentification = "pacs.008.001.14",
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
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
    public void ReturnedInstructedAmount_ZeroAmount_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            ReturnedInstructedAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 0m },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "ReturnedInstructedAmount.Amount");
    }

    [Fact]
    public void ReturnedInstructedAmount_Valid_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            ReturnedInstructedAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 50m },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void OriginalInterbankSettlementAmount_Valid_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            OriginalInterbankSettlementAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "EUR", Amount = 100m },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void CompensationAmount_Valid_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            CompensationAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "EUR", Amount = 5m },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AgreedRate_Present_NoValidationError()
    {
        var msg = ValidMessage() with { AgreedRate = new CurrencyExchange26 { PreAgreedExchangeRate = 1.1m } };
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
    public void InstructingAgentAndInstructedAgent_Present_NoValidationErrors()
    {
        var msg = ValidMessage() with { InstructingAgent = ValidAgent("BOFAUS3NXXX"), InstructedAgent = ValidAgent("BOFAUS3NXXX") };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ReturnChain_Present_NoValidationError()
    {
        var msg = ValidMessage() with { ReturnChain = new TransactionParties11 { Creditor = ValidParty(), Debtor = ValidParty() } };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ReturnReasonInformation_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            ReturnReasonInformation = [new PaymentReturnReason7 { Originator = new PartyIdentification272() }],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void OriginalTransactionReference_Present_NoValidationError()
    {
        var msg = ValidMessage() with { OriginalTransactionReference = new OriginalTransactionReference45() };
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
