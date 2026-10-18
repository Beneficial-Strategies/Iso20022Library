// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record SettlementInformation1 : ISettlementInformation1
{
    ICashAccount7? ISettlementInformation1.SettlementAccount => SettlementAccount;
    IClearingSystemIdentification1Choice? ISettlementInformation1.ClearingSystem => ClearingSystem;
    IBranchAndFinancialInstitutionIdentification3? ISettlementInformation1.InstructingReimbursementAgent => InstructingReimbursementAgent;
    ICashAccount7? ISettlementInformation1.InstructingReimbursementAgentAccount => InstructingReimbursementAgentAccount;
    IBranchAndFinancialInstitutionIdentification3? ISettlementInformation1.InstructedReimbursementAgent => InstructedReimbursementAgent;
    ICashAccount7? ISettlementInformation1.InstructedReimbursementAgentAccount => InstructedReimbursementAgentAccount;
    IBranchAndFinancialInstitutionIdentification3? ISettlementInformation1.ThirdReimbursementAgent => ThirdReimbursementAgent;
    ICashAccount7? ISettlementInformation1.ThirdReimbursementAgentAccount => ThirdReimbursementAgentAccount;
}
