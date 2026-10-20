// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class DeleteLimitV08ValidatorTests
{
    private readonly DeleteLimitV08Validator _sut = new();

    private static IMessageHeader1 ValidMessageHeader() => IsoDataFactory.Make<IMessageHeader1>(b => b
        .Set(x => x.MessageIdentification).To("MSG-001"));

    private static BeneficialStrategies.Iso20022.Choices.ILimitStructure3Choice ValidLimitDetails() =>
        IsoDataFactory.Make<Choices.LimitStructure3Choice.ICurrentLimitIdentification>(b => b
            .Set(x => x.Value).To(IsoDataFactory.Make<ILimitIdentification8>(b2 => b2
                .Set(x2 => x2.Type).To(IsoDataFactory.Make<Choices.LimitType1Choice.ICode>(b3 => b3
                    .Set(x3 => x3.Value).To(LimitType3Code.Bilateral))))));

    private static IDeleteLimitV08 ValidMessage() =>
        IsoDataFactory.Make<IDeleteLimitV08>(b => b
            .Set(x => x.MessageHeader).To(ValidMessageHeader())
            .Set(x => x.LimitDetails).To(ValidLimitDetails()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
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
