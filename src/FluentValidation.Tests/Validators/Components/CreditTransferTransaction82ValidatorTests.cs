// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CreditTransferTransaction82ValidatorTests
{
    private readonly CreditTransferTransaction82Validator _sut = new();

    private static IBranchAndFinancialInstitutionIdentification8 ValidAgent(string bic) =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>(b2 => b2
            .Set(x2 => x2.BICFI).To(bic))));

    private static ICreditTransferTransaction82 ValidMessage() =>
        IsoDataFactory.Make<ICreditTransferTransaction82>(b => b
            .Set(x => x.PaymentIdentification).To(IsoDataFactory.Make<IPaymentIdentification13>(b2 => b2
                .Set(x2 => x2.EndToEndIdentification).To("E2E-001")))
            .Set(x => x.InterbankSettlementAmount).To(new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m })
            .Set(x => x.Debtor).To(ValidAgent("DEUTDEFFXXX"))
            .Set(x => x.Creditor).To(ValidAgent("CHASUS33XXX")));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InterbankSettlementAmount_UnsetCurrency_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.InterbankSettlementAmount).To(ValidMessage().InterbankSettlementAmount with { Currency = default }));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "InterbankSettlementAmount.Currency");
    }

    [Fact]
    public void InterbankSettlementAmount_ZeroAmount_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.InterbankSettlementAmount).To(ValidMessage().InterbankSettlementAmount with { Amount = 0m }));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "InterbankSettlementAmount.Amount");
    }

    [Fact]
    public void PaymentTypeInformation_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.PaymentTypeInformation).To(IsoDataFactory.Make<IPaymentTypeInformation28>()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SettlementTimeIndicationAndRequest_Present_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SettlementTimeIndication).To(IsoDataFactory.Make<ISettlementDateTimeIndication1>())
            .Set(x => x.SettlementTimeRequest).To(IsoDataFactory.Make<ISettlementTimeRequest2>()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PaymentSignature_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.PaymentSignature).To(IsoDataFactory.Make<Choices.CryptographicKey1Choice.ISignature>(b2 => b2
                .Set(x2 => x2.Value).To(new string('A', 64)))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InstructingAgentAndInstructedAgent_Present_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.InstructingAgent).To(ValidAgent("BOFAUS3NXXX"))
            .Set(x => x.InstructedAgent).To(ValidAgent("BOFAUS3NXXX")));
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
            "PreviousInstructingAgent1" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.PreviousInstructingAgent1).To(ValidAgent("BOFAUS3NXXX"))),
            "PreviousInstructingAgent2" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.PreviousInstructingAgent2).To(ValidAgent("BOFAUS3NXXX"))),
            "PreviousInstructingAgent3" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.PreviousInstructingAgent3).To(ValidAgent("BOFAUS3NXXX"))),
            "IntermediaryAgent1" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.IntermediaryAgent1).To(ValidAgent("BOFAUS3NXXX"))),
            "IntermediaryAgent2" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.IntermediaryAgent2).To(ValidAgent("BOFAUS3NXXX"))),
            "IntermediaryAgent3" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.IntermediaryAgent3).To(ValidAgent("BOFAUS3NXXX"))),
            _ => throw new ArgumentOutOfRangeException(nameof(fieldName)),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void UltimateDebtorAndUltimateCreditor_Present_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.UltimateDebtor).To(ValidAgent("BOFAUS3NXXX"))
            .Set(x => x.UltimateCreditor).To(ValidAgent("BOFAUS3NXXX")));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InstructionForCreditorAgentAndNextAgent_Present_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.InstructionForCreditorAgent).To([IsoDataFactory.Make<IInstructionForCreditorAgent3>()])
            .Set(x => x.InstructionForNextAgent).To([IsoDataFactory.Make<IInstructionForNextAgent1>()]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PurposeAndRemittanceInformation_Present_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Purpose).To(IsoDataFactory.Make<Choices.Purpose2Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("MYPURPOSE")))
            .Set(x => x.RemittanceInformation).To(IsoDataFactory.Make<IRemittanceInformation2>()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void UnderlyingAllocation_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.UnderlyingAllocation).To([
                IsoDataFactory.Make<ITransactionAllocation2>(b2 => b2
                    .Set(x2 => x2.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "EUR", Amount = 10m })
                    .Set(x2 => x2.CreditDebitIndicator).To(CreditDebitCode.Credit)
                    .Set(x2 => x2.Account).To(IsoDataFactory.Make<ICashAccount40>(b3 => b3
                        .Set(x3 => x3.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IOther>(b4 => b4
                            .Set(x4 => x4.Identification).To("ACC-001")))))
                    .Set(x2 => x2.Purpose).To(IsoDataFactory.Make<Choices.Purpose2Choice.IProprietary>(b3 => b3
                        .Set(x3 => x3.Value).To("ALLOC")))
                    .Set(x2 => x2.Reference).To("REF-001")),
            ]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
