// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader56 : IGroupHeader56
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader56.Authorisation => Authorisation;
    IPartyIdentification43? IGroupHeader56.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader56.ForwardingAgent => ForwardingAgent;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader56.DebtorAgent => DebtorAgent;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader56.CreditorAgent => CreditorAgent;
}
