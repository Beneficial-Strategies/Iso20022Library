// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader99 : IGroupHeader99
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader99.Authorisation => Authorisation;
    ISettlementInstruction11 IGroupHeader99.SettlementInformation => SettlementInformation;
    IPaymentTypeInformation28? IGroupHeader99.PaymentTypeInformation => PaymentTypeInformation;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader99.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader99.InstructedAgent => InstructedAgent;
}
