// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader6 : IGroupHeader6
{
    IEnumerable<string> IGroupHeader6.Authorisation => Authorisation;
    ISettlementInformation1 IGroupHeader6.SettlementInformation => SettlementInformation;
    IBranchAndFinancialInstitutionIdentification3? IGroupHeader6.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification3? IGroupHeader6.InstructedAgent => InstructedAgent;
}
