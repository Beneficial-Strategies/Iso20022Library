// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader4 : IGroupHeader4
{
    ISettlementInformation1 IGroupHeader4.SettlementInformation => SettlementInformation;
    IPaymentTypeInformation5? IGroupHeader4.PaymentTypeInformation => PaymentTypeInformation;
    IBranchAndFinancialInstitutionIdentification3? IGroupHeader4.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification3? IGroupHeader4.InstructedAgent => InstructedAgent;
}
