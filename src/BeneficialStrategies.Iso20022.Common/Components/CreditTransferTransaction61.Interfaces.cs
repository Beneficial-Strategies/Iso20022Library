// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction61 : ICreditTransferTransaction61
{
    IAmountType4Choice ICreditTransferTransaction61.Amount => Amount;
    ICheque19? ICreditTransferTransaction61.ChequeInstruction => ChequeInstruction;
    IPartyIdentification272? ICreditTransferTransaction61.Creditor => Creditor;
    ICashAccount40? ICreditTransferTransaction61.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction61.CreditorAgent => CreditorAgent;
    ICashAccount40? ICreditTransferTransaction61.CreditorAgentAccount => CreditorAgentAccount;
    IExchangeRate1? ICreditTransferTransaction61.ExchangeRateInformation => ExchangeRateInformation;
    IEnumerable<IInstructionForCreditorAgent3> ICreditTransferTransaction61.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IInstructionForDebtorAgent1? ICreditTransferTransaction61.InstructionForDebtorAgent => InstructionForDebtorAgent;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction61.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount40? ICreditTransferTransaction61.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction61.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount40? ICreditTransferTransaction61.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction61.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount40? ICreditTransferTransaction61.IntermediaryAgent3Account => IntermediaryAgent3Account;
    ICreditTransferMandateData1? ICreditTransferTransaction61.MandateRelatedInformation => MandateRelatedInformation;
    IPaymentIdentification6 ICreditTransferTransaction61.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation26? ICreditTransferTransaction61.PaymentTypeInformation => PaymentTypeInformation;
    IPurpose2Choice? ICreditTransferTransaction61.Purpose => Purpose;
    IEnumerable<IRegulatoryReporting3> ICreditTransferTransaction61.RegulatoryReporting => RegulatoryReporting;
    IEnumerable<IRemittanceLocation8> ICreditTransferTransaction61.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation22? ICreditTransferTransaction61.RemittanceInformation => RemittanceInformation;
    IEnumerable<ISupplementaryData1> ICreditTransferTransaction61.SupplementaryData => SupplementaryData;
    ITaxData1? ICreditTransferTransaction61.Tax => Tax;
    IPartyIdentification272? ICreditTransferTransaction61.UltimateCreditor => UltimateCreditor;
    IPartyIdentification272? ICreditTransferTransaction61.UltimateDebtor => UltimateDebtor;
}
