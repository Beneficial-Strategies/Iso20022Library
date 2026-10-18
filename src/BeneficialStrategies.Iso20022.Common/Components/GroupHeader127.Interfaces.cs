// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader127 : IGroupHeader127
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader127.Authorisation => Authorisation;
    IBranchAndFinancialInstitutionIdentification8? IGroupHeader127.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification8? IGroupHeader127.InstructingAgent => InstructingAgent;
    ISettlementInstruction15 IGroupHeader127.SettlementInformation => SettlementInformation;
}
