// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class StatementGroup2ValidatorTests
{
    private readonly StatementGroup2Validator _sut = new();

    private static IPartyIdentification58 ValidParty() =>
        IsoDataFactory.Make<IPartyIdentification58>(b => b
            .Set(x => x.Name).To("Party")
            .Set(x => x.Identification).To(IsoDataFactory.Make<Choices.Party13Choice.IOrganisationIdentification>()));

    private static IBillingStatement2 ValidBillingStatement() =>
        IsoDataFactory.Make<IBillingStatement2>(b => b
            .Set(x => x.StatementIdentification).To("STMT-001")
            .Set(x => x.FromToDate).To(IsoDataFactory.Make<IDatePeriod1>(b2 => b2
                .Set(x2 => x2.ToDate).To(new DateOnly(2026, 1, 31))))
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 31))
            .Set(x => x.Status).To(Codesets.BillingStatementStatus1Code.Original)
            .Set(x => x.AccountCharacteristics).To(IsoDataFactory.Make<ICashAccountCharacteristics2>(b2 => b2
                .Set(x2 => x2.AccountLevel).To(Codesets.AccountLevel2Code.Detail)
                .Set(x2 => x2.CashAccount).To(IsoDataFactory.Make<ICashAccount24>(b3 => b3
                    .Set(x3 => x3.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IOther>(b4 => b4
                        .Set(x4 => x4.Identification).To("ACC-001")))))
                .Set(x2 => x2.CompensationMethod).To(Codesets.CompensationMethod1Code.No)
                .Set(x2 => x2.AccountBalanceCurrencyCode).To("USD")
                .Set(x2 => x2.AccountServicerContact).To(IsoDataFactory.Make<IContactDetails3>()))));

    private static IStatementGroup2 ValidMessage() =>
        IsoDataFactory.Make<IStatementGroup2>(b => b
            .Set(x => x.GroupIdentification).To("GRP-001")
            .Set(x => x.Sender).To(ValidParty())
            .Set(x => x.Receiver).To(ValidParty())
            .Set(x => x.BillingStatement).To([ValidBillingStatement()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── BillingStatement: BillingStatement2, 1..∞ ─────────────────────────────

    [Fact]
    public void BillingStatement_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.BillingStatement).To([]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.BillingStatement);
    }

    // ── SenderIndividualContact: ContactDetails3, 0..2 ────────────────────────

    [Fact]
    public void SenderIndividualContact_TwoElements_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SenderIndividualContact).To([IsoDataFactory.Make<IContactDetails3>(), IsoDataFactory.Make<IContactDetails3>()]));
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.SenderIndividualContact);
    }

    [Fact]
    public void SenderIndividualContact_ThreeElements_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SenderIndividualContact).To([IsoDataFactory.Make<IContactDetails3>(), IsoDataFactory.Make<IContactDetails3>(), IsoDataFactory.Make<IContactDetails3>()]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.SenderIndividualContact);
    }

    // ── ReceiverIndividualContact: ContactDetails3, 0..2 ──────────────────────

    [Fact]
    public void ReceiverIndividualContact_TwoElements_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ReceiverIndividualContact).To([IsoDataFactory.Make<IContactDetails3>(), IsoDataFactory.Make<IContactDetails3>()]));
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.ReceiverIndividualContact);
    }

    [Fact]
    public void ReceiverIndividualContact_ThreeElements_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ReceiverIndividualContact).To([IsoDataFactory.Make<IContactDetails3>(), IsoDataFactory.Make<IContactDetails3>(), IsoDataFactory.Make<IContactDetails3>()]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.ReceiverIndividualContact);
    }
}
