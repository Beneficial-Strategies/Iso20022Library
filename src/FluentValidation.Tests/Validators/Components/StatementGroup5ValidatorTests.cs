// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class StatementGroup5ValidatorTests
{
    private readonly StatementGroup5Validator _sut = new();

    private static PartyIdentification273 ValidParty() =>
        new()
        {
            Name = "Party",
            Identification = new Choices.Party56Choice.FinancialInstitutionIdentification
            {
                Value = new FinancialInstitutionIdentification19(),
            },
        };

    private static BillingStatement5 ValidBillingStatement() =>
        new()
        {
            StatementIdentification = "STMT-001",
            FromToDate = new DatePeriod1 { ToDate = new DateOnly(2026, 1, 31) },
            CreationDateTime = new DateTime(2026, 1, 31),
            Status = Codesets.BillingStatementStatus1Code.Original,
            AccountCharacteristics = new CashAccountCharacteristics5
            {
                AccountLevel = Codesets.AccountLevel2Code.Detail,
                CashAccount = new CashAccount40
                {
                    Identification = new Choices.AccountIdentification4Choice.Other { Identification = "ACC-001" },
                },
                CompensationMethod = Codesets.CompensationMethod1Code.No,
                AccountBalanceCurrencyCode = "USD",
                AccountServicerContact = new Contact13(),
            },
        };

    private static StatementGroup5 ValidMessage() =>
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

    // ── BillingStatement: BillingStatement5, 1..∞ ─────────────────────────────

    [Fact]
    public void BillingStatement_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { BillingStatement = [] };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.BillingStatement);
    }

    // ── SenderIndividualContact: Contact13, 0..2 ──────────────────────────────

    [Fact]
    public void SenderIndividualContact_TwoElements_NoValidationError()
    {
        var msg = ValidMessage() with { SenderIndividualContact = [new Contact13(), new Contact13()] };
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.SenderIndividualContact);
    }

    [Fact]
    public void SenderIndividualContact_ThreeElements_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            SenderIndividualContact = [new Contact13(), new Contact13(), new Contact13()],
        };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.SenderIndividualContact);
    }

    // ── ReceiverIndividualContact: Contact13, 0..2 ────────────────────────────

    [Fact]
    public void ReceiverIndividualContact_TwoElements_NoValidationError()
    {
        var msg = ValidMessage() with { ReceiverIndividualContact = [new Contact13(), new Contact13()] };
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.ReceiverIndividualContact);
    }

    [Fact]
    public void ReceiverIndividualContact_ThreeElements_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            ReceiverIndividualContact = [new Contact13(), new Contact13(), new Contact13()],
        };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.ReceiverIndividualContact);
    }
}
