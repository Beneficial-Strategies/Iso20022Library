// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class StatementGroup5ValidatorTests
{
    private readonly StatementGroup5Validator _sut = new();

    private static IPartyIdentification273 ValidParty() =>
        IsoDataFactory.Make<IPartyIdentification273>(b => b
            .Set(x => x.Name).To("Party")
            .Set(x => x.Identification).To(IsoDataFactory.Make<Choices.Party56Choice.IFinancialInstitutionIdentification>(b2 => b2
                .Set(x2 => x2.Value).To(IsoDataFactory.Make<IFinancialInstitutionIdentification19>()))));

    private static IBillingStatement5 ValidBillingStatement() =>
        IsoDataFactory.Make<IBillingStatement5>(b => b
            .Set(x => x.StatementIdentification).To("STMT-001")
            .Set(x => x.FromToDate).To(IsoDataFactory.Make<IDatePeriod1>(b2 => b2
                .Set(x2 => x2.ToDate).To(new DateOnly(2026, 1, 31))))
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 31))
            .Set(x => x.Status).To(Codesets.BillingStatementStatus1Code.Original)
            .Set(x => x.AccountCharacteristics).To(IsoDataFactory.Make<ICashAccountCharacteristics5>(b2 => b2
                .Set(x2 => x2.AccountLevel).To(Codesets.AccountLevel2Code.Detail)
                .Set(x2 => x2.CashAccount).To(IsoDataFactory.Make<ICashAccount40>(b3 => b3
                    .Set(x3 => x3.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IOther>(b4 => b4
                        .Set(x4 => x4.Identification).To("ACC-001")))))
                .Set(x2 => x2.CompensationMethod).To(Codesets.CompensationMethod1Code.No)
                .Set(x2 => x2.AccountBalanceCurrencyCode).To("USD")
                .Set(x2 => x2.AccountServicerContact).To(IsoDataFactory.Make<IContact13>()))));

    private static IStatementGroup5 ValidMessage() =>
        IsoDataFactory.Make<IStatementGroup5>(b => b
            .Set(x => x.GroupIdentification).To("GRP-001")
            .Set(x => x.Sender).To(ValidParty())
            .Set(x => x.Receiver).To(ValidParty())
            .Set(x => x.BillingStatement).To([ValidBillingStatement()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── BillingStatement: BillingStatement5, 1..∞ ─────────────────────────────

    [Fact]
    public void BillingStatement_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.BillingStatement).To([]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.BillingStatement);
    }

    // ── SenderIndividualContact: Contact13, 0..2 ──────────────────────────────

    [Fact]
    public void SenderIndividualContact_TwoElements_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SenderIndividualContact).To([IsoDataFactory.Make<IContact13>(), IsoDataFactory.Make<IContact13>()]));
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.SenderIndividualContact);
    }

    [Fact]
    public void SenderIndividualContact_ThreeElements_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SenderIndividualContact).To([IsoDataFactory.Make<IContact13>(), IsoDataFactory.Make<IContact13>(), IsoDataFactory.Make<IContact13>()]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.SenderIndividualContact);
    }

    // ── ReceiverIndividualContact: Contact13, 0..2 ────────────────────────────

    [Fact]
    public void ReceiverIndividualContact_TwoElements_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ReceiverIndividualContact).To([IsoDataFactory.Make<IContact13>(), IsoDataFactory.Make<IContact13>()]));
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.ReceiverIndividualContact);
    }

    [Fact]
    public void ReceiverIndividualContact_ThreeElements_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ReceiverIndividualContact).To([IsoDataFactory.Make<IContact13>(), IsoDataFactory.Make<IContact13>(), IsoDataFactory.Make<IContact13>()]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.ReceiverIndividualContact);
    }
}
