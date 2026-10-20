// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CreditTransferTransaction66ValidatorTests
{
    private readonly CreditTransferTransaction66Validator _sut = new();

    private static IBranchAndFinancialInstitutionIdentification8 ValidAgent(string bic) =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>(b2 => b2
            .Set(x2 => x2.BICFI).To(bic))));

    private static IDirectDebitTransactionInformation33 ValidDirectDebitTransactionInformation() =>
        IsoDataFactory.Make<IDirectDebitTransactionInformation33>(b => b
            .Set(x => x.PaymentIdentification).To(IsoDataFactory.Make<IPaymentIdentification13>(b2 => b2
                .Set(x2 => x2.EndToEndIdentification).To("E2E-001")))
            .Set(x => x.Debtor).To(ValidAgent("DEUTDEFFXXX"))
            .Set(x => x.InterbankSettlementAmount).To(new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m }));

    private static ICreditTransferTransaction66 ValidMessage() =>
        IsoDataFactory.Make<ICreditTransferTransaction66>(b => b
            .Set(x => x.CreditIdentification).To("CDT-001")
            .Set(x => x.Creditor).To(ValidAgent("BOFAUS3NXXX"))
            .Set(x => x.DirectDebitTransactionInformation).To([ValidDirectDebitTransactionInformation()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── DirectDebitTransactionInformation minimum-count (1..∞) ───────────────────

    [Fact]
    public void DirectDebitTransactionInformation_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.DirectDebitTransactionInformation).To([]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "DirectDebitTransactionInformation");
    }

    // ── TotalInterbankSettlementAmount ────────────────────────────────────────────

    [Fact]
    public void TotalInterbankSettlementAmount_UnsetCurrency_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.TotalInterbankSettlementAmount).To(new ActiveCurrencyAndAmount { Currency = default, Amount = 100m }));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalInterbankSettlementAmount.Currency");
    }

    [Fact]
    public void TotalInterbankSettlementAmount_ZeroAmount_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.TotalInterbankSettlementAmount).To(new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 0m }));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalInterbankSettlementAmount.Amount");
    }

    [Fact]
    public void TotalInterbankSettlementAmount_Valid_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.TotalInterbankSettlementAmount).To(new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m }));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── Optional agent/account building blocks ───────────────────────────────────

    [Theory]
    [InlineData("CreditorAgent")]
    [InlineData("CreditorAgentAccount")]
    [InlineData("CreditorAccount")]
    [InlineData("UltimateCreditor")]
    [InlineData("InstructingAgent")]
    [InlineData("InstructedAgent")]
    [InlineData("IntermediaryAgent1")]
    [InlineData("IntermediaryAgent1Account")]
    [InlineData("IntermediaryAgent2")]
    [InlineData("IntermediaryAgent2Account")]
    [InlineData("IntermediaryAgent3")]
    [InlineData("IntermediaryAgent3Account")]
    public void OptionalAgentOrAccountFields_Present_NoValidationErrors(string fieldName)
    {
        var msg = fieldName switch
        {
            "CreditorAgent" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.CreditorAgent).To(ValidAgent("CHASUS33XXX"))),
            "CreditorAgentAccount" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.CreditorAgentAccount).To(ValidIban())),
            "CreditorAccount" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.CreditorAccount).To(ValidIban())),
            "UltimateCreditor" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.UltimateCreditor).To(ValidAgent("CHASUS33XXX"))),
            "InstructingAgent" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.InstructingAgent).To(ValidAgent("CHASUS33XXX"))),
            "InstructedAgent" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.InstructedAgent).To(ValidAgent("CHASUS33XXX"))),
            "IntermediaryAgent1" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.IntermediaryAgent1).To(ValidAgent("CHASUS33XXX"))),
            "IntermediaryAgent1Account" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.IntermediaryAgent1Account).To(ValidIban())),
            "IntermediaryAgent2" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.IntermediaryAgent2).To(ValidAgent("CHASUS33XXX"))),
            "IntermediaryAgent2Account" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.IntermediaryAgent2Account).To(ValidIban())),
            "IntermediaryAgent3" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.IntermediaryAgent3).To(ValidAgent("CHASUS33XXX"))),
            "IntermediaryAgent3Account" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.IntermediaryAgent3Account).To(ValidIban())),
            _ => throw new ArgumentOutOfRangeException(nameof(fieldName)),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    private static ICashAccount40 ValidIban() =>
        IsoDataFactory.Make<ICashAccount40>(b => b
            .Set(x => x.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IIBAN>(b2 => b2
                .Set(x2 => x2.Value).To("DE89370400440532013000"))));

    [Fact]
    public void PaymentTypeInformation_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.PaymentTypeInformation).To(IsoDataFactory.Make<IPaymentTypeInformation28>()));
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
    public void InstructionForCreditorAgent_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.InstructionForCreditorAgent).To([IsoDataFactory.Make<IInstructionForCreditorAgent3>()]));
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
