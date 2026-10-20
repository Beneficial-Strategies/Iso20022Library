// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentTransaction177ValidatorTests
{
    private readonly PaymentTransaction177Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IPaymentTransaction177>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void OriginalGroupInformation_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IPaymentTransaction177>(b => b
            .Set(x => x.OriginalGroupInformation).To(IsoDataFactory.Make<IOriginalGroupInformation33>(b2 => b2
                .Set(x2 => x2.OriginalMessageIdentification).To("MSG-001")
                .Set(x2 => x2.OriginalMessageNameIdentification).To("pacs.008.001.08"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void StatusReasonInformation_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IPaymentTransaction177>(b => b
            .Set(x => x.StatusReasonInformation).To([IsoDataFactory.Make<IStatusReasonInformation14>()]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ChargesInformation_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IPaymentTransaction177>(b => b
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
    public void ProcessingDate_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IPaymentTransaction177>(b => b
            .Set(x => x.ProcessingDate).To(IsoDataFactory.Make<Choices.DateAndDateTime2Choice.IDateTime>(b2 => b2
                .Set(x2 => x2.Value).To(new DateTime(2026, 1, 1)))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void EffectiveInterbankSettlementDate_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IPaymentTransaction177>(b => b
            .Set(x => x.EffectiveInterbankSettlementDate).To(IsoDataFactory.Make<Choices.DateAndDateTime2Choice.IDate>(b2 => b2
                .Set(x2 => x2.Value).To(new DateOnly(2026, 1, 1)))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InstructingAgent_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IPaymentTransaction177>(b => b
            .Set(x => x.InstructingAgent).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b2 => b2
                .Set(x2 => x2.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>(b3 => b3
                    .Set(x3 => x3.BICFI).To("DEUTDEFFXXX"))))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InstructedAgent_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IPaymentTransaction177>(b => b
            .Set(x => x.InstructedAgent).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b2 => b2
                .Set(x2 => x2.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>(b3 => b3
                    .Set(x3 => x3.BICFI).To("DEUTDEFFXXX"))))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void OriginalTransactionReference_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IPaymentTransaction177>(b => b
            .Set(x => x.OriginalTransactionReference).To(IsoDataFactory.Make<IOriginalTransactionReference47>()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SupplementaryData_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IPaymentTransaction177>(b => b
            .Set(x => x.SupplementaryData).To([IsoDataFactory.Make<ISupplementaryData1>(b2 => b2
                .Set(x2 => x2.Envelope).To(new SupplementaryDataEnvelope1()))]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
