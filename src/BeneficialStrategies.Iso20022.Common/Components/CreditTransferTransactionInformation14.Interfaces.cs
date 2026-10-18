// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransactionInformation14 : ICreditTransferTransactionInformation14
{
    IPaymentIdentification1 ICreditTransferTransactionInformation14.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation19? ICreditTransferTransactionInformation14.PaymentTypeInformation => PaymentTypeInformation;
    IAmountType3Choice ICreditTransferTransactionInformation14.Amount => Amount;
    ICheque6? ICreditTransferTransactionInformation14.ChequeInstruction => ChequeInstruction;
    IPartyIdentification43? ICreditTransferTransactionInformation14.UltimateDebtor => UltimateDebtor;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransactionInformation14.IntermediaryAgent1 => IntermediaryAgent1;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransactionInformation14.IntermediaryAgent2 => IntermediaryAgent2;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransactionInformation14.IntermediaryAgent3 => IntermediaryAgent3;
    IBranchAndFinancialInstitutionIdentification5 ICreditTransferTransactionInformation14.CreditorAgent => CreditorAgent;
    IPartyIdentification43 ICreditTransferTransactionInformation14.Creditor => Creditor;
    ICashAccount16? ICreditTransferTransactionInformation14.CreditorAccount => CreditorAccount;
    IPartyIdentification43? ICreditTransferTransactionInformation14.UltimateCreditor => UltimateCreditor;
    IEnumerable<IInstructionForCreditorAgent1> ICreditTransferTransactionInformation14.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IPurpose2Choice? ICreditTransferTransactionInformation14.Purpose => Purpose;
    IEnumerable<IRegulatoryReporting3> ICreditTransferTransactionInformation14.RegulatoryReporting => RegulatoryReporting;
    ITaxInformation3? ICreditTransferTransactionInformation14.Tax => Tax;
    IEnumerable<IRemittanceLocation2> ICreditTransferTransactionInformation14.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation6? ICreditTransferTransactionInformation14.RemittanceInformation => RemittanceInformation;
}
