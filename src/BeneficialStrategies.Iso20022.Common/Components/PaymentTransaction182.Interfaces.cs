// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction182 : IPaymentTransaction182
{
    IOriginalGroupInformation33? IPaymentTransaction182.OriginalGroupInformation => OriginalGroupInformation;
    ISettlementDateTimeIndication1? IPaymentTransaction182.SettlementTimeIndication => SettlementTimeIndication;
    IEnumerable<ICharges16> IPaymentTransaction182.ChargesInformation => ChargesInformation;
    IBranchAndFinancialInstitutionIdentification8? IPaymentTransaction182.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification8? IPaymentTransaction182.InstructedAgent => InstructedAgent;
    IEnumerable<IPaymentReversalReason10> IPaymentTransaction182.ReversalReasonInformation => ReversalReasonInformation;
    IOriginalTransactionReference47? IPaymentTransaction182.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction182.SupplementaryData => SupplementaryData;
}
