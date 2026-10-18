// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction34 : ICreditTransferTransaction34
{
    IPaymentIdentification6 ICreditTransferTransaction34.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation26? ICreditTransferTransaction34.PaymentTypeInformation => PaymentTypeInformation;
    IAmountType4Choice ICreditTransferTransaction34.Amount => Amount;
    IExchangeRate1? ICreditTransferTransaction34.ExchangeRateInformation => ExchangeRateInformation;
    ICheque11? ICreditTransferTransaction34.ChequeInstruction => ChequeInstruction;
    IPartyIdentification135? ICreditTransferTransaction34.UltimateDebtor => UltimateDebtor;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction34.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount38? ICreditTransferTransaction34.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction34.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount38? ICreditTransferTransaction34.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction34.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount38? ICreditTransferTransaction34.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction34.CreditorAgent => CreditorAgent;
    ICashAccount38? ICreditTransferTransaction34.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification135? ICreditTransferTransaction34.Creditor => Creditor;
    ICashAccount38? ICreditTransferTransaction34.CreditorAccount => CreditorAccount;
    IPartyIdentification135? ICreditTransferTransaction34.UltimateCreditor => UltimateCreditor;
    IEnumerable<IInstructionForCreditorAgent1> ICreditTransferTransaction34.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IPurpose2Choice? ICreditTransferTransaction34.Purpose => Purpose;
    IEnumerable<IRegulatoryReporting3> ICreditTransferTransaction34.RegulatoryReporting => RegulatoryReporting;
    ITaxInformation8? ICreditTransferTransaction34.Tax => Tax;
    IEnumerable<IRemittanceLocation7> ICreditTransferTransaction34.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation16? ICreditTransferTransaction34.RemittanceInformation => RemittanceInformation;
    IEnumerable<ISupplementaryData1> ICreditTransferTransaction34.SupplementaryData => SupplementaryData;
}
