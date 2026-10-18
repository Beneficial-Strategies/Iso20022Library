// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction6 : ICreditTransferTransaction6
{
    IPaymentIdentification1 ICreditTransferTransaction6.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation19? ICreditTransferTransaction6.PaymentTypeInformation => PaymentTypeInformation;
    IAmountType3Choice ICreditTransferTransaction6.Amount => Amount;
    IExchangeRate1? ICreditTransferTransaction6.ExchangeRateInformation => ExchangeRateInformation;
    ICheque7? ICreditTransferTransaction6.ChequeInstruction => ChequeInstruction;
    IPartyIdentification43? ICreditTransferTransaction6.UltimateDebtor => UltimateDebtor;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction6.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount24? ICreditTransferTransaction6.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction6.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount24? ICreditTransferTransaction6.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction6.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount24? ICreditTransferTransaction6.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction6.CreditorAgent => CreditorAgent;
    ICashAccount24? ICreditTransferTransaction6.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification43? ICreditTransferTransaction6.Creditor => Creditor;
    ICashAccount24? ICreditTransferTransaction6.CreditorAccount => CreditorAccount;
    IPartyIdentification43? ICreditTransferTransaction6.UltimateCreditor => UltimateCreditor;
    IEnumerable<IInstructionForCreditorAgent1> ICreditTransferTransaction6.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IPurpose2Choice? ICreditTransferTransaction6.Purpose => Purpose;
    IEnumerable<IRegulatoryReporting3> ICreditTransferTransaction6.RegulatoryReporting => RegulatoryReporting;
    ITaxInformation3? ICreditTransferTransaction6.Tax => Tax;
    IEnumerable<IRemittanceLocation2> ICreditTransferTransaction6.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation7? ICreditTransferTransaction6.RemittanceInformation => RemittanceInformation;
    IEnumerable<ISupplementaryData1> ICreditTransferTransaction6.SupplementaryData => SupplementaryData;
}
