// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader87 : IGroupHeader87
{
    IPartyIdentification135 IGroupHeader87.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader87.DebtorAgent => DebtorAgent;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader87.CreditorAgent => CreditorAgent;
}
