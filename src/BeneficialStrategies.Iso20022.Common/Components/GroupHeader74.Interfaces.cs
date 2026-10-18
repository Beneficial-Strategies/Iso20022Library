// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader74 : IGroupHeader74
{
    IPartyIdentification125? IGroupHeader74.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader74.ForwardingAgent => ForwardingAgent;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader74.DebtorAgent => DebtorAgent;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader74.CreditorAgent => CreditorAgent;
}
