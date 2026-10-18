// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction168 : IPaymentTransaction168
{
    IOriginalGroupInformation33? IPaymentTransaction168.OriginalGroupInformation => OriginalGroupInformation;
    IPaymentTypeInformation28? IPaymentTransaction168.PaymentTypeInformation => PaymentTypeInformation;
    ISettlementDateTimeIndication1? IPaymentTransaction168.SettlementTimeIndication => SettlementTimeIndication;
    ISettlementTimeRequest2? IPaymentTransaction168.SettlementTimeRequest => SettlementTimeRequest;
    ICurrencyExchange26? IPaymentTransaction168.AgreedRate => AgreedRate;
    IEnumerable<ICharges16> IPaymentTransaction168.ChargesInformation => ChargesInformation;
    IBranchAndFinancialInstitutionIdentification8? IPaymentTransaction168.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification8? IPaymentTransaction168.InstructedAgent => InstructedAgent;
    ITransactionParties11? IPaymentTransaction168.ReturnChain => ReturnChain;
    IEnumerable<IPaymentReturnReason7> IPaymentTransaction168.ReturnReasonInformation => ReturnReasonInformation;
    IOriginalTransactionReference45? IPaymentTransaction168.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction168.SupplementaryData => SupplementaryData;
}
