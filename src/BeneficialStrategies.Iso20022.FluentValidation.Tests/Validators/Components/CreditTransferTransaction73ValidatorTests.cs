// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CreditTransferTransaction73ValidatorTests
{
    private readonly CreditTransferTransaction73Validator _sut = new();

    private static BranchAndFinancialInstitutionIdentification8 ValidAgent(string bic) =>
        new() { FinancialInstitutionIdentification = new FinancialInstitutionIdentification23 { BICFI = bic } };

    private static CreditTransferTransaction73 ValidMessage() =>
        new()
        {
            PaymentIdentification = new PaymentIdentification13 { EndToEndIdentification = "E2E-001" },
            InterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m },
            ChargeBearer = ChargeBearerType1Code.Shared,
            Debtor = new PartyIdentification272(),
            DebtorAgent = ValidAgent("DEUTDEFFXXX"),
            CreditorAgent = ValidAgent("CHASUS33XXX"),
            Creditor = new PartyIdentification272(),
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── InterbankSettlementAmount (required) ─────────────────────────────────────

    [Fact]
    public void InterbankSettlementAmount_InvalidCurrency_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            InterbankSettlementAmount = ValidMessage().InterbankSettlementAmount with { Currency = "eur" },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "InterbankSettlementAmount.Currency");
    }

    [Fact]
    public void InterbankSettlementAmount_ZeroAmount_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            InterbankSettlementAmount = ValidMessage().InterbankSettlementAmount with { Amount = 0m },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "InterbankSettlementAmount.Amount");
    }

    // ── InstructedAmount (optional) ───────────────────────────────────────────────

    [Fact]
    public void InstructedAmount_Valid_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            InstructedAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 50m },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InstructedAmount_ZeroAmount_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            InstructedAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 0m },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "InstructedAmount.Amount");
    }

    // ── Fields added to close the model gap found while scoping this message ────

    [Fact]
    public void AdditionalDateTime_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            AdditionalDateTime = new AdditionalDateTime1 { ExpiryDateTime = new DateTime(2026, 2, 1) },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void MandateRelatedInformation_Present_NoValidationError()
    {
        var msg = ValidMessage() with { MandateRelatedInformation = new CreditTransferMandateData1() };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PaymentSignature_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            PaymentSignature = new BeneficialStrategies.Iso20022.Choices.CryptographicKey1Choice.Signature
            {
                Value = new string('A', 64),
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InitiatingParty_Present_NoValidationError()
    {
        var msg = ValidMessage() with { InitiatingParty = new PartyIdentification272() };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InstructingAgent_Present_NoValidationError()
    {
        var msg = ValidMessage() with { InstructingAgent = ValidAgent("BOFAUS3NXXX") };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InstructedAgent_Present_NoValidationError()
    {
        var msg = ValidMessage() with { InstructedAgent = ValidAgent("BOFAUS3NXXX") };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AgreedRate_Present_NoValidationError()
    {
        var msg = ValidMessage() with { AgreedRate = new CurrencyExchange26 { PreAgreedExchangeRate = 1.1m } };
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
            "PreviousInstructingAgent1" => ValidMessage() with { PreviousInstructingAgent1 = ValidAgent("BOFAUS3NXXX") },
            "PreviousInstructingAgent2" => ValidMessage() with { PreviousInstructingAgent2 = ValidAgent("BOFAUS3NXXX") },
            "PreviousInstructingAgent3" => ValidMessage() with { PreviousInstructingAgent3 = ValidAgent("BOFAUS3NXXX") },
            "IntermediaryAgent1" => ValidMessage() with { IntermediaryAgent1 = ValidAgent("BOFAUS3NXXX") },
            "IntermediaryAgent2" => ValidMessage() with { IntermediaryAgent2 = ValidAgent("BOFAUS3NXXX") },
            "IntermediaryAgent3" => ValidMessage() with { IntermediaryAgent3 = ValidAgent("BOFAUS3NXXX") },
            _ => throw new ArgumentOutOfRangeException(nameof(fieldName)),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ChargesInformation_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            ChargesInformation =
            [
                new Charges16
                {
                    Agent = ValidAgent("BOFAUS3NXXX"),
                    Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "EUR", Amount = 5m },
                },
            ],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void UltimateDebtorAndUltimateCreditor_Present_NoValidationErrors()
    {
        var msg = ValidMessage() with
        {
            UltimateDebtor = new PartyIdentification272(),
            UltimateCreditor = new PartyIdentification272(),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InstructionForCreditorAgentAndNextAgent_Present_NoValidationErrors()
    {
        var msg = ValidMessage() with
        {
            InstructionForCreditorAgent = [new InstructionForCreditorAgent3()],
            InstructionForNextAgent = [new InstructionForNextAgent1()],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void RegulatoryReportingAndTax_Present_NoValidationErrors()
    {
        var msg = ValidMessage() with
        {
            RegulatoryReporting = [new RegulatoryReporting10 { DebitCreditReportingIndicator = RegulatoryReportingType1Code.Both }],
            Tax = new TaxData1(),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void RelatedRemittanceInformationAndRemittanceInformation_Present_NoValidationErrors()
    {
        var msg = ValidMessage() with
        {
            RelatedRemittanceInformation = [new RemittanceLocation8()],
            RemittanceInformation = new RemittanceInformation22(),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SupplementaryData_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            SupplementaryData = [new SupplementaryData1 { Envelope = new SupplementaryDataEnvelope1() }],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
