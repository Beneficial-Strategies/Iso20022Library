// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CreditTransferTransaction79ValidatorTests
{
    private readonly CreditTransferTransaction79Validator _sut = new();

    private static IBranchAndFinancialInstitutionIdentification8 ValidAgent(string bic) =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>(b2 => b2
            .Set(x2 => x2.BICFI).To(bic))));

    private static ICreditTransferTransaction79 ValidMessage() =>
        IsoDataFactory.Make<ICreditTransferTransaction79>(b => b
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
    public void UnderlyingCustomerCreditTransfer_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
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
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.UnderlyingFinancialInstitutionCreditTransfer).To(IsoDataFactory.Make<ICreditTransferTransaction80>(b2 => b2
                .Set(x2 => x2.PaymentIdentification).To(IsoDataFactory.Make<IPaymentIdentification13>(b3 => b3
                    .Set(x3 => x3.EndToEndIdentification).To("E2E-002")))
                .Set(x2 => x2.InterbankSettlementAmount).To(new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 50m })
                .Set(x2 => x2.Debtor).To(ValidAgent("DEUTDEFFXXX"))
                .Set(x2 => x2.Creditor).To(ValidAgent("CHASUS33XXX")))));
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

    [Fact]
    public void InstructingAndInstructedAgent_Present_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.InstructingAgent).To(ValidAgent("BOFAUS3NXXX"))
            .Set(x => x.InstructedAgent).To(ValidAgent("BOFAUS3NXXX")));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
