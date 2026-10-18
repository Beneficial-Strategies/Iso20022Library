// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction112 : IPaymentTransaction112
{
    IOriginalGroupInformation29? IPaymentTransaction112.OriginalGroupInformation => OriginalGroupInformation;
    ISettlementDateTimeIndication1? IPaymentTransaction112.SettlementTimeIndication => SettlementTimeIndication;
    IEnumerable<ICharges7> IPaymentTransaction112.ChargesInformation => ChargesInformation;
    IBranchAndFinancialInstitutionIdentification6? IPaymentTransaction112.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification6? IPaymentTransaction112.InstructedAgent => InstructedAgent;
    ITransactionParties7? IPaymentTransaction112.ReturnChain => ReturnChain;
    IEnumerable<IPaymentReturnReason6> IPaymentTransaction112.ReturnReasonInformation => ReturnReasonInformation;
    IOriginalTransactionReference28? IPaymentTransaction112.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction112.SupplementaryData => SupplementaryData;
}
