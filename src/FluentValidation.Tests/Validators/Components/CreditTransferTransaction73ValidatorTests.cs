// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CreditTransferTransaction73ValidatorTests
{
    private readonly CreditTransferTransaction73Validator _sut = new();

    private static IBranchAndFinancialInstitutionIdentification8 ValidAgent(string bic) =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>(b2 => b2
            .Set(x2 => x2.BICFI).To(bic))));

    private static ICreditTransferTransaction73 ValidMessage() =>
        IsoDataFactory.Make<ICreditTransferTransaction73>(b => b
            .Set(x => x.PaymentIdentification).To(IsoDataFactory.Make<IPaymentIdentification13>(b2 => b2
                .Set(x2 => x2.EndToEndIdentification).To("E2E-001")))
            .Set(x => x.InterbankSettlementAmount).To(new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m })
            .Set(x => x.ChargeBearer).To(ChargeBearerType1Code.Shared)
            .Set(x => x.Debtor).To(IsoDataFactory.Make<IPartyIdentification272>())
            .Set(x => x.DebtorAgent).To(ValidAgent("DEUTDEFFXXX"))
            .Set(x => x.CreditorAgent).To(ValidAgent("CHASUS33XXX"))
            .Set(x => x.Creditor).To(IsoDataFactory.Make<IPartyIdentification272>()));

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

    // ── Fields added to close the model gap found while scoping this message ────

    [Fact]
    public void AdditionalDateTime_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.AdditionalDateTime).To(IsoDataFactory.Make<IAdditionalDateTime1>(b2 => b2
                .Set(x2 => x2.ExpiryDateTime).To(new DateTime(2026, 2, 1)))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void MandateRelatedInformation_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.MandateRelatedInformation).To(IsoDataFactory.Make<ICreditTransferMandateData1>()));
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
    public void InitiatingParty_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.InitiatingParty).To(IsoDataFactory.Make<IPartyIdentification272>()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InstructingAgent_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.InstructingAgent).To(ValidAgent("BOFAUS3NXXX")));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InstructedAgent_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.InstructedAgent).To(ValidAgent("BOFAUS3NXXX")));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AgreedRate_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.AgreedRate).To(IsoDataFactory.Make<ICurrencyExchange26>(b2 => b2
            .Set(x2 => x2.PreAgreedExchangeRate).To(1.1m))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── Other optional building blocks ────────────────────────────────────────────

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
    public void UltimateDebtorAndUltimateCreditor_Present_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.UltimateDebtor).To(IsoDataFactory.Make<IPartyIdentification272>())
            .Set(x => x.UltimateCreditor).To(IsoDataFactory.Make<IPartyIdentification272>()));
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
    public void RegulatoryReportingAndTax_Present_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.RegulatoryReporting).To([IsoDataFactory.Make<IRegulatoryReporting10>(b2 => b2
                .Set(x2 => x2.DebitCreditReportingIndicator).To(RegulatoryReportingType1Code.Both))])
            .Set(x => x.Tax).To(IsoDataFactory.Make<ITaxData1>()));
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
