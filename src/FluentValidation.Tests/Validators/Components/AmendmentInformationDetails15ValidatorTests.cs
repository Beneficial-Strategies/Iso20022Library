// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class AmendmentInformationDetails15ValidatorTests
{
    private readonly AmendmentInformationDetails15Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new AmendmentInformationDetails15()).ShouldNotHaveAnyValidationErrors();
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
        var msg = new AmendmentInformationDetails15
        {
            OriginalCreditorAgent = agent,
            OriginalCreditorAgentAccount = account,
            OriginalCreditorSchemeIdentification = new PartyIdentification272 { Name = "Original Creditor Co" },
            OriginalDebtor = new PartyIdentification272 { Name = "Original Debtor Co" },
            OriginalDebtorAccount = account,
            OriginalDebtorAgent = agent,
            OriginalDebtorAgentAccount = account,
            OriginalFinalCollectionDate = new DateOnly(2026, 12, 1),
            OriginalFrequency = new BeneficialStrategies.Iso20022.Choices.Frequency36Choice.Type
            {
                Value = Frequency6Code.Monthly,
            },
            OriginalMandateIdentification = "MNDT-ORIG-001",
            OriginalReason = new BeneficialStrategies.Iso20022.Choices.MandateSetupReason1Choice.Proprietary
            {
                Value = "MYREASON",
            },
            OriginalTrackingDays = "05",
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
