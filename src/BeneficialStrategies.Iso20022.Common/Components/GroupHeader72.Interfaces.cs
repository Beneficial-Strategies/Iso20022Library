// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader72 : IGroupHeader72
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader72.Authorisation => Authorisation;
    ISettlementInstruction4 IGroupHeader72.SettlementInformation => SettlementInformation;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader72.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader72.InstructedAgent => InstructedAgent;
}
