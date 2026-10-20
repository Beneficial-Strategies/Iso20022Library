// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class StatementGroup1ValidatorTests
{
    private readonly StatementGroup1Validator _sut = new();

    private static IPartyIdentification58 ValidParty() =>
        IsoDataFactory.Make<IPartyIdentification58>(b => b
            .Set(x => x.Name).To("Party Name")
            .Set(x => x.Identification).To(IsoDataFactory.Make<Choices.Party13Choice.IOrganisationIdentification>()));

    private static ICashAccount16 ValidCashAccount() =>
        IsoDataFactory.Make<ICashAccount16>(b => b
            .Set(x => x.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IOther>(b2 => b2
                .Set(x2 => x2.Identification).To("ACC-001"))));

    private static ICashAccountCharacteristics1 ValidAccountCharacteristics() =>
        IsoDataFactory.Make<ICashAccountCharacteristics1>(b => b
            .Set(x => x.AccountLevel).To(Codesets.AccountLevel2Code.Detail)
            .Set(x => x.CashAccount).To(ValidCashAccount())
            .Set(x => x.CompensationMethod).To(Codesets.CompensationMethod1Code.No)
            .Set(x => x.AccountBalanceCurrencyCode).To("USD")
            .Set(x => x.AccountServicerContact).To(IsoDataFactory.Make<IContactDetails3>()));

    private static IBillingStatement1 ValidBillingStatement() =>
        IsoDataFactory.Make<IBillingStatement1>(b => b
            .Set(x => x.StatementIdentification).To("STMT-001")
            .Set(x => x.FromToDate).To(IsoDataFactory.Make<IDatePeriod1>(b2 => b2
                .Set(x2 => x2.ToDate).To(new DateOnly(2026, 8, 13))))
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 8, 13))
            .Set(x => x.Status).To(Codesets.BillingStatementStatus1Code.Original)
            .Set(x => x.AccountCharacteristics).To(ValidAccountCharacteristics()));

    private static IStatementGroup1 ValidMessage() =>
        IsoDataFactory.Make<IStatementGroup1>(b => b
            .Set(x => x.GroupIdentification).To("GRP-001")
            .Set(x => x.Sender).To(ValidParty())
            .Set(x => x.Receiver).To(ValidParty())
            .Set(x => x.BillingStatement).To([ValidBillingStatement()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── BillingStatement: 1..* ────────────────────────────────────────────────

    [Fact]
    public void BillingStatement_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.BillingStatement).To([]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.BillingStatement);
    }

    // ── SenderIndividualContact: 0..2 ────────────────────────────────────────

    [Fact]
    public void SenderIndividualContact_ExceedsMax_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SenderIndividualContact).To([IsoDataFactory.Make<IContactDetails3>(), IsoDataFactory.Make<IContactDetails3>(), IsoDataFactory.Make<IContactDetails3>()]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.SenderIndividualContact);
    }

    [Fact]
    public void SenderIndividualContact_AtMax_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SenderIndividualContact).To([IsoDataFactory.Make<IContactDetails3>(), IsoDataFactory.Make<IContactDetails3>()]));
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.SenderIndividualContact);
    }

    // ── ReceiverIndividualContact: 0..2 ──────────────────────────────────────

    [Fact]
    public void ReceiverIndividualContact_ExceedsMax_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ReceiverIndividualContact).To([IsoDataFactory.Make<IContactDetails3>(), IsoDataFactory.Make<IContactDetails3>(), IsoDataFactory.Make<IContactDetails3>()]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.ReceiverIndividualContact);
    }

    [Fact]
    public void ReceiverIndividualContact_AtMax_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ReceiverIndividualContact).To([IsoDataFactory.Make<IContactDetails3>(), IsoDataFactory.Make<IContactDetails3>()]));
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.ReceiverIndividualContact);
    }
}
