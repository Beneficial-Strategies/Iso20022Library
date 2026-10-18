// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransactionInformation10 : ICreditTransferTransactionInformation10
{
    IPaymentIdentification1 ICreditTransferTransactionInformation10.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation19? ICreditTransferTransactionInformation10.PaymentTypeInformation => PaymentTypeInformation;
    IAmountType3Choice ICreditTransferTransactionInformation10.Amount => Amount;
    IExchangeRateInformation1? ICreditTransferTransactionInformation10.ExchangeRateInformation => ExchangeRateInformation;
    ICheque6? ICreditTransferTransactionInformation10.ChequeInstruction => ChequeInstruction;
    IPartyIdentification32? ICreditTransferTransactionInformation10.UltimateDebtor => UltimateDebtor;
    IBranchAndFinancialInstitutionIdentification4? ICreditTransferTransactionInformation10.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount16? ICreditTransferTransactionInformation10.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification4? ICreditTransferTransactionInformation10.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount16? ICreditTransferTransactionInformation10.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification4? ICreditTransferTransactionInformation10.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount16? ICreditTransferTransactionInformation10.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IBranchAndFinancialInstitutionIdentification4? ICreditTransferTransactionInformation10.CreditorAgent => CreditorAgent;
    ICashAccount16? ICreditTransferTransactionInformation10.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification32? ICreditTransferTransactionInformation10.Creditor => Creditor;
    ICashAccount16? ICreditTransferTransactionInformation10.CreditorAccount => CreditorAccount;
    IPartyIdentification32? ICreditTransferTransactionInformation10.UltimateCreditor => UltimateCreditor;
    IEnumerable<IInstructionForCreditorAgent1> ICreditTransferTransactionInformation10.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IPurpose2Choice? ICreditTransferTransactionInformation10.Purpose => Purpose;
    IEnumerable<IRegulatoryReporting3> ICreditTransferTransactionInformation10.RegulatoryReporting => RegulatoryReporting;
    ITaxInformation3? ICreditTransferTransactionInformation10.Tax => Tax;
    IEnumerable<IRemittanceLocation2> ICreditTransferTransactionInformation10.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation5? ICreditTransferTransactionInformation10.RemittanceInformation => RemittanceInformation;
}
