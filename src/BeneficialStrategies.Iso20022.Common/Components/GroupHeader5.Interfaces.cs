// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader5 : IGroupHeader5
{
    IPartyIdentification8? IGroupHeader5.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification3? IGroupHeader5.ForwardingAgent => ForwardingAgent;
    IBranchAndFinancialInstitutionIdentification3? IGroupHeader5.DebtorAgent => DebtorAgent;
    IBranchAndFinancialInstitutionIdentification3? IGroupHeader5.CreditorAgent => CreditorAgent;
    IBranchAndFinancialInstitutionIdentification3? IGroupHeader5.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification3? IGroupHeader5.InstructedAgent => InstructedAgent;
}
