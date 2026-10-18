// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader93 : IGroupHeader93
{
    ISettlementInstruction7 IGroupHeader93.SettlementInformation => SettlementInformation;
    IPaymentTypeInformation28? IGroupHeader93.PaymentTypeInformation => PaymentTypeInformation;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader93.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader93.InstructedAgent => InstructedAgent;
}
