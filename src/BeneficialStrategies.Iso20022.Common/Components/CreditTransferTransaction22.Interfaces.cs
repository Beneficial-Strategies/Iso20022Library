// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction22 : ICreditTransferTransaction22
{
    IPaymentIdentification1 ICreditTransferTransaction22.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation19? ICreditTransferTransaction22.PaymentTypeInformation => PaymentTypeInformation;
    IAmountType4Choice ICreditTransferTransaction22.Amount => Amount;
    ICheque7? ICreditTransferTransaction22.ChequeInstruction => ChequeInstruction;
    IPartyIdentification43? ICreditTransferTransaction22.UltimateDebtor => UltimateDebtor;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction22.IntermediaryAgent1 => IntermediaryAgent1;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction22.IntermediaryAgent2 => IntermediaryAgent2;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction22.IntermediaryAgent3 => IntermediaryAgent3;
    IBranchAndFinancialInstitutionIdentification5 ICreditTransferTransaction22.CreditorAgent => CreditorAgent;
    IPartyIdentification43 ICreditTransferTransaction22.Creditor => Creditor;
    ICashAccount24? ICreditTransferTransaction22.CreditorAccount => CreditorAccount;
    IPartyIdentification43? ICreditTransferTransaction22.UltimateCreditor => UltimateCreditor;
    IEnumerable<IInstructionForCreditorAgent1> ICreditTransferTransaction22.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IPurpose2Choice? ICreditTransferTransaction22.Purpose => Purpose;
    IEnumerable<IRegulatoryReporting3> ICreditTransferTransaction22.RegulatoryReporting => RegulatoryReporting;
    ITaxInformation3? ICreditTransferTransaction22.Tax => Tax;
    IEnumerable<IRemittanceLocation4> ICreditTransferTransaction22.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation11? ICreditTransferTransaction22.RemittanceInformation => RemittanceInformation;
    IEnumerable<ISupplementaryData1> ICreditTransferTransaction22.SupplementaryData => SupplementaryData;
}
