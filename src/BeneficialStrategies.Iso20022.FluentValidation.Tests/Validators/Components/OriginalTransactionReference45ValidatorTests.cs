// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OriginalTransactionReference45ValidatorTests
{
    private readonly OriginalTransactionReference45Validator _sut = new();

    private static BranchAndFinancialInstitutionIdentification8 ValidAgent(string bic) =>
        new() { FinancialInstitutionIdentification = new FinancialInstitutionIdentification23 { BICFI = bic } };

    private static BeneficialStrategies.Iso20022.Choices.Party50Choice_ ValidParty() =>
        new BeneficialStrategies.Iso20022.Choices.Party50Choice.Party { Value = new PartyIdentification272() };

    private static CashAccount40 ValidAccount(string id = "ACC-001") =>
        new() { Identification = new Choices.AccountIdentification4Choice.Other { Identification = id } };

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new OriginalTransactionReference45()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InterbankSettlementAmount_InvalidCurrency_HasValidationError()
    {
        var msg = new OriginalTransactionReference45
        {
            InterbankSettlementAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "eur", Amount = 100m },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "InterbankSettlementAmount.Currency");
    }

    [Fact]
    public void InterbankSettlementAmount_ZeroAmount_HasValidationError()
    {
        var msg = new OriginalTransactionReference45
        {
            InterbankSettlementAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "EUR", Amount = 0m },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "InterbankSettlementAmount.Amount");
    }

    [Fact]
    public void InterbankSettlementAmount_Valid_NoValidationError()
    {
        var msg = new OriginalTransactionReference45
        {
            InterbankSettlementAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "EUR", Amount = 100m },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AmountAndRequestedExecutionDate_Present_NoValidationErrors()
    {
        var msg = new OriginalTransactionReference45
        {
            Amount = new BeneficialStrategies.Iso20022.Choices.AmountType4Choice.InstructedAmount
            {
                Currency = "EUR",
                Amount = 50m,
            },
            RequestedExecutionDate = new BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice.Date
            {
                Value = new DateOnly(2026, 1, 1),
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void CreditorSchemeIdentificationAndSettlementInformation_Present_NoValidationErrors()
    {
        var msg = new OriginalTransactionReference45
        {
            CreditorSchemeIdentification = new PartyIdentification272(),
            SettlementInformation = new SettlementInstruction15 { SettlementMethod = SettlementMethod1Code.ClearingSystem },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PaymentTypeInformationAndMandateRelatedInformation_Present_NoValidationErrors()
    {
        var msg = new OriginalTransactionReference45
        {
            PaymentTypeInformation = new PaymentTypeInformation27(),
            MandateRelatedInformation = new BeneficialStrategies.Iso20022.Choices.MandateRelatedData5Choice.CreditTransferMandate
            {
                Value = new CreditTransferMandateData1(),
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void RemittanceInformation_Present_NoValidationError()
    {
        var msg = new OriginalTransactionReference45 { RemittanceInformation = new RemittanceInformation26() };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PartiesAndAccounts_Present_NoValidationErrors()
    {
        var msg = new OriginalTransactionReference45
        {
            UltimateDebtor = ValidParty(),
            Debtor = ValidParty(),
            DebtorAccount = ValidAccount(),
            DebtorAgent = ValidAgent("DEUTDEFFXXX"),
            DebtorAgentAccount = ValidAccount(),
            CreditorAgent = ValidAgent("CHASUS33XXX"),
            CreditorAgentAccount = ValidAccount(),
            Creditor = ValidParty(),
            CreditorAccount = ValidAccount(),
            UltimateCreditor = ValidParty(),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Purpose_Present_NoValidationError()
    {
        var msg = new OriginalTransactionReference45
        {
            Purpose = new BeneficialStrategies.Iso20022.Choices.Purpose2Choice.Proprietary { Value = "MYPURPOSE" },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void UnderlyingCustomerCreditTransfer_Present_NoValidationError()
    {
        var msg = new OriginalTransactionReference45
        {
            UnderlyingCustomerCreditTransfer = new CreditTransferTransaction72
            {
                Debtor = new PartyIdentification272(),
                DebtorAgent = ValidAgent("DEUTDEFFXXX"),
                CreditorAgent = ValidAgent("CHASUS33XXX"),
                Creditor = new PartyIdentification272(),
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void UnderlyingFinancialInstitutionCreditTransfer_Present_NoValidationError()
    {
        var msg = new OriginalTransactionReference45
        {
            UnderlyingFinancialInstitutionCreditTransfer = new CreditTransferTransaction82
            {
                PaymentIdentification = new PaymentIdentification13 { EndToEndIdentification = "E2E-003" },
                InterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 10m },
                Debtor = ValidAgent("DEUTDEFFXXX"),
                Creditor = ValidAgent("CHASUS33XXX"),
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
