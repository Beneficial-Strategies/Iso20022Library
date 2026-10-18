// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction149 : IPaymentTransaction149
{
    IOriginalGroupInformation29? IPaymentTransaction149.OriginalGroupInformation => OriginalGroupInformation;
    ISettlementDateTimeIndication1? IPaymentTransaction149.SettlementTimeIndication => SettlementTimeIndication;
    IEnumerable<ICharges16> IPaymentTransaction149.ChargesInformation => ChargesInformation;
    IBranchAndFinancialInstitutionIdentification8? IPaymentTransaction149.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification8? IPaymentTransaction149.InstructedAgent => InstructedAgent;
    IEnumerable<IPaymentReversalReason10> IPaymentTransaction149.ReversalReasonInformation => ReversalReasonInformation;
    IOriginalTransactionReference42? IPaymentTransaction149.OriginalTransactionReference => OriginalTransactionReference;
    IEnumerable<ISupplementaryData1> IPaymentTransaction149.SupplementaryData => SupplementaryData;
}
