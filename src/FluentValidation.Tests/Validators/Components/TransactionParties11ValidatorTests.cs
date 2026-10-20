// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class TransactionParties11ValidatorTests
{
    private readonly TransactionParties11Validator _sut = new();

    private static IBranchAndFinancialInstitutionIdentification8 ValidAgent(string bic) =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>(b2 => b2
            .Set(x2 => x2.BICFI).To(bic))));

    private static BeneficialStrategies.Iso20022.Choices.IParty50Choice ValidParty() =>
        IsoDataFactory.Make<Choices.Party50Choice.IParty>(b => b
            .Set(x => x.Value).To(IsoDataFactory.Make<IPartyIdentification272>()));

    private static ICashAccount40 ValidAccount(string id = "ACC-001") =>
        IsoDataFactory.Make<ICashAccount40>(b => b
            .Set(x => x.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IOther>(b2 => b2
            .Set(x2 => x2.Identification).To(id))));

    private static ITransactionParties11 ValidMessage() => IsoDataFactory.Make<ITransactionParties11>(b => b
        .Set(x => x.Creditor).To(ValidParty())
        .Set(x => x.Debtor).To(ValidParty()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void CreditorAccountAndDebtorAccount_Present_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.CreditorAccount).To(ValidAccount())
            .Set(x => x.DebtorAccount).To(ValidAccount()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void CreditorAgentAndDebtorAgent_Present_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.CreditorAgent).To(ValidAgent("CHASUS33XXX"))
            .Set(x => x.DebtorAgent).To(ValidAgent("DEUTDEFFXXX")));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InitiatingPartyAndUltimateParties_Present_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.InitiatingParty).To(ValidParty())
            .Set(x => x.UltimateCreditor).To(ValidParty())
            .Set(x => x.UltimateDebtor).To(ValidParty()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Theory]
    [InlineData("IntermediaryAgent1")]
    [InlineData("IntermediaryAgent2")]
    [InlineData("IntermediaryAgent3")]
    [InlineData("PreviousInstructingAgent1")]
    [InlineData("PreviousInstructingAgent2")]
    [InlineData("PreviousInstructingAgent3")]
    public void OptionalAgentFields_Present_NoValidationErrors(string fieldName)
    {
        var msg = fieldName switch
        {
            "IntermediaryAgent1" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.IntermediaryAgent1).To(ValidAgent("BOFAUS3NXXX"))
                .Set(x => x.IntermediaryAgent1Account).To(ValidAccount())),
            "IntermediaryAgent2" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.IntermediaryAgent2).To(ValidAgent("BOFAUS3NXXX"))
                .Set(x => x.IntermediaryAgent2Account).To(ValidAccount())),
            "IntermediaryAgent3" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.IntermediaryAgent3).To(ValidAgent("BOFAUS3NXXX"))
                .Set(x => x.IntermediaryAgent3Account).To(ValidAccount())),
            "PreviousInstructingAgent1" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.PreviousInstructingAgent1).To(ValidAgent("BOFAUS3NXXX"))
                .Set(x => x.PreviousInstructingAgent1Account).To(ValidAccount())),
            "PreviousInstructingAgent2" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.PreviousInstructingAgent2).To(ValidAgent("BOFAUS3NXXX"))
                .Set(x => x.PreviousInstructingAgent2Account).To(ValidAccount())),
            "PreviousInstructingAgent3" => IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.PreviousInstructingAgent3).To(ValidAgent("BOFAUS3NXXX"))
                .Set(x => x.PreviousInstructingAgent3Account).To(ValidAccount())),
            _ => throw new ArgumentOutOfRangeException(nameof(fieldName)),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void DebtorAgentAccountAndCreditorAgentAccount_Present_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.DebtorAgentAccount).To(ValidAccount())
            .Set(x => x.CreditorAgentAccount).To(ValidAccount()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
