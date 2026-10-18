// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader71 : IGroupHeader71
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader71.Authorisation => Authorisation;
    ISettlementInstruction4 IGroupHeader71.SettlementInformation => SettlementInformation;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader71.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader71.InstructedAgent => InstructedAgent;
}
