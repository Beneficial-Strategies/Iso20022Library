// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader49 : IGroupHeader49
{
    ISettlementInstruction1 IGroupHeader49.SettlementInformation => SettlementInformation;
    IPaymentTypeInformation21? IGroupHeader49.PaymentTypeInformation => PaymentTypeInformation;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader49.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader49.InstructedAgent => InstructedAgent;
}
