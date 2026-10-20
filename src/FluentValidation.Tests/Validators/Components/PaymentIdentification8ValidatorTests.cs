// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentIdentification8ValidatorTests
{
    private readonly PaymentIdentification8Validator _sut = new();

    private static IPaymentIdentification8 ValidMessage() => IsoDataFactory.Make<IPaymentIdentification8>(b => b
        .Set(x => x.EndToEndIdentification).To("E2E-001"));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.InstructionIdentification).To("INSTR-001")
            .Set(x => x.TransactionIdentification).To("TX-001")
            .Set(x => x.UETR).To("8a562590-5288-4dc0-a49d-9846f6720b17"));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
