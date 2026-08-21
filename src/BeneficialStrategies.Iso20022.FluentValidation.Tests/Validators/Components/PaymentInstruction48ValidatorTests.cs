// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentInstruction48ValidatorTests
{
    private readonly PaymentInstruction48Validator _sut = new();

    private static CreditTransferTransaction74 ValidCreditTransferTransaction() =>
        new()
        {
            PaymentIdentification = new PaymentIdentification6 { EndToEndIdentification = "E2E-001" },
            Amount = new BeneficialStrategies.Iso20022.Choices.AmountType4Choice.InstructedAmount
            {
                Currency = "USD",
                Amount = 100m,
            },
            CreditorAgent = new BranchAndFinancialInstitutionIdentification8
            {
                FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
            },
            Creditor = new PartyIdentification272 { Name = "Creditor Co" },
        };

    private static PaymentInstruction48 ValidMessage() =>
        new()
        {
            PaymentMethod = PaymentMethod7Code.Cheque,
            Debtor = new PartyIdentification272 { Name = "Debtor Co" },
            DebtorAgent = new BranchAndFinancialInstitutionIdentification8
            {
                FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
            },
            CreditTransferTransaction = [ValidCreditTransferTransaction()],
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void EmptyCreditTransferTransaction_HasValidationError()
    {
        var msg = ValidMessage() with { CreditTransferTransaction = [] };
        var result = _sut.TestValidate(msg);
        result.ShouldHaveValidationErrorFor(x => x.CreditTransferTransaction);
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var account = new CashAccount40
        {
            Identification = new BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IBAN
            {
                Value = "DE89370400440532013000",
            },
        };
        var msg = ValidMessage() with
        {
            PaymentInformationIdentification = "PMTINF-001",
            RequestedAdviceType = new AdviceType1(),
            PaymentTypeInformation = new PaymentTypeInformation29(),
            RequestedExecutionDate = new BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice.Date
            {
                Value = new DateOnly(2026, 1, 1),
            },
            ExpiryDate = new BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice.Date
            {
                Value = new DateOnly(2026, 2, 1),
            },
            PaymentCondition = new PaymentCondition2(),
            DebtorAccount = account,
            DebtorAgentAccount = account,
            UltimateDebtor = new PartyIdentification272 { Name = "Ultimate Debtor Co" },
            ChargeBearer = ChargeBearerType1Code.BorneByDebtor,
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
