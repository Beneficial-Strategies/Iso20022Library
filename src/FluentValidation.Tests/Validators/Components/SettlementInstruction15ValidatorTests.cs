// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class SettlementInstruction15ValidatorTests
{
    private readonly SettlementInstruction15Validator _sut = new();

    private static ISettlementInstruction15 ValidMessage() =>
        IsoDataFactory.Make<ISettlementInstruction15>(b => b
            .Set(x => x.SettlementMethod).To(SettlementMethod1Code.InstructedAgent));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var agent = IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>()));
        var account = IsoDataFactory.Make<ICashAccount40>(b => b
            .Set(x => x.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IIBAN>(b2 => b2
                .Set(x2 => x2.Value).To("DE89370400440532013000"))));
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ClearingSystem).To(IsoDataFactory.Make<Choices.ClearingSystemIdentification3Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("MYSYS")))
            .Set(x => x.InstructedReimbursementAgent).To(agent)
            .Set(x => x.InstructedReimbursementAgentAccount).To(account)
            .Set(x => x.InstructingReimbursementAgent).To(agent)
            .Set(x => x.InstructingReimbursementAgentAccount).To(account)
            .Set(x => x.SettlementAccount).To(account)
            .Set(x => x.ThirdReimbursementAgent).To(agent)
            .Set(x => x.ThirdReimbursementAgentAccount).To(account));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
