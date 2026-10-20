// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class SettlementInstruction14ValidatorTests
{
    private readonly SettlementInstruction14Validator _sut = new();

    private static ISettlementInstruction14 ValidMessage() =>
        IsoDataFactory.Make<ISettlementInstruction14>(b => b
            .Set(x => x.SettlementMethod).To(SettlementMethod2Code.ClearingSystem));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SettlementAccount_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SettlementAccount).To(IsoDataFactory.Make<ICashAccount40>(b2 => b2
                .Set(x2 => x2.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IIBAN>(b3 => b3
                    .Set(x3 => x3.Value).To("DE89370400440532013000"))))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ClearingSystem_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ClearingSystem).To(IsoDataFactory.Make<Choices.ClearingSystemIdentification3Choice.ICode>(b2 => b2
                .Set(x2 => x2.Value).To(ExternalCashClearingSystem1Code.Target))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
