// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pacs;

public class FinancialInstitutionDirectDebitV06ValidatorTests
{
    private readonly FinancialInstitutionDirectDebitV06Validator _sut = new();

    private static BranchAndFinancialInstitutionIdentification8 ValidAgent(string bic) =>
        new() { FinancialInstitutionIdentification = new FinancialInstitutionIdentification23 { BICFI = bic } };

    private static GroupHeader119 ValidGroupHeader() =>
        new()
        {
            MessageIdentification = "MSG-001",
            CreationDateTime = new DateTime(2026, 1, 1),
            NumberOfTransactions = "1",
        };

    private static DirectDebitTransactionInformation33 ValidDirectDebitTransactionInformation() =>
        new()
        {
            PaymentIdentification = new PaymentIdentification13 { EndToEndIdentification = "E2E-001" },
            Debtor = ValidAgent("DEUTDEFFXXX"),
            InterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m },
        };

    private static CreditTransferTransaction66 ValidCreditInstruction() =>
        new()
        {
            CreditIdentification = "CDT-001",
            Creditor = ValidAgent("BOFAUS3NXXX"),
            DirectDebitTransactionInformation = [ValidDirectDebitTransactionInformation()],
        };

    private static FinancialInstitutionDirectDebitV06 ValidMessage() =>
        new() { GroupHeader = ValidGroupHeader(), CreditInstruction = [ValidCreditInstruction()] };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── CreditInstruction minimum-count (1..∞) ───────────────────────────────────

    [Fact]
    public void CreditInstruction_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { CreditInstruction = [] };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "CreditInstruction");
    }

    [Fact]
    public void CreditInstruction_MultipleElements_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            CreditInstruction = [ValidCreditInstruction(), ValidCreditInstruction() with { CreditIdentification = "CDT-002" }],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── Nested validation propagation ────────────────────────────────────────────

    [Fact]
    public void CreditInstruction_WithEmptyDirectDebitTransactionInformation_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            CreditInstruction = [ValidCreditInstruction() with { DirectDebitTransactionInformation = [] }],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName.EndsWith("DirectDebitTransactionInformation"));
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
}
