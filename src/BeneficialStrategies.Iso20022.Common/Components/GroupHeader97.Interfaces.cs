// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader97 : IGroupHeader97
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader97.Authorisation => Authorisation;
    ISettlementInstruction11 IGroupHeader97.SettlementInformation => SettlementInformation;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader97.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader97.InstructedAgent => InstructedAgent;
}
