// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction163 : IPaymentTransaction163
{
    ICurrencyExchange26? IPaymentTransaction163.AgreedRate => AgreedRate;
    IEnumerable<ICharges16> IPaymentTransaction163.ChargesInformation => ChargesInformation;
    IBranchAndFinancialInstitutionIdentification8? IPaymentTransaction163.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification8? IPaymentTransaction163.InstructingAgent => InstructingAgent;
    IOriginalGroupInformation29? IPaymentTransaction163.OriginalGroupInformation => OriginalGroupInformation;
    IOriginalTransactionReference44? IPaymentTransaction163.OriginalTransactionReference => OriginalTransactionReference;
    IPaymentTypeInformation28? IPaymentTransaction163.PaymentTypeInformation => PaymentTypeInformation;
    ITransactionParties11? IPaymentTransaction163.ReturnChain => ReturnChain;
    IEnumerable<IPaymentReturnReason7> IPaymentTransaction163.ReturnReasonInformation => ReturnReasonInformation;
    ISettlementDateTimeIndication1? IPaymentTransaction163.SettlementTimeIndication => SettlementTimeIndication;
    ISettlementTimeRequest2? IPaymentTransaction163.SettlementTimeRequest => SettlementTimeRequest;
    IEnumerable<ISupplementaryData1> IPaymentTransaction163.SupplementaryData => SupplementaryData;
}
