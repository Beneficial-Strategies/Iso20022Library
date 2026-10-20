// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentTransaction182ValidatorTests
{
    private readonly PaymentTransaction182Validator _sut = new();

    private static IPaymentTransaction182 ValidMessage() =>
        IsoDataFactory.Make<IPaymentTransaction182>(b => b
            .Set(x => x.ReversedInterbankSettlementAmount).To(new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m }));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── ReversedInterbankSettlementAmount (required) ─────────────────────────────

    [Fact]
    public void ReversedInterbankSettlementAmount_UnsetCurrency_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ReversedInterbankSettlementAmount).To(ValidMessage().ReversedInterbankSettlementAmount with { Currency = default }));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "ReversedInterbankSettlementAmount.Currency");
    }

    [Fact]
    public void ReversedInterbankSettlementAmount_ZeroAmount_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ReversedInterbankSettlementAmount).To(ValidMessage().ReversedInterbankSettlementAmount with { Amount = 0m }));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "ReversedInterbankSettlementAmount.Amount");
    }

    // ── The three ActiveOrHistoricCurrencyAndAmount optional fields ──────────────

    [Theory]
    [InlineData("OriginalInterbankSettlementAmount")]
    [InlineData("ReversedInstructedAmount")]
    [InlineData("CompensationAmount")]
    public void OptionalAmountField_Valid_NoValidationError(string fieldName)
    {
        var amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 50m };
        var msg = fieldName switch
        {
            "OriginalInterbankSettlementAmount" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.OriginalInterbankSettlementAmount).To(amount)),
            "ReversedInstructedAmount" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.ReversedInstructedAmount).To(amount)),
            "CompensationAmount" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.CompensationAmount).To(amount)),
            _ => throw new ArgumentOutOfRangeException(nameof(fieldName)),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void OriginalInterbankSettlementAmount_UnsetCurrency_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalInterbankSettlementAmount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = default, Amount = 50m }));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "OriginalInterbankSettlementAmount.Currency");
    }

    [Fact]
    public void CompensationAmount_ZeroAmount_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.CompensationAmount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 0m }));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "CompensationAmount.Amount");
    }

    // ── Other optional building blocks ────────────────────────────────────────────

    [Fact]
    public void OriginalGroupInformation_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalGroupInformation).To(IsoDataFactory.Make<IOriginalGroupInformation33>(b2 => b2
                .Set(x2 => x2.OriginalMessageIdentification).To("MSG-001")
                .Set(x2 => x2.OriginalMessageNameIdentification).To("pacs.008.001.08"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SettlementTimeIndication_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SettlementTimeIndication).To(IsoDataFactory.Make<ISettlementDateTimeIndication1>(b2 => b2
                .Set(x2 => x2.CreditDateTime).To(new DateTime(2026, 1, 1)))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ChargesInformation_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ChargesInformation).To([
                IsoDataFactory.Make<ICharges16>(b2 => b2
                    .Set(x2 => x2.Agent).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b3 => b3
                        .Set(x3 => x3.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>(b4 => b4
                            .Set(x4 => x4.BICFI).To("DEUTDEFFXXX")))))
                    .Set(x2 => x2.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "EUR", Amount = 5m })),
            ]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InstructingAgent_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.InstructingAgent).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b2 => b2
                .Set(x2 => x2.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>(b3 => b3
                    .Set(x3 => x3.BICFI).To("DEUTDEFFXXX"))))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InstructedAgent_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.InstructedAgent).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b2 => b2
                .Set(x2 => x2.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>(b3 => b3
                    .Set(x3 => x3.BICFI).To("DEUTDEFFXXX"))))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ReversalReasonInformation_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ReversalReasonInformation).To([IsoDataFactory.Make<IPaymentReversalReason10>()]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void OriginalTransactionReference_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalTransactionReference).To(IsoDataFactory.Make<IOriginalTransactionReference47>()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SupplementaryData_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SupplementaryData).To([IsoDataFactory.Make<ISupplementaryData1>(b2 => b2
                .Set(x2 => x2.Envelope).To(new SupplementaryDataEnvelope1()))]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
