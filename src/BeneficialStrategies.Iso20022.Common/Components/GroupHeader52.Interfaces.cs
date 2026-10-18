// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader52 : IGroupHeader52
{
    IPartyIdentification43? IGroupHeader52.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader52.ForwardingAgent => ForwardingAgent;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader52.DebtorAgent => DebtorAgent;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader52.CreditorAgent => CreditorAgent;
}
