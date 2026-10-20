// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class ChargesPerTransactionRecord6ValidatorTests
{
    private readonly ChargesPerTransactionRecord6Validator _sut = new();

    private static IChargesBreakdown1 ValidBreakdown() =>
        IsoDataFactory.Make<IChargesBreakdown1>(b => b
            .Set(x => x.Amount).To(new ActiveCurrencyAndAmount { Currency = "USD", Amount = 10m }));

    private static IChargesPerTransactionRecord6 ValidMessage() =>
        IsoDataFactory.Make<IChargesPerTransactionRecord6>(b => b
            .Set(x => x.UnderlyingTransaction).To(IsoDataFactory.Make<ITransactionReferences7>())
            .Set(x => x.ChargesBreakdown).To([ValidBreakdown()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── ChargesBreakdown: ChargesBreakdown1, 1..∞ ─────────────────────────────

    [Fact]
    public void ChargesBreakdown_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ChargesBreakdown).To([]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.ChargesBreakdown);
    }

    [Fact]
    public void ChargesBreakdown_OneElement_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ChargesBreakdown).To([ValidBreakdown()]));
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.ChargesBreakdown);
    }
}
