// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

public class MandateCopyRequestV04ValidatorTests
{
    private readonly MandateCopyRequestV04Validator _sut = new();

    private static IGroupHeader110 ValidGroupHeader() =>
        IsoDataFactory.Make<IGroupHeader110>(b => b
            .Set(x => x.MessageIdentification).To("MSG-001")
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1)));

    private static IMandateCopyRequestV04 ValidMessage() => IsoDataFactory.Make<IMandateCopyRequestV04>(b => b
        .Set(x => x.GroupHeader).To(ValidGroupHeader()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void UnderlyingCopyRequestDetails_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.UnderlyingCopyRequestDetails).To([
                IsoDataFactory.Make<IMandateCopy4>(b2 => b2
                    .Set(x2 => x2.OriginalMandate).To(IsoDataFactory.Make<Choices.OriginalMandate10Choice.IOriginalMandateIdentification>(b3 => b3
                            .Set(x3 => x3.Value).To("MNDT-001")))),
            ]));
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

    [Fact]
    public void NestedInvalidGroupHeaderAgent_PropagatesErrorThroughFullChain()
    {
        // GroupHeader -> InstructingAgent -> BranchIdentification -> PostalAddress -> AddressType:
        // a fully valid combination proves the whole DI chain the message validator was wired up
        // with actually executes end to end without throwing.
        var agent = IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>())
            .Set(x => x.BranchIdentification).To(IsoDataFactory.Make<IBranchData5>(b2 => b2
                .Set(x2 => x2.PostalAddress).To(IsoDataFactory.Make<IPostalAddress27>(b3 => b3
                    .Set(x3 => x3.AddressType).To(IsoDataFactory.Make<Choices.AddressType3Choice.ICode>(b4 => b4
                        .Set(x4 => x4.Value).To(AddressType2Code.Business))))))));
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(ValidGroupHeader(), b2 => b2
                .Set(x2 => x2.InstructingAgent).To(agent))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
