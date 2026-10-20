// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class DirectDebitTransaction12ValidatorTests
{
    private readonly DirectDebitTransaction12Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IDirectDebitTransaction12>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IDirectDebitTransaction12>(b => b
            .Set(x => x.CreditorSchemeIdentification).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Creditor Scheme Co")))
            .Set(x => x.MandateRelatedInformation).To(IsoDataFactory.Make<IMandateRelatedInformation16>())
            .Set(x => x.PreNotificationDate).To(new DateOnly(2026, 1, 1))
            .Set(x => x.PreNotificationIdentification).To("PRENOTIF-001"));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
