// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class LiquidityDebitTransfer4ValidatorTests
{
    private readonly LiquidityDebitTransfer4Validator _sut = new();

    private static BeneficialStrategies.Iso20022.Choices.Amount2Choice_ ValidAmount() =>
        new BeneficialStrategies.Iso20022.Choices.Amount2Choice.AmountWithCurrency { Currency = "USD", Amount = 100m };

    private static LiquidityDebitTransfer4 ValidMessage() => new() { TransferredAmount = ValidAmount() };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
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
        var msg = ValidMessage() with
        {
            Creditor = agent,
            CreditorAccount = account,
            Debtor = agent,
            DebtorAccount = account,
            LiquidityTransferIdentification = new PaymentIdentification8 { EndToEndIdentification = "E2E-001" },
            SettlementDate = new DateOnly(2026, 1, 1),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
