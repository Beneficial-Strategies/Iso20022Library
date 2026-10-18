// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction54 : ICreditTransferTransaction54
{
    IPaymentIdentification6 ICreditTransferTransaction54.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation26? ICreditTransferTransaction54.PaymentTypeInformation => PaymentTypeInformation;
    IAmountType4Choice ICreditTransferTransaction54.Amount => Amount;
    IExchangeRate1? ICreditTransferTransaction54.ExchangeRateInformation => ExchangeRateInformation;
    ICreditTransferMandateData1? ICreditTransferTransaction54.MandateRelatedInformation => MandateRelatedInformation;
    ICheque11? ICreditTransferTransaction54.ChequeInstruction => ChequeInstruction;
    IPartyIdentification135? ICreditTransferTransaction54.UltimateDebtor => UltimateDebtor;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction54.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount40? ICreditTransferTransaction54.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction54.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount40? ICreditTransferTransaction54.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction54.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount40? ICreditTransferTransaction54.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction54.CreditorAgent => CreditorAgent;
    ICashAccount40? ICreditTransferTransaction54.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification135? ICreditTransferTransaction54.Creditor => Creditor;
    ICashAccount40? ICreditTransferTransaction54.CreditorAccount => CreditorAccount;
    IPartyIdentification135? ICreditTransferTransaction54.UltimateCreditor => UltimateCreditor;
    IEnumerable<IInstructionForCreditorAgent3> ICreditTransferTransaction54.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IInstructionForDebtorAgent1? ICreditTransferTransaction54.InstructionForDebtorAgent => InstructionForDebtorAgent;
    IPurpose2Choice? ICreditTransferTransaction54.Purpose => Purpose;
    IEnumerable<IRegulatoryReporting3> ICreditTransferTransaction54.RegulatoryReporting => RegulatoryReporting;
    ITaxInformation10? ICreditTransferTransaction54.Tax => Tax;
    IEnumerable<IRemittanceLocation7> ICreditTransferTransaction54.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation21? ICreditTransferTransaction54.RemittanceInformation => RemittanceInformation;
    IEnumerable<ISupplementaryData1> ICreditTransferTransaction54.SupplementaryData => SupplementaryData;
}
