// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader89 : IGroupHeader89
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader89.Authorisation => Authorisation;
    ISettlementInstruction7 IGroupHeader89.SettlementInformation => SettlementInformation;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader89.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader89.InstructedAgent => InstructedAgent;
}
