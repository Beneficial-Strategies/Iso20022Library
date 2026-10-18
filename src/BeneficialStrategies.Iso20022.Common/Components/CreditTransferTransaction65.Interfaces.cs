// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction65 : ICreditTransferTransaction65
{
    IAmountType4Choice ICreditTransferTransaction65.Amount => Amount;
    ICheque19? ICreditTransferTransaction65.ChequeInstruction => ChequeInstruction;
    IPartyIdentification272 ICreditTransferTransaction65.Creditor => Creditor;
    ICashAccount40? ICreditTransferTransaction65.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification8 ICreditTransferTransaction65.CreditorAgent => CreditorAgent;
    ICashAccount40? ICreditTransferTransaction65.CreditorAgentAccount => CreditorAgentAccount;
    IEnumerable<IDocument15> ICreditTransferTransaction65.EnclosedFile => EnclosedFile;
    IEnumerable<IInstructionForCreditorAgent3> ICreditTransferTransaction65.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction65.IntermediaryAgent1 => IntermediaryAgent1;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction65.IntermediaryAgent2 => IntermediaryAgent2;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction65.IntermediaryAgent3 => IntermediaryAgent3;
    ICreditTransferMandateData1? ICreditTransferTransaction65.MandateRelatedInformation => MandateRelatedInformation;
    IPaymentCondition2? ICreditTransferTransaction65.PaymentCondition => PaymentCondition;
    IPaymentIdentification6 ICreditTransferTransaction65.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation29? ICreditTransferTransaction65.PaymentTypeInformation => PaymentTypeInformation;
    IPurpose2Choice? ICreditTransferTransaction65.Purpose => Purpose;
    IEnumerable<IRegulatoryReporting3> ICreditTransferTransaction65.RegulatoryReporting => RegulatoryReporting;
    IEnumerable<IRemittanceLocation8> ICreditTransferTransaction65.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation22? ICreditTransferTransaction65.RemittanceInformation => RemittanceInformation;
    IDateAndDateTime2Choice? ICreditTransferTransaction65.RequestedExecutionDate => RequestedExecutionDate;
    IEnumerable<ISupplementaryData1> ICreditTransferTransaction65.SupplementaryData => SupplementaryData;
    ITaxData1? ICreditTransferTransaction65.Tax => Tax;
    IPartyIdentification272? ICreditTransferTransaction65.UltimateCreditor => UltimateCreditor;
    IPartyIdentification272? ICreditTransferTransaction65.UltimateDebtor => UltimateDebtor;
}
