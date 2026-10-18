// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader128 : IGroupHeader128
{
    IBranchAndFinancialInstitutionIdentification8? IGroupHeader128.CreditorAgent => CreditorAgent;
    IBranchAndFinancialInstitutionIdentification8? IGroupHeader128.DebtorAgent => DebtorAgent;
    IBranchAndFinancialInstitutionIdentification8? IGroupHeader128.ForwardingAgent => ForwardingAgent;
    IPartyIdentification272? IGroupHeader128.InitiatingParty => InitiatingParty;
}
