// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentTypeInformation26ValidatorTests
{
    private readonly PaymentTypeInformation26Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IPaymentTypeInformation26>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IPaymentTypeInformation26>(b => b
            .Set(x => x.InstructionPriority).To(Priority2Code.High)
            .Set(x => x.ServiceLevel).To([
                IsoDataFactory.Make<Choices.ServiceLevel8Choice.IProprietary>(b2 => b2
                    .Set(x2 => x2.Value).To("SEPA")),
            ])
            .Set(x => x.LocalInstrument).To(IsoDataFactory.Make<Choices.LocalInstrument2Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("INST")))
            .Set(x => x.CategoryPurpose).To(IsoDataFactory.Make<Choices.CategoryPurpose1Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("CASH"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
