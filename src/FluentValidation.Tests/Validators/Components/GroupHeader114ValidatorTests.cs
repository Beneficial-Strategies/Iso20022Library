// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class GroupHeader114ValidatorTests
{
    private readonly GroupHeader114Validator _sut = new();

    private static IGroupHeader114 ValidMessage() =>
        IsoDataFactory.Make<IGroupHeader114>(b => b
            .Set(x => x.MessageIdentification).To("MSG-001")
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.NumberOfTransactions).To("1")
            .Set(x => x.InitiatingParty).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Initiator Co"))));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ControlSum).To(100.00m)
            .Set(x => x.ForwardingAgent).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b2 => b2
                .Set(x2 => x2.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>())))
            .Set(x => x.InitiationSource).To(IsoDataFactory.Make<IPaymentInitiationSource1>(b2 => b2
                .Set(x2 => x2.Name).To("MyPaymentApp"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
