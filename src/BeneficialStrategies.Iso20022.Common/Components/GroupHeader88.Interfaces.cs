// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader88 : IGroupHeader88
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader88.Authorisation => Authorisation;
    IPartyIdentification135? IGroupHeader88.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader88.ForwardingAgent => ForwardingAgent;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader88.DebtorAgent => DebtorAgent;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader88.CreditorAgent => CreditorAgent;
}
