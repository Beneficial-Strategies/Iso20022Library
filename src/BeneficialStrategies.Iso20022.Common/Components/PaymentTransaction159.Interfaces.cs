// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction159 : IPaymentTransaction159
{
    IEnumerable<ICharges16> IPaymentTransaction159.ChargesInformation => ChargesInformation;
    IBranchAndFinancialInstitutionIdentification8? IPaymentTransaction159.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification8? IPaymentTransaction159.InstructingAgent => InstructingAgent;
    IOriginalGroupInformation29? IPaymentTransaction159.OriginalGroupInformation => OriginalGroupInformation;
    IOriginalTransactionReference41? IPaymentTransaction159.OriginalTransactionReference => OriginalTransactionReference;
    IPaymentTypeInformation28? IPaymentTransaction159.PaymentTypeInformation => PaymentTypeInformation;
    ITransactionParties11? IPaymentTransaction159.ReturnChain => ReturnChain;
    IEnumerable<IPaymentReturnReason7> IPaymentTransaction159.ReturnReasonInformation => ReturnReasonInformation;
    ISettlementDateTimeIndication1? IPaymentTransaction159.SettlementTimeIndication => SettlementTimeIndication;
    ISettlementTimeRequest2? IPaymentTransaction159.SettlementTimeRequest => SettlementTimeRequest;
    IEnumerable<ISupplementaryData1> IPaymentTransaction159.SupplementaryData => SupplementaryData;
}
