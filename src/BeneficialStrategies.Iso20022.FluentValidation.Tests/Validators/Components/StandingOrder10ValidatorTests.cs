// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class StandingOrder10ValidatorTests
{
    private readonly StandingOrder10Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new StandingOrder10()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var agent = new BranchAndFinancialInstitutionIdentification8
        {
            FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
        };
        var account = new CashAccount40
        {
            Identification = new BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IBAN
            {
                Value = "DE89370400440532013000",
            },
        };
        var msg = new StandingOrder10
        {
            Amount = new BeneficialStrategies.Iso20022.Choices.Amount2Choice.AmountWithCurrency
            {
                Currency = "USD",
                Amount = 100m,
            },
            Creditor = agent,
            CreditorAccount = account,
            Debtor = agent,
            DebtorAccount = account,
            ExecutionType = new BeneficialStrategies.Iso20022.Choices.ExecutionType1Choice.Event(),
            Frequency = Frequency2Code.Monthly,
            ValidityPeriod = new BeneficialStrategies.Iso20022.Choices.DatePeriod2Choice.FromDate
            {
                Value = new DateOnly(2026, 1, 1),
            },
            ZeroSweepIndicator = true,
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
