// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction3 : ICreditTransferTransaction3
{
    IPartyIdentification43? ICreditTransferTransaction3.UltimateDebtor => UltimateDebtor;
    IPartyIdentification43? ICreditTransferTransaction3.InitiatingParty => InitiatingParty;
    IPartyIdentification43 ICreditTransferTransaction3.Debtor => Debtor;
    ICashAccount24? ICreditTransferTransaction3.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5 ICreditTransferTransaction3.DebtorAgent => DebtorAgent;
    ICashAccount24? ICreditTransferTransaction3.DebtorAgentAccount => DebtorAgentAccount;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction3.PreviousInstructingAgent => PreviousInstructingAgent;
    ICashAccount24? ICreditTransferTransaction3.PreviousInstructingAgentAccount => PreviousInstructingAgentAccount;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction3.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount24? ICreditTransferTransaction3.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction3.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount24? ICreditTransferTransaction3.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction3.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount24? ICreditTransferTransaction3.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IBranchAndFinancialInstitutionIdentification5 ICreditTransferTransaction3.CreditorAgent => CreditorAgent;
    ICashAccount24? ICreditTransferTransaction3.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification43 ICreditTransferTransaction3.Creditor => Creditor;
    ICashAccount24? ICreditTransferTransaction3.CreditorAccount => CreditorAccount;
    IPartyIdentification43? ICreditTransferTransaction3.UltimateCreditor => UltimateCreditor;
    IRemittanceInformation7? ICreditTransferTransaction3.RemittanceInformation => RemittanceInformation;
}
