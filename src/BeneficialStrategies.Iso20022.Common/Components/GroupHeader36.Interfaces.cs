// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader36 : IGroupHeader36
{
    IPartyIdentification32? IGroupHeader36.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification4? IGroupHeader36.ForwardingAgent => ForwardingAgent;
    IBranchAndFinancialInstitutionIdentification4? IGroupHeader36.DebtorAgent => DebtorAgent;
    IBranchAndFinancialInstitutionIdentification4? IGroupHeader36.CreditorAgent => CreditorAgent;
}
