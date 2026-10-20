// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentInstruction51ValidatorTests
{
    private readonly PaymentInstruction51Validator _sut = new();

    private static CreditTransferTransaction76 ValidCreditTransferTransaction() =>
        new()
        {
            PaymentIdentification = new PaymentIdentification6 { EndToEndIdentification = "E2E-001" },
            Amount = new BeneficialStrategies.Iso20022.Choices.AmountType4Choice.InstructedAmount
            {
                Currency = "USD",
                Amount = 100m,
            },
        };

    private static PaymentInstruction51 ValidMessage() =>
        new()
        {
            PaymentInformationIdentification = "PMTINF-001",
            PaymentMethod = PaymentMethod3Code.CreditTransfer,
            RequestedExecutionDate = new BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice.Date
            {
                Value = new DateOnly(2026, 1, 1),
            },
            Debtor = new PartyIdentification272 { Name = "Debtor Co" },
            DebtorAccount = new CashAccount40
            {
                Identification = new BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IBAN
                {
                    Value = "DE89370400440532013000",
                },
            },
            DebtorAgent = new BranchAndFinancialInstitutionIdentification8
            {
                FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
            },
            CreditTransferTransactionInformation = [ValidCreditTransferTransaction()],
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void EmptyCreditTransferTransactionInformation_HasValidationError()
    {
        var msg = ValidMessage() with { CreditTransferTransactionInformation = [] };
        var result = _sut.TestValidate(msg);
        result.ShouldHaveValidationErrorFor(x => x.CreditTransferTransactionInformation);
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var account = ValidMessage().DebtorAccount;
        var msg = ValidMessage() with
        {
            RequestedAdviceType = new AdviceType1(),
            BatchBooking = true,
            NumberOfTransactions = "1",
            ControlSum = 100.00m,
            PaymentTypeInformation = new PaymentTypeInformation26(),
            PoolingAdjustmentDate = new DateOnly(2026, 1, 1),
            DebtorAgentAccount = account,
            InstructionForDebtorAgent = "Contact debtor first",
            UltimateDebtor = new PartyIdentification272 { Name = "Ultimate Debtor Co" },
            ChargeBearer = ChargeBearerType1Code.BorneByDebtor,
            ChargesAccount = account,
            ChargesAccountAgent = new BranchAndFinancialInstitutionIdentification8
            {
                FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
