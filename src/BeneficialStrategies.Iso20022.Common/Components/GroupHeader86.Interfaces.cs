// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader86 : IGroupHeader86
{
    IPartyIdentification135? IGroupHeader86.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader86.ForwardingAgent => ForwardingAgent;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader86.DebtorAgent => DebtorAgent;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader86.CreditorAgent => CreditorAgent;
}
