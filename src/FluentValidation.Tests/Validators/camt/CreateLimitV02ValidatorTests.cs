// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class CreateLimitV02ValidatorTests
{
    private readonly CreateLimitV02Validator _sut = new();

    private static IMessageHeader1 ValidMessageHeader() => IsoDataFactory.Make<IMessageHeader1>(b => b
        .Set(x => x.MessageIdentification).To("MSG-001"));

    private static ICreateLimitV02 ValidMessage() => IsoDataFactory.Make<ICreateLimitV02>(b => b
        .Set(x => x.MessageHeader).To(ValidMessageHeader()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void LimitData_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.LimitData).To([
                IsoDataFactory.Make<ILimitStructure6>(b2 => b2
                    .Set(x2 => x2.LimitIdentification).To(IsoDataFactory.Make<ILimitIdentification8>(b3 => b3
                        .Set(x3 => x3.Type).To(IsoDataFactory.Make<Choices.LimitType1Choice.ICode>(b4 => b4
                            .Set(x4 => x4.Value).To(LimitType3Code.Bilateral)))))
                    .Set(x2 => x2.Amount).To(IsoDataFactory.Make<Choices.Amount2Choice.IAmountWithCurrency>(b3 => b3
                        .Set(x3 => x3.Currency).To("USD")
                        .Set(x3 => x3.Amount).To(100m)))),
            ]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SupplementaryData_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SupplementaryData).To([IsoDataFactory.Make<ISupplementaryData1>(b2 => b2
                .Set(x2 => x2.Envelope).To(new SupplementaryDataEnvelope1()))]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
