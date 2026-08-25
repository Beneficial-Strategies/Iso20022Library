// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CreditTransferTransaction80ValidatorTests
{
    private readonly CreditTransferTransaction80Validator _sut = new();

    private static BranchAndFinancialInstitutionIdentification8 ValidAgent(string bic) =>
        new() { FinancialInstitutionIdentification = new FinancialInstitutionIdentification23 { BICFI = bic } };

    private static CreditTransferTransaction80 ValidMessage() =>
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
    public void InstructingAndInstructedAgent_Present_NoValidationErrors()
    {
        var msg = ValidMessage() with
        {
            InstructingAgent = ValidAgent("BOFAUS3NXXX"),
            InstructedAgent = ValidAgent("BOFAUS3NXXX"),
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
                        Identification = new BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IBAN
                        {
                            Value = "DE89370400440532013000",
                        },
                    },
                    Purpose = new BeneficialStrategies.Iso20022.Choices.Purpose2Choice.Code
                    {
                        Value = ExternalPurpose1Code.CashManagementTransfer,
                    },
                    Reference = "REF-001",
                },
            ],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void RegulatoryReportingAndRemittanceInformation_Present_NoValidationErrors()
    {
        var msg = ValidMessage() with
        {
            RegulatoryReporting = [new RegulatoryReporting10 { DebitCreditReportingIndicator = RegulatoryReportingType1Code.Both }],
            RemittanceInformation = new RemittanceInformation2(),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
