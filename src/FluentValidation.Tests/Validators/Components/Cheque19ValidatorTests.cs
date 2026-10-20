// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class Cheque19ValidatorTests
{
    private readonly Cheque19Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<ICheque19>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void WithDeliveryMethod_NoValidationErrors()
    {
        var value = IsoDataFactory.Make<ICheque19>(b => b
            .Set(x => x.DeliveryMethod).To(IsoDataFactory.Make<Choices.ChequeDeliveryMethod1Choice.ICode>(b2 => b2
                .Set(x2 => x2.Value).To(ChequeDelivery1Code.MailToDebtor))));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
