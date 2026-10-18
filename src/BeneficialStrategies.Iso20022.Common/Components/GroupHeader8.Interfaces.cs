// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader8 : IGroupHeader8
{
    IEnumerable<string> IGroupHeader8.Authorisation => Authorisation;
    IPartyIdentification8? IGroupHeader8.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification3? IGroupHeader8.ForwardingAgent => ForwardingAgent;
    IBranchAndFinancialInstitutionIdentification3? IGroupHeader8.DebtorAgent => DebtorAgent;
    IBranchAndFinancialInstitutionIdentification3? IGroupHeader8.CreditorAgent => CreditorAgent;
}
