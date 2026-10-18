// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader57 : IGroupHeader57
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader57.Authorisation => Authorisation;
    ISettlementInstruction1 IGroupHeader57.SettlementInformation => SettlementInformation;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader57.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader57.InstructedAgent => InstructedAgent;
}
