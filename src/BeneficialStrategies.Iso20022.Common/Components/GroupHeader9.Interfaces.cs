// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader9 : IGroupHeader9
{
    IEnumerable<string> IGroupHeader9.Authorisation => Authorisation;
    ISettlementInformation1 IGroupHeader9.SettlementInformation => SettlementInformation;
    IBranchAndFinancialInstitutionIdentification3? IGroupHeader9.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification3? IGroupHeader9.InstructedAgent => InstructedAgent;
}
