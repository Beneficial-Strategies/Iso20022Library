// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class GetGeneralBusinessInformationV04ValidatorTests
{
    private readonly GetGeneralBusinessInformationV04Validator _sut = new();

    private static IMessageHeader1 ValidMessageHeader() => IsoDataFactory.Make<IMessageHeader1>(b => b
        .Set(x => x.MessageIdentification).To("MSG-001"));

    private static IGetGeneralBusinessInformationV04 ValidMessage() => IsoDataFactory.Make<IGetGeneralBusinessInformationV04>(b => b
        .Set(x => x.MessageHeader).To(ValidMessageHeader()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void GeneralBusinessInformationQueryDefinition_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GeneralBusinessInformationQueryDefinition).To(IsoDataFactory.Make<IBusinessInformationQueryDefinition3>(b2 => b2
                .Set(x2 => x2.QueryType).To(QueryType2Code.Modified))));
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
