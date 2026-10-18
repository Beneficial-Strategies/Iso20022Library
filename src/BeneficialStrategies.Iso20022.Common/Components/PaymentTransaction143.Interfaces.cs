// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction143 : IPaymentTransaction143
{
    IOriginalGroupInformation29? IPaymentTransaction143.OriginalGroupInformation => OriginalGroupInformation;
    ISettlementDateTimeIndication1? IPaymentTransaction143.SettlementTimeIndication => SettlementTimeIndication;
    IEnumerable<ICharges12> IPaymentTransaction143.ChargesInformation => ChargesInformation;
    IBranchAndFinancialInstitutionIdentification6? IPaymentTransaction143.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification6? IPaymentTransaction143.InstructedAgent => InstructedAgent;
    IEnumerable<IPaymentReversalReason9> IPaymentTransaction143.ReversalReasonInformation => ReversalReasonInformation;
    IOriginalTransactionReference35? IPaymentTransaction143.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction143.SupplementaryData => SupplementaryData;
}
