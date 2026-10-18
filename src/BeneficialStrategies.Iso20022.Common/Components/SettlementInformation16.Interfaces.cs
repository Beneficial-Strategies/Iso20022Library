// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record SettlementInformation16 : ISettlementInformation16
{
    ICashAccount16? ISettlementInformation16.SettlementAccount => SettlementAccount;
    IClearingSystemIdentification3Choice? ISettlementInformation16.ClearingSystem => ClearingSystem;
    IBranchAndFinancialInstitutionIdentification5? ISettlementInformation16.InstructingReimbursementAgent => InstructingReimbursementAgent;
    ICashAccount16? ISettlementInformation16.InstructingReimbursementAgentAccount => InstructingReimbursementAgentAccount;
    IBranchAndFinancialInstitutionIdentification5? ISettlementInformation16.InstructedReimbursementAgent => InstructedReimbursementAgent;
    ICashAccount16? ISettlementInformation16.InstructedReimbursementAgentAccount => InstructedReimbursementAgentAccount;
    IBranchAndFinancialInstitutionIdentification5? ISettlementInformation16.ThirdReimbursementAgent => ThirdReimbursementAgent;
    ICashAccount16? ISettlementInformation16.ThirdReimbursementAgentAccount => ThirdReimbursementAgentAccount;
}
