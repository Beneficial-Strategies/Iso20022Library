// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader38 : IGroupHeader38
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader38.Authorisation => Authorisation;
    ISettlementInformation13 IGroupHeader38.SettlementInformation => SettlementInformation;
    IBranchAndFinancialInstitutionIdentification4? IGroupHeader38.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification4? IGroupHeader38.InstructedAgent => InstructedAgent;
}
