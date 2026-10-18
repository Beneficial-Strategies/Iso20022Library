// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader54 : IGroupHeader54
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader54.Authorisation => Authorisation;
    ISettlementInstruction1 IGroupHeader54.SettlementInformation => SettlementInformation;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader54.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader54.InstructedAgent => InstructedAgent;
}
