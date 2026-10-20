// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class DirectDebitTransactionInformation35ValidatorTests
{
    private readonly DirectDebitTransactionInformation35Validator _sut = new();

    private static IBranchAndFinancialInstitutionIdentification8 ValidAgent(string bic) =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>(b2 => b2
            .Set(x2 => x2.BICFI).To(bic))));

    private static ICashAccount40 ValidAccount(string id = "ACC-001") =>
        IsoDataFactory.Make<ICashAccount40>(b => b
            .Set(x => x.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IOther>(b2 => b2
            .Set(x2 => x2.Identification).To(id))));

    private static IDirectDebitTransactionInformation35 ValidMessage() =>
        IsoDataFactory.Make<IDirectDebitTransactionInformation35>(b => b
            .Set(x => x.PaymentIdentification).To(IsoDataFactory.Make<IPaymentIdentification13>(b2 => b2
                .Set(x2 => x2.EndToEndIdentification).To("E2E-001")))
            .Set(x => x.InterbankSettlementAmount).To(new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m })
            .Set(x => x.ChargeBearer).To(ChargeBearerType1Code.Shared)
            .Set(x => x.Creditor).To(IsoDataFactory.Make<IPartyIdentification272>())
            .Set(x => x.CreditorAgent).To(ValidAgent("CHASUS33XXX"))
            .Set(x => x.Debtor).To(IsoDataFactory.Make<IPartyIdentification272>())
            .Set(x => x.DebtorAccount).To(ValidAccount())
            .Set(x => x.DebtorAgent).To(ValidAgent("DEUTDEFFXXX")));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── InterbankSettlementAmount (required) ─────────────────────────────────────

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

    // ── InstructedAmount (optional) ───────────────────────────────────────────────

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

    // ── Other optional building blocks ────────────────────────────────────────────

    [Fact]
    public void PaymentTypeInformation_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.PaymentTypeInformation).To(IsoDataFactory.Make<IPaymentTypeInformation27>()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SettlementTimeIndication_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SettlementTimeIndication).To(IsoDataFactory.Make<ISettlementDateTimeIndication1>()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ChargesInformation_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ChargesInformation).To([
                IsoDataFactory.Make<ICharges16>(b2 => b2
                    .Set(x2 => x2.Agent).To(ValidAgent("BOFAUS3NXXX"))
                    .Set(x2 => x2.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "EUR", Amount = 5m })),
            ]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void DirectDebitTransaction_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.DirectDebitTransaction).To(IsoDataFactory.Make<IDirectDebitTransaction12>()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void CreditorAccountAndCreditorAgentAccount_Present_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.CreditorAccount).To(ValidAccount())
            .Set(x => x.CreditorAgentAccount).To(ValidAccount()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void UltimateCreditorAndInitiatingParty_Present_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.UltimateCreditor).To(IsoDataFactory.Make<IPartyIdentification272>())
            .Set(x => x.InitiatingParty).To(IsoDataFactory.Make<IPartyIdentification272>()));
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
    [InlineData("IntermediaryAgent1")]
    [InlineData("IntermediaryAgent2")]
    [InlineData("IntermediaryAgent3")]
    public void OptionalIntermediaryAgentFields_Present_NoValidationErrors(string fieldName)
    {
        var msg = fieldName switch
        {
            "IntermediaryAgent1" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.IntermediaryAgent1).To(ValidAgent("BOFAUS3NXXX"))
                .Set(x => x.IntermediaryAgent1Account).To(ValidAccount())),
            "IntermediaryAgent2" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.IntermediaryAgent2).To(ValidAgent("BOFAUS3NXXX"))
                .Set(x => x.IntermediaryAgent2Account).To(ValidAccount())),
            "IntermediaryAgent3" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.IntermediaryAgent3).To(ValidAgent("BOFAUS3NXXX"))
                .Set(x => x.IntermediaryAgent3Account).To(ValidAccount())),
            _ => throw new ArgumentOutOfRangeException(nameof(fieldName)),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void DebtorAgentAccountAndUltimateDebtor_Present_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.DebtorAgentAccount).To(ValidAccount())
            .Set(x => x.UltimateDebtor).To(IsoDataFactory.Make<IPartyIdentification272>()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PurposeAndRegulatoryReporting_Present_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Purpose).To(IsoDataFactory.Make<Choices.Purpose2Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("MYPURPOSE")))
            .Set(x => x.RegulatoryReporting).To([IsoDataFactory.Make<IRegulatoryReporting10>(b2 => b2
                .Set(x2 => x2.DebitCreditReportingIndicator).To(RegulatoryReportingType1Code.Both))]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void RelatedRemittanceInformationAndRemittanceInformation_Present_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.RelatedRemittanceInformation).To([IsoDataFactory.Make<IRemittanceLocation8>()])
            .Set(x => x.RemittanceInformation).To(IsoDataFactory.Make<IRemittanceInformation26>()));
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
