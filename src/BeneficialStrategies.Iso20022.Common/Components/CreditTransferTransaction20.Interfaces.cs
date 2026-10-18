// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction20 : ICreditTransferTransaction20
{
    IPaymentIdentification1 ICreditTransferTransaction20.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation19? ICreditTransferTransaction20.PaymentTypeInformation => PaymentTypeInformation;
    IAmountType4Choice ICreditTransferTransaction20.Amount => Amount;
    IExchangeRate1? ICreditTransferTransaction20.ExchangeRateInformation => ExchangeRateInformation;
    ICheque7? ICreditTransferTransaction20.ChequeInstruction => ChequeInstruction;
    IPartyIdentification43? ICreditTransferTransaction20.UltimateDebtor => UltimateDebtor;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction20.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount24? ICreditTransferTransaction20.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction20.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount24? ICreditTransferTransaction20.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction20.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount24? ICreditTransferTransaction20.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction20.CreditorAgent => CreditorAgent;
    ICashAccount24? ICreditTransferTransaction20.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification43? ICreditTransferTransaction20.Creditor => Creditor;
    ICashAccount24? ICreditTransferTransaction20.CreditorAccount => CreditorAccount;
    IPartyIdentification43? ICreditTransferTransaction20.UltimateCreditor => UltimateCreditor;
    IEnumerable<IInstructionForCreditorAgent1> ICreditTransferTransaction20.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IPurpose2Choice? ICreditTransferTransaction20.Purpose => Purpose;
    IEnumerable<IRegulatoryReporting3> ICreditTransferTransaction20.RegulatoryReporting => RegulatoryReporting;
    ITaxInformation3? ICreditTransferTransaction20.Tax => Tax;
    IEnumerable<IRemittanceLocation4> ICreditTransferTransaction20.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation10? ICreditTransferTransaction20.RemittanceInformation => RemittanceInformation;
    IEnumerable<ISupplementaryData1> ICreditTransferTransaction20.SupplementaryData => SupplementaryData;
}
