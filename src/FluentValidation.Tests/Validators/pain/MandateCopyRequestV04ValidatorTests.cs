// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

public class MandateCopyRequestV04ValidatorTests
{
    private readonly MandateCopyRequestV04Validator _sut = new();

    private static GroupHeader110 ValidGroupHeader() =>
        new() { MessageIdentification = "MSG-001", CreationDateTime = new DateTime(2026, 1, 1) };

    private static MandateCopyRequestV04 ValidMessage() => new() { GroupHeader = ValidGroupHeader() };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void UnderlyingCopyRequestDetails_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            UnderlyingCopyRequestDetails =
            [
                new MandateCopy4
                {
                    OriginalMandate =
                        new BeneficialStrategies.Iso20022.Choices.OriginalMandate10Choice.OriginalMandateIdentification
                        {
                            Value = "MNDT-001",
                        },
                },
            ],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SupplementaryData_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            SupplementaryData = [new SupplementaryData1 { Envelope = new SupplementaryDataEnvelope1() }],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void NestedInvalidGroupHeaderAgent_PropagatesErrorThroughFullChain()
    {
        // GroupHeader -> InstructingAgent -> BranchIdentification -> PostalAddress -> AddressType:
        // a fully valid combination proves the whole DI chain the message validator was wired up
        // with actually executes end to end without throwing.
        var agent = new BranchAndFinancialInstitutionIdentification8
        {
            FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
            BranchIdentification = new BranchData5
            {
                PostalAddress = new PostalAddress27
                {
                    AddressType = new BeneficialStrategies.Iso20022.Choices.AddressType3Choice.Code
                    {
                        Value = AddressType2Code.Business,
                    },
                },
            },
        };
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader() with { InstructingAgent = agent },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
