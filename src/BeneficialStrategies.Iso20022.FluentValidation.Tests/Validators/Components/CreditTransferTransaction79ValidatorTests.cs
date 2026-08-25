// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CreditTransferTransaction79ValidatorTests
{
    private readonly CreditTransferTransaction79Validator _sut = new();

    private static BranchAndFinancialInstitutionIdentification8 ValidAgent(string bic) =>
        new() { FinancialInstitutionIdentification = new FinancialInstitutionIdentification23 { BICFI = bic } };

    private static CreditTransferTransaction79 ValidMessage() =>
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
    public void UnderlyingCustomerCreditTransfer_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            UnderlyingCustomerCreditTransfer = new CreditTransferTransaction72
            {
                Debtor = new PartyIdentification272(),
                DebtorAgent = ValidAgent("DEUTDEFFXXX"),
                CreditorAgent = ValidAgent("CHASUS33XXX"),
                Creditor = new PartyIdentification272(),
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void UnderlyingFinancialInstitutionCreditTransfer_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            UnderlyingFinancialInstitutionCreditTransfer = new CreditTransferTransaction80
            {
                PaymentIdentification = new PaymentIdentification13 { EndToEndIdentification = "E2E-002" },
                InterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 50m },
                Debtor = ValidAgent("DEUTDEFFXXX"),
                Creditor = ValidAgent("CHASUS33XXX"),
            },
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

    [Fact]
    public void InstructingAndInstructedAgent_Present_NoValidationErrors()
    {
        var msg = ValidMessage() with
        {
            InstructingAgent = ValidAgent("BOFAUS3NXXX"),
            InstructedAgent = ValidAgent("BOFAUS3NXXX"),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
