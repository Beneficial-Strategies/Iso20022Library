// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class AmendmentInformationDetails15ValidatorTests
{
    private readonly AmendmentInformationDetails15Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IAmendmentInformationDetails15>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var agent = IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>()));
        var account = IsoDataFactory.Make<ICashAccount40>(b => b
            .Set(x => x.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IIBAN>(b2 => b2
                .Set(x2 => x2.Value).To("DE89370400440532013000"))));
        var msg = IsoDataFactory.Make<IAmendmentInformationDetails15>(b => b
            .Set(x => x.OriginalCreditorAgent).To(agent)
            .Set(x => x.OriginalCreditorAgentAccount).To(account)
            .Set(x => x.OriginalCreditorSchemeIdentification).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Original Creditor Co")))
            .Set(x => x.OriginalDebtor).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Original Debtor Co")))
            .Set(x => x.OriginalDebtorAccount).To(account)
            .Set(x => x.OriginalDebtorAgent).To(agent)
            .Set(x => x.OriginalDebtorAgentAccount).To(account)
            .Set(x => x.OriginalFinalCollectionDate).To(new DateOnly(2026, 12, 1))
            .Set(x => x.OriginalFrequency).To(IsoDataFactory.Make<Choices.Frequency36Choice.IType>(b2 => b2
                .Set(x2 => x2.Value).To(Frequency6Code.Monthly)))
            .Set(x => x.OriginalMandateIdentification).To("MNDT-ORIG-001")
            .Set(x => x.OriginalReason).To(IsoDataFactory.Make<Choices.MandateSetupReason1Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("MYREASON")))
            .Set(x => x.OriginalTrackingDays).To("05"));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
