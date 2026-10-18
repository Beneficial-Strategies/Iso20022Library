// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransactionInformation1 : ICreditTransferTransactionInformation1
{
    IPaymentIdentification1 ICreditTransferTransactionInformation1.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation1? ICreditTransferTransactionInformation1.PaymentTypeInformation => PaymentTypeInformation;
    IAmountType2Choice ICreditTransferTransactionInformation1.Amount => Amount;
    IExchangeRateInformation1? ICreditTransferTransactionInformation1.ExchangeRateInformation => ExchangeRateInformation;
    ICheque5? ICreditTransferTransactionInformation1.ChequeInstruction => ChequeInstruction;
    IPartyIdentification8? ICreditTransferTransactionInformation1.UltimateDebtor => UltimateDebtor;
    IBranchAndFinancialInstitutionIdentification3? ICreditTransferTransactionInformation1.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount7? ICreditTransferTransactionInformation1.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification3? ICreditTransferTransactionInformation1.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount7? ICreditTransferTransactionInformation1.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification3? ICreditTransferTransactionInformation1.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount7? ICreditTransferTransactionInformation1.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IBranchAndFinancialInstitutionIdentification3? ICreditTransferTransactionInformation1.CreditorAgent => CreditorAgent;
    ICashAccount7? ICreditTransferTransactionInformation1.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification8? ICreditTransferTransactionInformation1.Creditor => Creditor;
    ICashAccount7? ICreditTransferTransactionInformation1.CreditorAccount => CreditorAccount;
    IPartyIdentification8? ICreditTransferTransactionInformation1.UltimateCreditor => UltimateCreditor;
    IEnumerable<IInstructionForCreditorAgent1> ICreditTransferTransactionInformation1.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IPurpose1Choice? ICreditTransferTransactionInformation1.Purpose => Purpose;
    IEnumerable<IRegulatoryReporting2> ICreditTransferTransactionInformation1.RegulatoryReporting => RegulatoryReporting;
    ITaxInformation2? ICreditTransferTransactionInformation1.Tax => Tax;
    IEnumerable<IRemittanceLocation1> ICreditTransferTransactionInformation1.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation1? ICreditTransferTransactionInformation1.RemittanceInformation => RemittanceInformation;
}
