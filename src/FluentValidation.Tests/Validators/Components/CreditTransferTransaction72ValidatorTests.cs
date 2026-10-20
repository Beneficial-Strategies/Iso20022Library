// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CreditTransferTransaction72ValidatorTests
{
    private readonly CreditTransferTransaction72Validator _sut = new();

    private static BranchAndFinancialInstitutionIdentification8 ValidAgent(string bic) =>
        new() { FinancialInstitutionIdentification = new FinancialInstitutionIdentification23 { BICFI = bic } };

    private static CreditTransferTransaction72 ValidMessage() =>
        new()
        {
            Debtor = new PartyIdentification272(),
            DebtorAgent = ValidAgent("DEUTDEFFXXX"),
            CreditorAgent = ValidAgent("CHASUS33XXX"),
            Creditor = new PartyIdentification272(),
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PaymentIdentification_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            PaymentIdentification = new PaymentIdentification13 { EndToEndIdentification = "E2E-001" },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InitiatingPartyAndUltimateParties_Present_NoValidationErrors()
    {
        var msg = ValidMessage() with
        {
            InitiatingParty = new PartyIdentification272(),
            UltimateDebtor = new PartyIdentification272(),
            UltimateCreditor = new PartyIdentification272(),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

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

    [Fact]
    public void TaxAndRemittanceInformation_Present_NoValidationErrors()
    {
        var msg = ValidMessage() with { Tax = new TaxData1(), RemittanceInformation = new RemittanceInformation26() };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
