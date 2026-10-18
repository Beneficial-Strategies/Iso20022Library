// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader98 : IGroupHeader98
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader98.Authorisation => Authorisation;
    ISettlementInstruction14 IGroupHeader98.SettlementInformation => SettlementInformation;
    IPaymentTypeInformation27? IGroupHeader98.PaymentTypeInformation => PaymentTypeInformation;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader98.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader98.InstructedAgent => InstructedAgent;
}
