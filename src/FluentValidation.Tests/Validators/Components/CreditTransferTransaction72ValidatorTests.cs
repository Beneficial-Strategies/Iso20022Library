// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CreditTransferTransaction72ValidatorTests
{
    private readonly CreditTransferTransaction72Validator _sut = new();

    private static IBranchAndFinancialInstitutionIdentification8 ValidAgent(string bic) =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>(b2 => b2
            .Set(x2 => x2.BICFI).To(bic))));

    private static ICreditTransferTransaction72 ValidMessage() =>
        IsoDataFactory.Make<ICreditTransferTransaction72>(b => b
            .Set(x => x.Debtor).To(IsoDataFactory.Make<IPartyIdentification272>())
            .Set(x => x.DebtorAgent).To(ValidAgent("DEUTDEFFXXX"))
            .Set(x => x.CreditorAgent).To(ValidAgent("CHASUS33XXX"))
            .Set(x => x.Creditor).To(IsoDataFactory.Make<IPartyIdentification272>()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PaymentIdentification_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.PaymentIdentification).To(IsoDataFactory.Make<IPaymentIdentification13>(b2 => b2
                .Set(x2 => x2.EndToEndIdentification).To("E2E-001"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InitiatingPartyAndUltimateParties_Present_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.InitiatingParty).To(IsoDataFactory.Make<IPartyIdentification272>())
            .Set(x => x.UltimateDebtor).To(IsoDataFactory.Make<IPartyIdentification272>())
            .Set(x => x.UltimateCreditor).To(IsoDataFactory.Make<IPartyIdentification272>()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InstructedAmount_Valid_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.InstructedAmount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 50m }));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InstructedAmount_ZeroAmount_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.InstructedAmount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 0m }));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "InstructedAmount.Amount");
    }

    [Fact]
    public void TaxAndRemittanceInformation_Present_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Tax).To(IsoDataFactory.Make<ITaxData1>())
            .Set(x => x.RemittanceInformation).To(IsoDataFactory.Make<IRemittanceInformation26>()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
