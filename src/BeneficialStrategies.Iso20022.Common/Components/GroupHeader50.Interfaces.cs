// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader50 : IGroupHeader50
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader50.Authorisation => Authorisation;
    ISettlementInstruction2 IGroupHeader50.SettlementInformation => SettlementInformation;
    IPaymentTypeInformation25? IGroupHeader50.PaymentTypeInformation => PaymentTypeInformation;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader50.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader50.InstructedAgent => InstructedAgent;
}
