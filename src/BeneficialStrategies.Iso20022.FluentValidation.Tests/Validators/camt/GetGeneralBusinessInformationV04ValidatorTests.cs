// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class GetGeneralBusinessInformationV04ValidatorTests
{
    private readonly GetGeneralBusinessInformationV04Validator _sut = new();

    private static MessageHeader1 ValidMessageHeader() => new() { MessageIdentification = "MSG-001" };

    private static GetGeneralBusinessInformationV04 ValidMessage() => new() { MessageHeader = ValidMessageHeader() };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void GeneralBusinessInformationQueryDefinition_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            GeneralBusinessInformationQueryDefinition = new BusinessInformationQueryDefinition3
            {
                QueryType = QueryType2Code.Modified,
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SupplementaryData_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            SupplementaryData = new SupplementaryData1 { Envelope = new SupplementaryDataEnvelope1() },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
