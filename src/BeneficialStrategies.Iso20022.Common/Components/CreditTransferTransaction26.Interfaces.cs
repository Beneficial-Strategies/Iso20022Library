// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction26 : ICreditTransferTransaction26
{
    IPaymentIdentification1 ICreditTransferTransaction26.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation19? ICreditTransferTransaction26.PaymentTypeInformation => PaymentTypeInformation;
    IAmountType4Choice ICreditTransferTransaction26.Amount => Amount;
    IExchangeRate1? ICreditTransferTransaction26.ExchangeRateInformation => ExchangeRateInformation;
    ICheque7? ICreditTransferTransaction26.ChequeInstruction => ChequeInstruction;
    IPartyIdentification43? ICreditTransferTransaction26.UltimateDebtor => UltimateDebtor;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction26.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount24? ICreditTransferTransaction26.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction26.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount24? ICreditTransferTransaction26.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction26.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount24? ICreditTransferTransaction26.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction26.CreditorAgent => CreditorAgent;
    ICashAccount24? ICreditTransferTransaction26.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification43? ICreditTransferTransaction26.Creditor => Creditor;
    ICashAccount24? ICreditTransferTransaction26.CreditorAccount => CreditorAccount;
    IPartyIdentification43? ICreditTransferTransaction26.UltimateCreditor => UltimateCreditor;
    IEnumerable<IInstructionForCreditorAgent1> ICreditTransferTransaction26.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IPurpose2Choice? ICreditTransferTransaction26.Purpose => Purpose;
    IEnumerable<IRegulatoryReporting3> ICreditTransferTransaction26.RegulatoryReporting => RegulatoryReporting;
    ITaxInformation3? ICreditTransferTransaction26.Tax => Tax;
    IEnumerable<IRemittanceLocation4> ICreditTransferTransaction26.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation11? ICreditTransferTransaction26.RemittanceInformation => RemittanceInformation;
    IEnumerable<ISupplementaryData1> ICreditTransferTransaction26.SupplementaryData => SupplementaryData;
}
