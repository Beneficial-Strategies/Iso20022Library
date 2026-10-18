// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader124 : IGroupHeader124
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader124.Authorisation => Authorisation;
    IBranchAndFinancialInstitutionIdentification8? IGroupHeader124.CreditorAgent => CreditorAgent;
    IBranchAndFinancialInstitutionIdentification8? IGroupHeader124.DebtorAgent => DebtorAgent;
    IBranchAndFinancialInstitutionIdentification8? IGroupHeader124.ForwardingAgent => ForwardingAgent;
    IPartyIdentification272? IGroupHeader124.InitiatingParty => InitiatingParty;
}
