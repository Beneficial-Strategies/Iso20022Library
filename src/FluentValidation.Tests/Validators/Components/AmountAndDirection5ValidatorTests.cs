// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class AmountAndDirection5ValidatorTests
{
    private readonly AmountAndDirection5Validator _sut = new();

    private static AmountAndDirection5 ValidMessage() =>
        new() { Amount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m } };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void CreditDebit_Present_NoValidationError()
    {
        var msg = ValidMessage() with { CreditDebit = CreditDebitCode.Credit };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── Amount.Currency ──────────────────────────────────────────────────────

    [Fact]
    public void Currency_Unset_HasValidationError()
    {
        // a bad code cannot be built (ActiveCurrencyCode checks its pattern); an unset one still can
        var msg = ValidMessage() with { Amount = ValidMessage().Amount with { Currency = default } };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "Amount.Currency");
    }

    [Fact]
    public void Currency_Valid_NoValidationError()
    {
        var msg = ValidMessage() with { Amount = ValidMessage().Amount with { Currency = "USD" } };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "Amount.Currency");
    }

    // ── Amount.Amount ─────────────────────────────────────────────────────────

    [Fact]
    public void Amount_Zero_HasValidationError()
    {
        var msg = ValidMessage() with { Amount = ValidMessage().Amount with { Amount = 0m } };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "Amount.Amount");
    }

    [Fact]
    public void Amount_Negative_HasValidationError()
    {
        var msg = ValidMessage() with { Amount = ValidMessage().Amount with { Amount = -1m } };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "Amount.Amount");
    }

    [Fact]
    public void Amount_Positive_NoValidationError()
    {
        var msg = ValidMessage() with { Amount = ValidMessage().Amount with { Amount = 0.01m } };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "Amount.Amount");
    }
}
