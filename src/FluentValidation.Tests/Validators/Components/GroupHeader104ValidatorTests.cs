// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class GroupHeader104ValidatorTests
{
    private readonly GroupHeader104Validator _sut = new();

    private static IGroupHeader104 ValidMessage() =>
        IsoDataFactory.Make<IGroupHeader104>(b => b
            .Set(x => x.MessageIdentification).To("MSG-001")
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.NumberOfSettlementRequests).To("1"));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ControlSum_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ControlSum).To(100.00m));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SettlementInformation_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SettlementInformation).To(IsoDataFactory.Make<ISettlementInstruction14>(b2 => b2
                .Set(x2 => x2.SettlementMethod).To(SettlementMethod2Code.ClearingSystem))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
