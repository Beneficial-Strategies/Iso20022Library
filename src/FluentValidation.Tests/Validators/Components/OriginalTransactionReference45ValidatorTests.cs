// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OriginalTransactionReference45ValidatorTests
{
    private readonly OriginalTransactionReference45Validator _sut = new();

    private static IBranchAndFinancialInstitutionIdentification8 ValidAgent(string bic) =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>(b2 => b2
            .Set(x2 => x2.BICFI).To(bic))));

    private static BeneficialStrategies.Iso20022.Choices.IParty50Choice ValidParty() =>
        IsoDataFactory.Make<Choices.Party50Choice.IParty>(b => b
            .Set(x => x.Value).To(IsoDataFactory.Make<IPartyIdentification272>()));

    private static ICashAccount40 ValidAccount(string id = "ACC-001") =>
        IsoDataFactory.Make<ICashAccount40>(b => b
            .Set(x => x.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IOther>(b2 => b2
            .Set(x2 => x2.Identification).To(id))));

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IOriginalTransactionReference45>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InterbankSettlementAmount_UnsetCurrency_HasValidationError()
    {
        var msg = IsoDataFactory.Make<IOriginalTransactionReference45>(b => b
            .Set(x => x.InterbankSettlementAmount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = default, Amount = 100m }));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "InterbankSettlementAmount.Currency");
    }

    [Fact]
    public void InterbankSettlementAmount_ZeroAmount_HasValidationError()
    {
        var msg = IsoDataFactory.Make<IOriginalTransactionReference45>(b => b
            .Set(x => x.InterbankSettlementAmount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "EUR", Amount = 0m }));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "InterbankSettlementAmount.Amount");
    }

    [Fact]
    public void InterbankSettlementAmount_Valid_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IOriginalTransactionReference45>(b => b
            .Set(x => x.InterbankSettlementAmount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "EUR", Amount = 100m }));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AmountAndRequestedExecutionDate_Present_NoValidationErrors()
    {
        var msg = IsoDataFactory.Make<IOriginalTransactionReference45>(b => b
            .Set(x => x.Amount).To(IsoDataFactory.Make<Choices.AmountType4Choice.IInstructedAmount>(b2 => b2
                .Set(x2 => x2.Currency).To("EUR")
                .Set(x2 => x2.Amount).To(50m)))
            .Set(x => x.RequestedExecutionDate).To(IsoDataFactory.Make<Choices.DateAndDateTime2Choice.IDate>(b2 => b2
                .Set(x2 => x2.Value).To(new DateOnly(2026, 1, 1)))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void CreditorSchemeIdentificationAndSettlementInformation_Present_NoValidationErrors()
    {
        var msg = IsoDataFactory.Make<IOriginalTransactionReference45>(b => b
            .Set(x => x.CreditorSchemeIdentification).To(IsoDataFactory.Make<IPartyIdentification272>())
            .Set(x => x.SettlementInformation).To(IsoDataFactory.Make<ISettlementInstruction15>(b2 => b2
                .Set(x2 => x2.SettlementMethod).To(SettlementMethod1Code.ClearingSystem))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PaymentTypeInformationAndMandateRelatedInformation_Present_NoValidationErrors()
    {
        var msg = IsoDataFactory.Make<IOriginalTransactionReference45>(b => b
            .Set(x => x.PaymentTypeInformation).To(IsoDataFactory.Make<IPaymentTypeInformation27>())
            .Set(x => x.MandateRelatedInformation).To(IsoDataFactory.Make<Choices.MandateRelatedData5Choice.ICreditTransferMandate>(b2 => b2
                .Set(x2 => x2.Value).To(IsoDataFactory.Make<ICreditTransferMandateData1>()))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void RemittanceInformation_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IOriginalTransactionReference45>(b => b
            .Set(x => x.RemittanceInformation).To(IsoDataFactory.Make<IRemittanceInformation26>()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PartiesAndAccounts_Present_NoValidationErrors()
    {
        var msg = IsoDataFactory.Make<IOriginalTransactionReference45>(b => b
            .Set(x => x.UltimateDebtor).To(ValidParty())
            .Set(x => x.Debtor).To(ValidParty())
            .Set(x => x.DebtorAccount).To(ValidAccount())
            .Set(x => x.DebtorAgent).To(ValidAgent("DEUTDEFFXXX"))
            .Set(x => x.DebtorAgentAccount).To(ValidAccount())
            .Set(x => x.CreditorAgent).To(ValidAgent("CHASUS33XXX"))
            .Set(x => x.CreditorAgentAccount).To(ValidAccount())
            .Set(x => x.Creditor).To(ValidParty())
            .Set(x => x.CreditorAccount).To(ValidAccount())
            .Set(x => x.UltimateCreditor).To(ValidParty()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Purpose_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IOriginalTransactionReference45>(b => b
            .Set(x => x.Purpose).To(IsoDataFactory.Make<Choices.Purpose2Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("MYPURPOSE"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void UnderlyingCustomerCreditTransfer_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IOriginalTransactionReference45>(b => b
            .Set(x => x.UnderlyingCustomerCreditTransfer).To(IsoDataFactory.Make<ICreditTransferTransaction72>(b2 => b2
                .Set(x2 => x2.Debtor).To(IsoDataFactory.Make<IPartyIdentification272>())
                .Set(x2 => x2.DebtorAgent).To(ValidAgent("DEUTDEFFXXX"))
                .Set(x2 => x2.CreditorAgent).To(ValidAgent("CHASUS33XXX"))
                .Set(x2 => x2.Creditor).To(IsoDataFactory.Make<IPartyIdentification272>()))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void UnderlyingFinancialInstitutionCreditTransfer_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IOriginalTransactionReference45>(b => b
            .Set(x => x.UnderlyingFinancialInstitutionCreditTransfer).To(IsoDataFactory.Make<ICreditTransferTransaction82>(b2 => b2
                .Set(x2 => x2.PaymentIdentification).To(IsoDataFactory.Make<IPaymentIdentification13>(b3 => b3
                    .Set(x3 => x3.EndToEndIdentification).To("E2E-003")))
                .Set(x2 => x2.InterbankSettlementAmount).To(new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 10m })
                .Set(x2 => x2.Debtor).To(ValidAgent("DEUTDEFFXXX"))
                .Set(x2 => x2.Creditor).To(ValidAgent("CHASUS33XXX")))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
