// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OriginalGroupHeader19ValidatorTests
{
    private readonly OriginalGroupHeader19Validator _sut = new();

    private static IOriginalGroupHeader19 ValidMessage() =>
        IsoDataFactory.Make<IOriginalGroupHeader19>(b => b
            .Set(x => x.OriginalMessageIdentification).To("ORGMSG-001")
            .Set(x => x.OriginalMessageNameIdentification).To("pacs.008.001.14"));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void OriginalCreationDateTime_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalCreationDateTime).To(new DateTime(2026, 1, 1)));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ReturnReasonInformation_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ReturnReasonInformation).To([IsoDataFactory.Make<IPaymentReturnReason7>(b2 => b2
            .Set(x2 => x2.Originator).To(IsoDataFactory.Make<IPartyIdentification272>()))]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
