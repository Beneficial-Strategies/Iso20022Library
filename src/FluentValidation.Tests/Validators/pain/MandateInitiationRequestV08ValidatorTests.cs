// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

public class MandateInitiationRequestV08ValidatorTests
{
    private readonly MandateInitiationRequestV08Validator _sut = new();

    private static IGroupHeader110 ValidGroupHeader() =>
        IsoDataFactory.Make<IGroupHeader110>(b => b
            .Set(x => x.MessageIdentification).To("MSG-001")
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1)));

    private static IPartyIdentification272 ValidParty(string name) => IsoDataFactory.Make<IPartyIdentification272>(b => b
        .Set(x => x.Name).To(name));

    private static IBranchAndFinancialInstitutionIdentification8 ValidAgent() =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>()));

    private static IMandate23 ValidMandate() =>
        IsoDataFactory.Make<IMandate23>(b => b
            .Set(x => x.Creditor).To(ValidParty("Creditor Co"))
            .Set(x => x.Debtor).To(ValidParty("Debtor Co"))
            .Set(x => x.DebtorAgent).To(ValidAgent())
            .Set(x => x.MandateRequestIdentification).To("MNDTREQ-001")
            .Set(x => x.TrackingIndicator).To(true));

    private static IMandateInitiationRequestV08 ValidMessage() =>
        IsoDataFactory.Make<IMandateInitiationRequestV08>(b => b
            .Set(x => x.GroupHeader).To(ValidGroupHeader())
            .Set(x => x.Mandate).To([ValidMandate()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Mandate_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Mandate).To([]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "Mandate");
    }

    [Fact]
    public void Mandate_MultipleEntries_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Mandate).To([ValidMandate(), ValidMandate()]));
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
    public void NestedInvalidMandate_PropagatesErrorThroughFullChain()
    {
        // GroupHeader -> Mandate -> UltimateDebtorGuideline: proves the full DI chain the message
        // validator was wired up with actually executes end to end.
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Mandate).To([IsoDataFactory.With(ValidMandate(), b2 => b2
                .Set(x2 => x2.UltimateDebtor).To(ValidParty("Debtor Co")))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName.EndsWith("UltimateDebtorGuideline"));
    }
}
