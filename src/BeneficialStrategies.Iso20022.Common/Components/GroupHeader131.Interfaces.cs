// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader131 : IGroupHeader131
{
    IBranchAndFinancialInstitutionIdentification8? IGroupHeader131.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification8? IGroupHeader131.InstructingAgent => InstructingAgent;
    IPaymentTypeInformation28? IGroupHeader131.PaymentTypeInformation => PaymentTypeInformation;
    ISettlementInstruction15 IGroupHeader131.SettlementInformation => SettlementInformation;
}
