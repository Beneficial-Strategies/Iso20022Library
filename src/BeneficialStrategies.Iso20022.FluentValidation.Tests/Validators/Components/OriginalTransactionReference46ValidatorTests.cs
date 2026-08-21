// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OriginalTransactionReference46ValidatorTests
{
    private readonly OriginalTransactionReference46Validator _sut = new();

    private static OriginalTransactionReference46 ValidMessage() =>
        new()
        {
            CreditorAgent = new BranchAndFinancialInstitutionIdentification8
            {
                FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
            },
            Creditor = new PartyIdentification272 { Name = "Creditor Co" },
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var agent = new BranchAndFinancialInstitutionIdentification8
        {
            FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
        };
        var account = new CashAccount40
        {
            Identification = new BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IBAN
            {
                Value = "DE89370400440532013000",
            },
        };
        var party = new PartyIdentification272 { Name = "Some Party" };
        var msg = ValidMessage() with
        {
            Amount = new BeneficialStrategies.Iso20022.Choices.AmountType4Choice.InstructedAmount
            {
                Currency = "USD",
                Amount = 100m,
            },
            RequestedExecutionDate = new BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice.Date
            {
                Value = new DateOnly(2026, 1, 1),
            },
            ExpiryDate = new BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice.Date
            {
                Value = new DateOnly(2026, 2, 1),
            },
            PaymentCondition = new PaymentCondition2(),
            PaymentTypeInformation = new PaymentTypeInformation29(),
            PaymentMethod = PaymentMethod4Code.Cheque,
            MandateRelatedInformation = new CreditTransferMandateData1(),
            RemittanceInformation = new RemittanceInformation26(),
            EnclosedFile =
            [
                new Document15
                {
                    Enclosure = Convert.ToBase64String([1, 2, 3]),
                    Identification = "DOC-001",
                    Format = new BeneficialStrategies.Iso20022.Choices.DocumentFormat1Choice.Code
                    {
                        Value = ExternalDocumentFormat1Code.PDF,
                    },
                    IssueDate = new BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice.Date
                    {
                        Value = new DateOnly(2026, 1, 1),
                    },
                    Type = new BeneficialStrategies.Iso20022.Choices.DocumentType1Choice.Code
                    {
                        Value = ExternalDocumentType1Code.CommercialInvoice,
                    },
                },
            ],
            UltimateDebtor = party,
            Debtor = party,
            DebtorAccount = account,
            DebtorAgent = agent,
            DebtorAgentAccount = account,
            CreditorAgentAccount = account,
            CreditorAccount = account,
            UltimateCreditor = party,
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
