// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader106 : IGroupHeader106
{
    IPartyIdentification135 IGroupHeader106.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader106.ForwardingAgent => ForwardingAgent;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader106.DebtorAgent => DebtorAgent;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader106.CreditorAgent => CreditorAgent;
}
