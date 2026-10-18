// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction149 : IPaymentTransaction149
{
    IEnumerable<ICharges16> IPaymentTransaction149.ChargesInformation => ChargesInformation;
    IBranchAndFinancialInstitutionIdentification8? IPaymentTransaction149.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification8? IPaymentTransaction149.InstructingAgent => InstructingAgent;
    IOriginalGroupInformation29? IPaymentTransaction149.OriginalGroupInformation => OriginalGroupInformation;
    IOriginalTransactionReference42? IPaymentTransaction149.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<IPaymentReversalReason10> IPaymentTransaction149.ReversalReasonInformation => ReversalReasonInformation;
    ISettlementDateTimeIndication1? IPaymentTransaction149.SettlementTimeIndication => SettlementTimeIndication;
    IEnumerable<ISupplementaryData1> IPaymentTransaction149.SupplementaryData => SupplementaryData;
}
