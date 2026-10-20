// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

public class MandateInitiationRequestV08ValidatorTests
{
    private readonly MandateInitiationRequestV08Validator _sut = new();

    private static GroupHeader110 ValidGroupHeader() =>
        new() { MessageIdentification = "MSG-001", CreationDateTime = new DateTime(2026, 1, 1) };

    private static PartyIdentification272 ValidParty(string name) => new() { Name = name };

    private static BranchAndFinancialInstitutionIdentification8 ValidAgent() =>
        new() { FinancialInstitutionIdentification = new FinancialInstitutionIdentification23() };

    private static Mandate23 ValidMandate() =>
        new()
        {
            Creditor = ValidParty("Creditor Co"),
            Debtor = ValidParty("Debtor Co"),
            DebtorAgent = ValidAgent(),
            MandateRequestIdentification = "MNDTREQ-001",
            TrackingIndicator = true,
        };

    private static MandateInitiationRequestV08 ValidMessage() =>
        new() { GroupHeader = ValidGroupHeader(), Mandate = [ValidMandate()] };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Mandate_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { Mandate = [] };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "Mandate");
    }

    [Fact]
    public void Mandate_MultipleEntries_NoValidationError()
    {
        var msg = ValidMessage() with { Mandate = [ValidMandate(), ValidMandate()] };
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
    public void NestedInvalidMandate_PropagatesErrorThroughFullChain()
    {
        // GroupHeader -> Mandate -> UltimateDebtorGuideline: proves the full DI chain the message
        // validator was wired up with actually executes end to end.
        var msg = ValidMessage() with
        {
            Mandate = [ValidMandate() with { UltimateDebtor = ValidParty("Debtor Co") }],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName.EndsWith("UltimateDebtorGuideline"));
    }
}
