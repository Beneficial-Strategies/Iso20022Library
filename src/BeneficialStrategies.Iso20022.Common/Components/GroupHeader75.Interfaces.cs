// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader75 : IGroupHeader75
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader75.Authorisation => Authorisation;
    IPartyIdentification125? IGroupHeader75.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader75.ForwardingAgent => ForwardingAgent;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader75.DebtorAgent => DebtorAgent;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader75.CreditorAgent => CreditorAgent;
}
