// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record SettlementInstruction7 : ISettlementInstruction7
{
    ICashAccount38? ISettlementInstruction7.SettlementAccount => SettlementAccount;
    IClearingSystemIdentification3Choice? ISettlementInstruction7.ClearingSystem => ClearingSystem;
    IBranchAndFinancialInstitutionIdentification6? ISettlementInstruction7.InstructingReimbursementAgent => InstructingReimbursementAgent;
    ICashAccount38? ISettlementInstruction7.InstructingReimbursementAgentAccount => InstructingReimbursementAgentAccount;
    IBranchAndFinancialInstitutionIdentification6? ISettlementInstruction7.InstructedReimbursementAgent => InstructedReimbursementAgent;
    ICashAccount38? ISettlementInstruction7.InstructedReimbursementAgentAccount => InstructedReimbursementAgentAccount;
    IBranchAndFinancialInstitutionIdentification6? ISettlementInstruction7.ThirdReimbursementAgent => ThirdReimbursementAgent;
    ICashAccount38? ISettlementInstruction7.ThirdReimbursementAgentAccount => ThirdReimbursementAgentAccount;
}
