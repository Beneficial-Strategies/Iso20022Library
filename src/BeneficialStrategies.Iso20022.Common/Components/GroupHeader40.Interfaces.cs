// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader40 : IGroupHeader40
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader40.Authorisation => Authorisation;
    IPartyIdentification32? IGroupHeader40.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification4? IGroupHeader40.ForwardingAgent => ForwardingAgent;
    IBranchAndFinancialInstitutionIdentification4? IGroupHeader40.DebtorAgent => DebtorAgent;
    IBranchAndFinancialInstitutionIdentification4? IGroupHeader40.CreditorAgent => CreditorAgent;
}
