// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class Cheque19ValidatorTests
{
    private readonly Cheque19Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new Cheque19()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void WithDeliveryMethod_NoValidationErrors()
    {
        var value = new Cheque19
        {
            DeliveryMethod = new Choices.ChequeDeliveryMethod1Choice.Code { Value = ChequeDelivery1Code.MailToDebtor },
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
