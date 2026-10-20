// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class StatementGroup1ValidatorTests
{
    private readonly StatementGroup1Validator _sut = new();

    private static PartyIdentification58 ValidParty() =>
        new()
        {
            Name = "Party Name",
            Identification = new Choices.Party13Choice.OrganisationIdentification(),
        };

    private static CashAccount16 ValidCashAccount() =>
        new()
        {
            Identification = new Choices.AccountIdentification4Choice.Other { Identification = "ACC-001" },
        };

    private static CashAccountCharacteristics1 ValidAccountCharacteristics() =>
        new()
        {
            AccountLevel = Codesets.AccountLevel2Code.Detail,
            CashAccount = ValidCashAccount(),
            CompensationMethod = Codesets.CompensationMethod1Code.No,
            AccountBalanceCurrencyCode = "USD",
            AccountServicerContact = new ContactDetails3(),
        };

    private static BillingStatement1 ValidBillingStatement() =>
        new()
        {
            StatementIdentification = "STMT-001",
            FromToDate = new DatePeriod1 { ToDate = new DateOnly(2026, 8, 13) },
            CreationDateTime = new DateTime(2026, 8, 13),
            Status = Codesets.BillingStatementStatus1Code.Original,
            AccountCharacteristics = ValidAccountCharacteristics(),
        };

    private static StatementGroup1 ValidMessage() =>
        new()
        {
            GroupIdentification = "GRP-001",
            Sender = ValidParty(),
            Receiver = ValidParty(),
            BillingStatement = [ValidBillingStatement()],
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── BillingStatement: 1..* ────────────────────────────────────────────────

    [Fact]
    public void BillingStatement_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { BillingStatement = [] };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.BillingStatement);
    }

    // ── SenderIndividualContact: 0..2 ────────────────────────────────────────

    [Fact]
    public void SenderIndividualContact_ExceedsMax_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            SenderIndividualContact = [new ContactDetails3(), new ContactDetails3(), new ContactDetails3()],
        };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.SenderIndividualContact);
    }

    [Fact]
    public void SenderIndividualContact_AtMax_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            SenderIndividualContact = [new ContactDetails3(), new ContactDetails3()],
        };
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.SenderIndividualContact);
    }

    // ── ReceiverIndividualContact: 0..2 ──────────────────────────────────────

    [Fact]
    public void ReceiverIndividualContact_ExceedsMax_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            ReceiverIndividualContact = [new ContactDetails3(), new ContactDetails3(), new ContactDetails3()],
        };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.ReceiverIndividualContact);
    }

    [Fact]
    public void ReceiverIndividualContact_AtMax_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            ReceiverIndividualContact = [new ContactDetails3(), new ContactDetails3()],
        };
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.ReceiverIndividualContact);
    }
}
