// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class AccountNotification23ValidatorTests
{
    private readonly AccountNotification23Validator _sut = new();

    private static Choices.Party50Choice.IAgent ValidDebtor() =>
        IsoDataFactory.Make<Choices.Party50Choice.IAgent>(b => b
            .Set(x => x.Value).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b2 => b2
                .Set(x2 => x2.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>()))));

    private static IBranchAndFinancialInstitutionIdentification8 ValidAgent() =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>()));

    private static ICashAccount40 ValidAccount(string id = "ACC-001") =>
        IsoDataFactory.Make<ICashAccount40>(b => b
            .Set(x => x.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IOther>(b2 => b2
                .Set(x2 => x2.Identification).To(id))));

    private static INotificationItem9 MinimalItem(string currency = "USD", decimal amount = 100m) =>
        IsoDataFactory.Make<INotificationItem9>(b => b
            .Set(x => x.Identification).To("ITEM-001")
            .Set(x => x.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = currency, Amount = amount }));

    private static IAccountNotification23 ValidMessage() =>
        IsoDataFactory.Make<IAccountNotification23>(b => b
            .Set(x => x.Identification).To("NOTIF-001")
            .Set(x => x.Debtor).To(ValidDebtor())
            .Set(x => x.Item).To([MinimalItem()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── Item: 1..* ────────────────────────────────────────────────────────────

    [Fact]
    public void Item_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Item).To([]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.Item);
    }

    // ── DebtorRule: Either Debtor or Item/Debtor may be present but not both ────

    [Fact]
    public void DebtorAndItemDebtor_Violates_DebtorRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Item).To([IsoDataFactory.With(MinimalItem(), b2 => b2
            .Set(x2 => x2.Debtor).To(ValidDebtor()))]));
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
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.DebtorAgent).To(ValidAgent())
            .Set(x => x.Item).To([IsoDataFactory.With(MinimalItem(), b2 => b2
                .Set(x2 => x2.DebtorAgent).To(ValidAgent()))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "DebtorAgentRule");
    }

    [Fact]
    public void DebtorAgentOnly_DoesNotViolate_DebtorAgentRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.DebtorAgent).To(ValidAgent()));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "DebtorAgentRule");
    }

    // ── IntermediaryAgentRule ────────────────────────────────────────────────

    [Fact]
    public void IntermediaryAgentAndItemIntermediaryAgent_Violates_IntermediaryAgentRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.DebtorAgent).To(ValidAgent())
            .Set(x => x.IntermediaryAgent).To(ValidAgent())
            .Set(x => x.Item).To([IsoDataFactory.With(MinimalItem(), b2 => b2
                .Set(x2 => x2.IntermediaryAgent).To(ValidAgent()))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "IntermediaryAgentRule");
    }

    [Fact]
    public void IntermediaryAgentOnly_DoesNotViolate_IntermediaryAgentRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.DebtorAgent).To(ValidAgent())
            .Set(x => x.IntermediaryAgent).To(ValidAgent()));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "IntermediaryAgentRule");
    }

    // ── MandatoryDebtorRule: Debtor must be present or Item/Debtor must be present ──

    [Fact]
    public void NeitherDebtor_Violates_MandatoryDebtorRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Debtor).To(null));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "MandatoryDebtorRule");
    }

    [Fact]
    public void ItemDebtorForEveryItem_DoesNotViolate_MandatoryDebtorRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Debtor).To(null)
            .Set(x => x.Item).To([IsoDataFactory.With(MinimalItem(), b2 => b2
            .Set(x2 => x2.Debtor).To(ValidDebtor()))]));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "MandatoryDebtorRule");
    }

    // ── IntermediaryAgentAndDebtorAgentRule ──────────────────────────────────

    [Fact]
    public void IntermediaryAgentWithoutDebtorAgent_Violates_IntermediaryAgentAndDebtorAgentRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.IntermediaryAgent).To(ValidAgent()));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "IntermediaryAgentAndDebtorAgentRule");
    }

    [Fact]
    public void IntermediaryAgentWithDebtorAgent_DoesNotViolate_IntermediaryAgentAndDebtorAgentRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.IntermediaryAgent).To(ValidAgent())
            .Set(x => x.DebtorAgent).To(ValidAgent()));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "IntermediaryAgentAndDebtorAgentRule");
    }

    // ── TotalAmountAndAmount1Rule: currency must match TotalAmount ──────────

    [Fact]
    public void TotalAmountCurrencyMismatch_Violates_TotalAmountAndAmount1Rule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.TotalAmount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "EUR", Amount = 100m })
            .Set(x => x.Item).To([MinimalItem(currency: "USD", amount: 100m)]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalAmountAndAmount1Rule");
    }

    [Fact]
    public void TotalAmountCurrencyMatches_DoesNotViolate_TotalAmountAndAmount1Rule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.TotalAmount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m })
            .Set(x => x.Item).To([MinimalItem(currency: "USD", amount: 100m)]));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "TotalAmountAndAmount1Rule");
    }

    // ── AccountAndCurrencyRule: all Item/Amount share the same currency ─────

    [Fact]
    public void AccountPresentWithMixedItemCurrencies_Violates_AccountAndCurrencyRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Account).To(ValidAccount())
            .Set(x => x.Item).To([MinimalItem(currency: "USD"), MinimalItem(currency: "EUR")]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "AccountAndCurrencyRule");
    }

    [Fact]
    public void AccountPresentWithConsistentItemCurrencies_DoesNotViolate_AccountAndCurrencyRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Account).To(ValidAccount())
            .Set(x => x.Item).To([MinimalItem(currency: "USD"), MinimalItem(currency: "USD")]));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "AccountAndCurrencyRule");
    }

    // ── TotalAmountAndAmount2Rule: TotalAmount must equal sum of Item/Amount ─

    [Fact]
    public void TotalAmountNotEqualToSum_Violates_TotalAmountAndAmount2Rule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.TotalAmount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 999m })
            .Set(x => x.Item).To([MinimalItem(amount: 100m)]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalAmountAndAmount2Rule");
    }

    [Fact]
    public void TotalAmountEqualToSum_DoesNotViolate_TotalAmountAndAmount2Rule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.TotalAmount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m })
            .Set(x => x.Item).To([MinimalItem(amount: 100m)]));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "TotalAmountAndAmount2Rule");
    }

    // ── AccountRule ───────────────────────────────────────────────────────────

    [Fact]
    public void AccountAndItemAccount_Violates_AccountRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Account).To(ValidAccount())
            .Set(x => x.Item).To([IsoDataFactory.With(MinimalItem(), b2 => b2
                .Set(x2 => x2.Account).To(ValidAccount()))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "AccountRule");
    }

    [Fact]
    public void AccountOnly_DoesNotViolate_AccountRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Account).To(ValidAccount()));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "AccountRule");
    }

    // ── AccountOwnerRule ─────────────────────────────────────────────────────

    [Fact]
    public void AccountOwnerAndItemAccountOwner_Violates_AccountOwnerRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.AccountOwner).To(ValidDebtor())
            .Set(x => x.Item).To([IsoDataFactory.With(MinimalItem(), b2 => b2
                .Set(x2 => x2.AccountOwner).To(ValidDebtor()))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "AccountOwnerRule");
    }

    [Fact]
    public void AccountOwnerOnly_DoesNotViolate_AccountOwnerRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.AccountOwner).To(ValidDebtor()));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "AccountOwnerRule");
    }

    // ── AccountServicerRule ──────────────────────────────────────────────────

    [Fact]
    public void AccountServicerAndItemAccountServicer_Violates_AccountServicerRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.AccountServicer).To(ValidAgent())
            .Set(x => x.Item).To([IsoDataFactory.With(MinimalItem(), b2 => b2
                .Set(x2 => x2.AccountServicer).To(ValidAgent()))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "AccountServicerRule");
    }

    [Fact]
    public void AccountServicerOnly_DoesNotViolate_AccountServicerRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.AccountServicer).To(ValidAgent()));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "AccountServicerRule");
    }

    // ── ExpectedValueDateRule ────────────────────────────────────────────────

    [Fact]
    public void ExpectedValueDateAndItemExpectedValueDate_Violates_ExpectedValueDateRule()
    {
        var date = new DateOnly(2026, 8, 13);
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ExpectedValueDate).To(date)
            .Set(x => x.Item).To([IsoDataFactory.With(MinimalItem(), b2 => b2
                .Set(x2 => x2.ExpectedValueDate).To(date))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "ExpectedValueDateRule");
    }

    [Fact]
    public void ExpectedValueDateOnly_DoesNotViolate_ExpectedValueDateRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ExpectedValueDate).To(new DateOnly(2026, 8, 13)));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ExpectedValueDateRule");
    }

    // ── RelatedAccountRule ───────────────────────────────────────────────────

    [Fact]
    public void RelatedAccountAndItemRelatedAccount_Violates_RelatedAccountRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.RelatedAccount).To(ValidAccount("PARENT-001"))
            .Set(x => x.Item).To([IsoDataFactory.With(MinimalItem(), b2 => b2
                .Set(x2 => x2.RelatedAccount).To(ValidAccount("PARENT-001")))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "RelatedAccountRule");
    }

    [Fact]
    public void RelatedAccountOnly_DoesNotViolate_RelatedAccountRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.RelatedAccount).To(ValidAccount("PARENT-001")));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "RelatedAccountRule");
    }
}
