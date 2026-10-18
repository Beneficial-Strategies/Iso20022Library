// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader7 : IGroupHeader7
{
    IPartyIdentification8? IGroupHeader7.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification3? IGroupHeader7.ForwardingAgent => ForwardingAgent;
    IBranchAndFinancialInstitutionIdentification3? IGroupHeader7.DebtorAgent => DebtorAgent;
    IBranchAndFinancialInstitutionIdentification3? IGroupHeader7.CreditorAgent => CreditorAgent;
    IBranchAndFinancialInstitutionIdentification3? IGroupHeader7.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification3? IGroupHeader7.InstructedAgent => InstructedAgent;
}
