// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class AccountNotification26ValidatorTests
{
    private readonly AccountNotification26Validator _sut = new();

    private static Choices.Party50Choice.Agent ValidDebtor() =>
        new()
        {
            Value = new BranchAndFinancialInstitutionIdentification8
            {
                FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
            },
        };

    private static BranchAndFinancialInstitutionIdentification8 ValidAgent() =>
        new() { FinancialInstitutionIdentification = new FinancialInstitutionIdentification23() };

    private static CashAccount40 ValidAccount(string id = "ACC-001") =>
        new()
        {
            Identification = new Choices.AccountIdentification4Choice.Other { Identification = id },
        };

    private static NotificationItem10 MinimalItem(string currency = "USD", decimal amount = 100m) =>
        new()
        {
            Identification = "ITEM-001",
            Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = currency, Amount = amount },
        };

    private static AccountNotification26 ValidMessage() =>
        new()
        {
            Identification = "NOTIF-001",
            Debtor = ValidDebtor(),
            Item = [MinimalItem()],
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── Item: 1..* ────────────────────────────────────────────────────────────

    [Fact]
    public void Item_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { Item = [] };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.Item);
    }

    // ── DebtorRule: Either Debtor or Item/Debtor may be present but not both ────

    [Fact]
    public void DebtorAndItemDebtor_Violates_DebtorRule()
    {
        var msg = ValidMessage() with { Item = [MinimalItem() with { Debtor = ValidDebtor() }] };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "DebtorRule");
    }

    [Fact]
    public void DebtorOnly_DoesNotViolate_DebtorRule()
    {
        var result = _sut.Validate(ValidMessage());
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "DebtorRule");
    }

    // ── DebtorAgentRule ───────────────────────────────────────────────────────

    [Fact]
    public void DebtorAgentAndItemDebtorAgent_Violates_DebtorAgentRule()
    {
        var msg = ValidMessage() with
        {
            DebtorAgent = ValidAgent(),
            Item = [MinimalItem() with { DebtorAgent = ValidAgent() }],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "DebtorAgentRule");
    }

    [Fact]
    public void DebtorAgentOnly_DoesNotViolate_DebtorAgentRule()
    {
        var msg = ValidMessage() with { DebtorAgent = ValidAgent() };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "DebtorAgentRule");
    }

    // ── IntermediaryAgentRule ────────────────────────────────────────────────

    [Fact]
    public void IntermediaryAgentAndItemIntermediaryAgent_Violates_IntermediaryAgentRule()
    {
        var msg = ValidMessage() with
        {
            DebtorAgent = ValidAgent(),
            IntermediaryAgent = ValidAgent(),
            Item = [MinimalItem() with { IntermediaryAgent = ValidAgent() }],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "IntermediaryAgentRule");
    }

    [Fact]
    public void IntermediaryAgentOnly_DoesNotViolate_IntermediaryAgentRule()
    {
        var msg = ValidMessage() with { DebtorAgent = ValidAgent(), IntermediaryAgent = ValidAgent() };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "IntermediaryAgentRule");
    }

    // ── MandatoryDebtorRule: Debtor must be present or Item/Debtor must be present ──

    [Fact]
    public void NeitherDebtor_Violates_MandatoryDebtorRule()
    {
        var msg = ValidMessage() with { Debtor = null };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "MandatoryDebtorRule");
    }

    [Fact]
    public void ItemDebtorForEveryItem_DoesNotViolate_MandatoryDebtorRule()
    {
        var msg = ValidMessage() with { Debtor = null, Item = [MinimalItem() with { Debtor = ValidDebtor() }] };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "MandatoryDebtorRule");
    }

    // ── IntermediaryAgentAndDebtorAgentRule ──────────────────────────────────

    [Fact]
    public void IntermediaryAgentWithoutDebtorAgent_Violates_IntermediaryAgentAndDebtorAgentRule()
    {
        var msg = ValidMessage() with { IntermediaryAgent = ValidAgent() };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "IntermediaryAgentAndDebtorAgentRule");
    }

    [Fact]
    public void IntermediaryAgentWithDebtorAgent_DoesNotViolate_IntermediaryAgentAndDebtorAgentRule()
    {
        var msg = ValidMessage() with { IntermediaryAgent = ValidAgent(), DebtorAgent = ValidAgent() };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "IntermediaryAgentAndDebtorAgentRule");
    }

    // ── TotalAmountAndAmount1Rule: currency must match TotalAmount ──────────

    [Fact]
    public void TotalAmountCurrencyMismatch_Violates_TotalAmountAndAmount1Rule()
    {
        var msg = ValidMessage() with
        {
            TotalAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "EUR", Amount = 100m },
            Item = [MinimalItem(currency: "USD", amount: 100m)],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalAmountAndAmount1Rule");
    }

    [Fact]
    public void TotalAmountCurrencyMatches_DoesNotViolate_TotalAmountAndAmount1Rule()
    {
        var msg = ValidMessage() with
        {
            TotalAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m },
            Item = [MinimalItem(currency: "USD", amount: 100m)],
        };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "TotalAmountAndAmount1Rule");
    }

    // ── AccountAndCurrencyRule: all Item/Amount share the same currency ─────

    [Fact]
    public void AccountPresentWithMixedItemCurrencies_Violates_AccountAndCurrencyRule()
    {
        var msg = ValidMessage() with
        {
            Account = ValidAccount(),
            Item = [MinimalItem(currency: "USD"), MinimalItem(currency: "EUR")],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "AccountAndCurrencyRule");
    }

    [Fact]
    public void AccountPresentWithConsistentItemCurrencies_DoesNotViolate_AccountAndCurrencyRule()
    {
        var msg = ValidMessage() with
        {
            Account = ValidAccount(),
            Item = [MinimalItem(currency: "USD"), MinimalItem(currency: "USD")],
        };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "AccountAndCurrencyRule");
    }

    // ── TotalAmountAndAmount2Rule: TotalAmount must equal sum of Item/Amount ─

    [Fact]
    public void TotalAmountNotEqualToSum_Violates_TotalAmountAndAmount2Rule()
    {
        var msg = ValidMessage() with
        {
            TotalAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 999m },
            Item = [MinimalItem(amount: 100m)],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalAmountAndAmount2Rule");
    }

    [Fact]
    public void TotalAmountEqualToSum_DoesNotViolate_TotalAmountAndAmount2Rule()
    {
        var msg = ValidMessage() with
        {
            TotalAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m },
            Item = [MinimalItem(amount: 100m)],
        };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "TotalAmountAndAmount2Rule");
    }

    // ── AccountRule ───────────────────────────────────────────────────────────

    [Fact]
    public void AccountAndItemAccount_Violates_AccountRule()
    {
        var msg = ValidMessage() with
        {
            Account = ValidAccount(),
            Item = [MinimalItem() with { Account = ValidAccount() }],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "AccountRule");
    }

    [Fact]
    public void AccountOnly_DoesNotViolate_AccountRule()
    {
        var msg = ValidMessage() with { Account = ValidAccount() };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "AccountRule");
    }

    // ── AccountOwnerRule ─────────────────────────────────────────────────────

    [Fact]
    public void AccountOwnerAndItemAccountOwner_Violates_AccountOwnerRule()
    {
        var msg = ValidMessage() with
        {
            AccountOwner = ValidDebtor(),
            Item = [MinimalItem() with { AccountOwner = ValidDebtor() }],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "AccountOwnerRule");
    }

    [Fact]
    public void AccountOwnerOnly_DoesNotViolate_AccountOwnerRule()
    {
        var msg = ValidMessage() with { AccountOwner = ValidDebtor() };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "AccountOwnerRule");
    }

    // ── AccountServicerRule ──────────────────────────────────────────────────

    [Fact]
    public void AccountServicerAndItemAccountServicer_Violates_AccountServicerRule()
    {
        var msg = ValidMessage() with
        {
            AccountServicer = ValidAgent(),
            Item = [MinimalItem() with { AccountServicer = ValidAgent() }],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "AccountServicerRule");
    }

    [Fact]
    public void AccountServicerOnly_DoesNotViolate_AccountServicerRule()
    {
        var msg = ValidMessage() with { AccountServicer = ValidAgent() };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "AccountServicerRule");
    }

    // ── ExpectedValueDateRule ────────────────────────────────────────────────

    [Fact]
    public void ExpectedValueDateAndItemExpectedValueDate_Violates_ExpectedValueDateRule()
    {
        var date = new DateOnly(2026, 8, 13);
        var msg = ValidMessage() with
        {
            ExpectedValueDate = date,
            Item = [MinimalItem() with { ExpectedValueDate = date }],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "ExpectedValueDateRule");
    }

    [Fact]
    public void ExpectedValueDateOnly_DoesNotViolate_ExpectedValueDateRule()
    {
        var msg = ValidMessage() with { ExpectedValueDate = new DateOnly(2026, 8, 13) };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ExpectedValueDateRule");
    }

    // ── RelatedAccountRule ───────────────────────────────────────────────────

    [Fact]
    public void RelatedAccountAndItemRelatedAccount_Violates_RelatedAccountRule()
    {
        var msg = ValidMessage() with
        {
            RelatedAccount = ValidAccount("PARENT-001"),
            Item = [MinimalItem() with { RelatedAccount = ValidAccount("PARENT-001") }],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "RelatedAccountRule");
    }

    [Fact]
    public void RelatedAccountOnly_DoesNotViolate_RelatedAccountRule()
    {
        var msg = ValidMessage() with { RelatedAccount = ValidAccount("PARENT-001") };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "RelatedAccountRule");
    }
}
