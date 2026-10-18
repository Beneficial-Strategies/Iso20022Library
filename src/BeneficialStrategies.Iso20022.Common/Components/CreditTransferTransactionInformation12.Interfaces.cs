// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransactionInformation12 : ICreditTransferTransactionInformation12
{
    IPartyIdentification32? ICreditTransferTransactionInformation12.UltimateDebtor => UltimateDebtor;
    IPartyIdentification32? ICreditTransferTransactionInformation12.InitiatingParty => InitiatingParty;
    IPartyIdentification32 ICreditTransferTransactionInformation12.Debtor => Debtor;
    ICashAccount16? ICreditTransferTransactionInformation12.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification4 ICreditTransferTransactionInformation12.DebtorAgent => DebtorAgent;
    ICashAccount16? ICreditTransferTransactionInformation12.DebtorAgentAccount => DebtorAgentAccount;
    IBranchAndFinancialInstitutionIdentification4? ICreditTransferTransactionInformation12.PreviousInstructingAgent => PreviousInstructingAgent;
    ICashAccount16? ICreditTransferTransactionInformation12.PreviousInstructingAgentAccount => PreviousInstructingAgentAccount;
    IBranchAndFinancialInstitutionIdentification4? ICreditTransferTransactionInformation12.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount16? ICreditTransferTransactionInformation12.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification4? ICreditTransferTransactionInformation12.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount16? ICreditTransferTransactionInformation12.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification4? ICreditTransferTransactionInformation12.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount16? ICreditTransferTransactionInformation12.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IBranchAndFinancialInstitutionIdentification4 ICreditTransferTransactionInformation12.CreditorAgent => CreditorAgent;
    ICashAccount16? ICreditTransferTransactionInformation12.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification32 ICreditTransferTransactionInformation12.Creditor => Creditor;
    ICashAccount16? ICreditTransferTransactionInformation12.CreditorAccount => CreditorAccount;
    IPartyIdentification32? ICreditTransferTransactionInformation12.UltimateCreditor => UltimateCreditor;
    IRemittanceInformation5? ICreditTransferTransactionInformation12.RemittanceInformation => RemittanceInformation;
}
