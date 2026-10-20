// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CreditTransferTransaction80ValidatorTests
{
    private readonly CreditTransferTransaction80Validator _sut = new();

    private static IBranchAndFinancialInstitutionIdentification8 ValidAgent(string bic) =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>(b2 => b2
            .Set(x2 => x2.BICFI).To(bic))));

    private static ICreditTransferTransaction80 ValidMessage() =>
        IsoDataFactory.Make<ICreditTransferTransaction80>(b => b
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
    public void PaymentSignature_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.PaymentSignature).To(IsoDataFactory.Make<Choices.CryptographicKey1Choice.ISignature>(b2 => b2
                .Set(x2 => x2.Value).To(new string('A', 64)))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InstructingAndInstructedAgent_Present_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.InstructingAgent).To(ValidAgent("BOFAUS3NXXX"))
            .Set(x => x.InstructedAgent).To(ValidAgent("BOFAUS3NXXX")));
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
                        .Set(x3 => x3.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IIBAN>(b4 => b4
                            .Set(x4 => x4.Value).To("DE89370400440532013000")))))
                    .Set(x2 => x2.Purpose).To(IsoDataFactory.Make<Choices.Purpose2Choice.ICode>(b3 => b3
                        .Set(x3 => x3.Value).To(ExternalPurpose1Code.CashManagementTransfer)))
                    .Set(x2 => x2.Reference).To("REF-001")),
            ]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void RegulatoryReportingAndRemittanceInformation_Present_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.RegulatoryReporting).To([IsoDataFactory.Make<IRegulatoryReporting10>(b2 => b2
                .Set(x2 => x2.DebitCreditReportingIndicator).To(RegulatoryReportingType1Code.Both))])
            .Set(x => x.RemittanceInformation).To(IsoDataFactory.Make<IRemittanceInformation2>()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
