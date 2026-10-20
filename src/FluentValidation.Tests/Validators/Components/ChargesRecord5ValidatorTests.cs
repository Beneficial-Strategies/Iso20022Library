// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class ChargesRecord5ValidatorTests
{
    private readonly ChargesRecord5Validator _sut = new();

    private static IChargesRecord5 ValidMessage() =>
        IsoDataFactory.Make<IChargesRecord5>(b => b
            .Set(x => x.Amount).To(new ActiveCurrencyAndAmount { Currency = "USD", Amount = 10m })
            .Set(x => x.UnderlyingTransaction).To([IsoDataFactory.Make<ITransactionReferences7>()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── UnderlyingTransaction: TransactionReferences7, 1..∞ ───────────────────

    [Fact]
    public void UnderlyingTransaction_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.UnderlyingTransaction).To([]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.UnderlyingTransaction);
    }

    [Fact]
    public void UnderlyingTransaction_OneElement_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.UnderlyingTransaction).To([IsoDataFactory.Make<ITransactionReferences7>()]));
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.UnderlyingTransaction);
    }
}
