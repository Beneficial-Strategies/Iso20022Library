// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentIdentification13ValidatorTests
{
    private readonly PaymentIdentification13Validator _sut = new();

    private static IPaymentIdentification13 ValidMessage() => IsoDataFactory.Make<IPaymentIdentification13>(b => b
        .Set(x => x.EndToEndIdentification).To("E2E-001"));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFieldsPresent_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.InstructionIdentification).To("INSTR-001")
            .Set(x => x.TransactionIdentification).To("TX-001")
            .Set(x => x.UETR).To("1fdb2f66-7d4c-4a5f-8fbb-123456789abc")
            .Set(x => x.ClearingSystemReference).To("CLR-001"));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
